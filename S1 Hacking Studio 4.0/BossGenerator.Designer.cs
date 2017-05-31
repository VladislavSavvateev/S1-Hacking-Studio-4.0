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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BossGenerator));
			this.label1 = new System.Windows.Forms.Label();
			this.rchCode = new System.Windows.Forms.RichTextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(392, 70);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// rchCode
			// 
			this.rchCode.Location = new System.Drawing.Point(12, 82);
			this.rchCode.Name = "rchCode";
			this.rchCode.Size = new System.Drawing.Size(392, 307);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label2.Location = new System.Drawing.Point(312, 400);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Powered by Gena";
			// 
			// BossGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 430);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.rchCode);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BossGenerator";
			this.Text = "BossGenerator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rchCode;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label label2;
	}
}