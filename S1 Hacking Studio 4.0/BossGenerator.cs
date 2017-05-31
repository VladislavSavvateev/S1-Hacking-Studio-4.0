using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S1_Hacking_Studio_4._0 {
	public partial class BossGenerator : Form {
		public BossGenerator() {
			InitializeComponent();
		}

		long mCounter = 0;
		Keys mKey;

		private void rchCode_KeyDown(object sender, KeyEventArgs e) {
			mKey = e.KeyCode;
		}
		private void rchCode_TextChanged(object sender, EventArgs e) {
			// checking key code
			if (mKey == Keys.Back) { if (mCounter > 0) mCounter--; } else mCounter++;

			// regenerate rich
			rchCode.Text = "";
			for (long i = 0; i < mCounter; i++)
				rchCode.Text += "хуй";
			SendKeys.Send("^{End}");
		}

		private void btnGenerate_Click(object sender, EventArgs e) {
			if (rchCode.Text.Length == 0) {
				MessageBox.Show("Вы не набрали ни единого слова!", "*_*", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Куда сохранить код?";
			sfd.Filter = "Исходный код|*.asm|Все файлы|*.*";
			if (sfd.ShowDialog() != DialogResult.OK) return;
			byte[] code = Properties.Resources.Code;
			FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
			fs.Write(code, 0, code.Length);
			fs.Close();
			MessageBox.Show("Готово!", "*_*", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
