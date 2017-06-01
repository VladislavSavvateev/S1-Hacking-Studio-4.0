using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace S1_Hacking_Studio_4._0 {
	public partial class Form1 : Form {
        

        public Form1() {
			InitializeComponent();
		}

		private void btnBossGenerator_Click(object sender, EventArgs e) {
			new BossGenerator().ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e) {
			new GraphicImprover().ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e) {
			new MP3_To_SMPS().ShowDialog();
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
