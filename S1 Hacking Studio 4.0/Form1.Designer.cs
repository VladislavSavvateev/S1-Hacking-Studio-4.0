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
			this.btnBossGenerator = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBossGenerator
			// 
			this.btnBossGenerator.Location = new System.Drawing.Point(12, 12);
			this.btnBossGenerator.Name = "btnBossGenerator";
			this.btnBossGenerator.Size = new System.Drawing.Size(123, 23);
			this.btnBossGenerator.TabIndex = 0;
			this.btnBossGenerator.Text = "Генератор боссов";
			this.btnBossGenerator.UseVisualStyleBackColor = true;
			this.btnBossGenerator.Click += new System.EventHandler(this.btnBossGenerator_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 41);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Улучшатель графики";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 70);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "MP3 -> SMPS";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnBossGenerator);
			this.Name = "Form1";
			this.Text = "S1 Hacking Studio 4.0";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBossGenerator;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

