using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

		GenaWaiting gw;
		SaveFileDialog sfd;

		private void btnConvert_Click(object sender, EventArgs e) {
			if (txtPath.Text == "") {
				MessageBox.Show("Выберите MP3-файл!!", "*_*", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			sfd = new SaveFileDialog();
			sfd.Title = "Куда сохранить SMPS?";
			sfd.Filter = "SMPS файлы|*.bin";
			if (sfd.ShowDialog() != DialogResult.OK) return;

			new Thread(new ThreadStart(dich)).Start();

			gw = new GenaWaiting();
			gw.ShowDialog();
		}

		void dich() {
			while (gw == null);
			SetText(gw.lblStatus, "Анализ частотных данных...");
			Thread.Sleep(new Random().Next(500, 3000));
			SetText(gw.lblStatus, "Выделение нотных данных...");
			Thread.Sleep(new Random().Next(500, 3000));
			SetText(gw.lblStatus, "Разделение по инструментам...");
			Thread.Sleep(new Random().Next(500, 3000));
			SetText(gw.lblStatus, "Анализ примененных эффектов...");
			Thread.Sleep(new Random().Next(500, 3000));
			SetText(gw.lblStatus, "Оптимизация под формат SMPS...");
			Thread.Sleep(new Random().Next(500, 3000));
			SetText(gw.lblStatus, "Создание оптимальных голосов SMPS...");
			Thread.Sleep(new Random().Next(500, 3000));
			SetText(gw.lblStatus, "Конвертация в SMPS...");
			Thread.Sleep(new Random().Next(500, 3000));

			FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
			byte[] smps = Properties.Resources.Rick_Astley___Give_You_Up;
			fs.Write(smps, 0, smps.Length);
			fs.Close();
			CloseForm(gw);
			MessageBox.Show("Конвертация успешно завершена!", "*_*", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		delegate void CloseFormHandler(Form f);
		delegate void SetTextHandler(Label l, String s);
		void CloseForm(Form f) {
			if (f.InvokeRequired) f.Invoke(new CloseFormHandler(CloseForm), new object[] { f });
			else f.Close();
		}
		void SetText(Label l, String s) {
			if (l.InvokeRequired) l.Invoke(new SetTextHandler(SetText), new object[] { l, s });
			else l.Text = s;
		}

	}
}
