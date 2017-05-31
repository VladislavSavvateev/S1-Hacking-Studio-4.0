using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S1_Hacking_Studio_4._0 {
	public partial class MP3_To_SMPS : Form {
		public MP3_To_SMPS() {
			InitializeComponent();
		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Выберите MP3-файл";
			ofd.Filter = "MP3-файлы|*.mp3";
			if (ofd.ShowDialog() != DialogResult.OK) return;
			txtPath.Text = ofd.FileName;
		}

		private void btnConvert_Click(object sender, EventArgs e) {
			if (txtPath.Text == "") {
				MessageBox.Show("Выберите MP3-файл!!", "*_*", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Куда сохранить SMPS?";
			sfd.Filter = "SMPS файлы|*.bin";
			if (sfd.ShowDialog() != DialogResult.OK) return;

			Thread.Sleep(new Random().Next(500, 3000));	// делаем вид, что работаем

			FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
			byte[] smps = Properties.Resources.Rick_Astley___Give_You_Up;
			fs.Write(smps, 0, smps.Length);
			fs.Close();
			MessageBox.Show("Конвертация успешно завершена!", "*_*", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
