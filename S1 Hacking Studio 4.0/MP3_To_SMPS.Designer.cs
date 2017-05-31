namespace S1_Hacking_Studio_4._0 {
	partial class MP3_To_SMPS {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnBrowse);
			this.groupBox1.Controls.Add(this.txtPath);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(393, 47);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Путь до MP3";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(6, 19);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(300, 20);
			this.txtPath.TabIndex = 0;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(312, 17);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Обзор...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(288, 80);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(111, 23);
			this.btnConvert.TabIndex = 1;
			this.btnConvert.Text = "Сконвертировать!";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(395, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ivan YO говорил, что такого конвертера не существует, но мы сделали его!";
			// 
			// MP3_To_SMPS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 117);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MP3_To_SMPS";
			this.Text = "MP3 To SMPS";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Label label1;
	}
}