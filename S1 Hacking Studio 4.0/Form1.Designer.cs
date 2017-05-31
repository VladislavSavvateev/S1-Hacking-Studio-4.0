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
			this.SuspendLayout();
			// 
			// btnBossGenerator
			// 
			this.btnBossGenerator.Location = new System.Drawing.Point(12, 12);
			this.btnBossGenerator.Name = "btnBossGenerator";
			this.btnBossGenerator.Size = new System.Drawing.Size(110, 23);
			this.btnBossGenerator.TabIndex = 0;
			this.btnBossGenerator.Text = "Генератор боссов";
			this.btnBossGenerator.UseVisualStyleBackColor = true;
			this.btnBossGenerator.Click += new System.EventHandler(this.btnBossGenerator_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnBossGenerator);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnBossGenerator;
	}
}

