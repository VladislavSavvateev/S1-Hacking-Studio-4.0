using SonicRetro.KensSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S1_Hacking_Studio_4._0 {
	public partial class GraphicImprover : Form {
		public GraphicImprover() {
			InitializeComponent();
		}

		byte[] magic = {0x11, 0x11, 0x11, 0x11,
						0x11, 0x12, 0x21, 0x11,
						0x11, 0x12, 0x21, 0x11,
						0x11, 0x12, 0x21, 0x11,
						0x11, 0x12, 0x21, 0x11,
						0x12, 0x22, 0x22, 0x21,
						0x12, 0x21, 0x12, 0x21,
						0x11, 0x11, 0x11, 0x11};

		private void btnBrowse_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Выберите файл с графикой";
			ofd.Filter = "Все файлы|*.*";
			if (ofd.ShowDialog() != DialogResult.OK) return;
			txtPath.Text = ofd.FileName;			
		}

		public enum GraphicEnc {
			NONE,
			NEMESIS,
			KOSINSKI
		}

		private void btnImprove_Click(object sender, EventArgs e) {
			FileStream fs = new FileStream(txtPath.Text, FileMode.Open);
			byte[] arr = new byte[fs.Length];
			fs.Read(arr, 0, arr.Length);
			fs.Close();

			GraphicEnc status;
			try {
				arr = Kosinski.Decompress(arr);
				status = GraphicEnc.KOSINSKI;
			} catch (Exception ex) {
				try {
					arr = Nemesis.Decompress(arr);
					status = GraphicEnc.NEMESIS;
				} catch (Exception ex1) { status = GraphicEnc.NONE; }
			}

			Random r = new Random();
			for (int i = 0; i < arr.Length; i += 32)
				if (r.Next(5) == 1)
					Array.Copy(magic, 0, arr, i, 32);

			switch (status) {
				case GraphicEnc.NEMESIS:
					arr = Nemesis.Compress(arr);
					break;
				case GraphicEnc.KOSINSKI:
					arr = Kosinski.Compress(arr);
					break;
			}

			fs = new FileStream(txtPath.Text, FileMode.Create);
			fs.Write(arr, 0, arr.Length);
			fs.Close();
			MessageBox.Show("Графика успешно улучшена!", "*_*", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
