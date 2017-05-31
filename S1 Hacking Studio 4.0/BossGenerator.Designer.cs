namespace S1_Hacking_Studio_4._0 {
	partial class BossGenerator {
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
			this.label1 = new System.Windows.Forms.Label();
			this.rchCode = new System.Windows.Forms.RichTextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(392, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Работа генератора предельно проста! Просто напишите в свободной форме, какого бос" +
    "са вы хотите создать и магическим путём программа сгенерирует код!";
			// 
			// rchCode
			// 
			this.rchCode.Location = new System.Drawing.Point(12, 56);
			this.rchCode.Name = "rchCode";
			this.rchCode.Size = new System.Drawing.Size(392, 333);
			this.rchCode.TabIndex = 1;
			this.rchCode.Text = "";
			this.rchCode.TextChanged += new System.EventHandler(this.rchCode_TextChanged);
			this.rchCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rchCode_KeyDown);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(12, 395);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(97, 23);
			this.btnGenerate.TabIndex = 2;
			this.btnGenerate.Text = "Сгенерировать!";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// BossGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 430);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.rchCode);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BossGenerator";
			this.Text = "BossGenerator";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rchCode;
		private System.Windows.Forms.Button btnGenerate;
	}
}