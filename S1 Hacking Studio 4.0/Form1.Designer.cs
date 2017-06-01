namespace S1_Hacking_Studio_4._0 {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.btnBossGenerator = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBossGenerator
			// 
			this.btnBossGenerator.Location = new System.Drawing.Point(32, 21);
			this.btnBossGenerator.Name = "btnBossGenerator";
			this.btnBossGenerator.Size = new System.Drawing.Size(123, 23);
			this.btnBossGenerator.TabIndex = 0;
			this.btnBossGenerator.Text = "Генератор боссов";
			this.btnBossGenerator.UseVisualStyleBackColor = true;
			this.btnBossGenerator.Click += new System.EventHandler(this.btnBossGenerator_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 50);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Улучшатель графики";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(32, 79);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "MP3 -> SMPS";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(17, 17, 17);
			this.panel1.Controls.Add(this.btn);
			this.panel1.Controls.Add(this.btnBossGenerator);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 431);
			this.panel1.TabIndex = 3;
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.BackgroundImage = global::S1_Hacking_Studio_4._0.Properties.Resources._32870546794_1fe4deaf24_o;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(200, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(738, 184);
			this.panel2.TabIndex = 4;
			// 
			// btn
			// 
			this.btn.Location = new System.Drawing.Point(32, 108);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(123, 23);
			this.btn.TabIndex = 3;
			this.btn.Text = "Генератор палитр";
			this.btn.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 431);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "S1 Hacking Studio 4.0";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.MouseDown += Form1_MouseDown;

		}

		#endregion

		private System.Windows.Forms.Button btnBossGenerator;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn;
	}
}

