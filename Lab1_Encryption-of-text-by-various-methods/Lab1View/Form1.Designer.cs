namespace Lab1View
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.SecondKeyBox = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.encriptTextBox = new System.Windows.Forms.TextBox();
			this.EncriptBtn = new System.Windows.Forms.Button();
			this.encriptTextLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.FirstKeyBox = new System.Windows.Forms.TextBox();
			this.textSent = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.decriptSecondKey = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.decriptText = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.decriptFirstKey = new System.Windows.Forms.TextBox();
			this.encriptText = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label15 = new System.Windows.Forms.Label();
			this.findKeyBtn = new System.Windows.Forms.Button();
			this.listBoxKeys = new System.Windows.Forms.ListBox();
			this.label13 = new System.Windows.Forms.Label();
			this.decryptedMessBox = new System.Windows.Forms.TextBox();
			this.encriptedMessBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(453, 467);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Gray;
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.SecondKeyBox);
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Controls.Add(this.encriptTextBox);
			this.tabPage1.Controls.Add(this.EncriptBtn);
			this.tabPage1.Controls.Add(this.encriptTextLabel);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.FirstKeyBox);
			this.tabPage1.Controls.Add(this.textSent);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(445, 438);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Encription";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(211, 157);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(148, 19);
			this.label10.TabIndex = 11;
			this.label10.Text = "Second Key:";
			// 
			// SecondKeyBox
			// 
			this.SecondKeyBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SecondKeyBox.Location = new System.Drawing.Point(215, 179);
			this.SecondKeyBox.Name = "SecondKeyBox";
			this.SecondKeyBox.Size = new System.Drawing.Size(172, 28);
			this.SecondKeyBox.TabIndex = 10;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Шифр Плейфра",
            "Шифр Виженера",
            "Аффинный шифр"});
			this.comboBox1.Location = new System.Drawing.Point(18, 107);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(137, 26);
			this.comboBox1.TabIndex = 9;
			this.comboBox1.Text = "Виберіть шифр";
			// 
			// encriptTextBox
			// 
			this.encriptTextBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.encriptTextBox.Location = new System.Drawing.Point(18, 297);
			this.encriptTextBox.Name = "encriptTextBox";
			this.encriptTextBox.Size = new System.Drawing.Size(369, 28);
			this.encriptTextBox.TabIndex = 8;
			// 
			// EncriptBtn
			// 
			this.EncriptBtn.Location = new System.Drawing.Point(118, 358);
			this.EncriptBtn.Name = "EncriptBtn";
			this.EncriptBtn.Size = new System.Drawing.Size(202, 54);
			this.EncriptBtn.TabIndex = 7;
			this.EncriptBtn.Text = "Encript";
			this.EncriptBtn.UseVisualStyleBackColor = true;
			this.EncriptBtn.Click += new System.EventHandler(this.EncriptBtn_Click);
			// 
			// encriptTextLabel
			// 
			this.encriptTextLabel.AutoSize = true;
			this.encriptTextLabel.Location = new System.Drawing.Point(21, 301);
			this.encriptTextLabel.Name = "encriptTextLabel";
			this.encriptTextLabel.Size = new System.Drawing.Size(0, 16);
			this.encriptTextLabel.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 269);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(209, 19);
			this.label4.TabIndex = 5;
			this.label4.Text = "Encrypted text:";
			// 
			// FirstKeyBox
			// 
			this.FirstKeyBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FirstKeyBox.Location = new System.Drawing.Point(18, 179);
			this.FirstKeyBox.Name = "FirstKeyBox";
			this.FirstKeyBox.Size = new System.Drawing.Size(166, 28);
			this.FirstKeyBox.TabIndex = 4;
			// 
			// textSent
			// 
			this.textSent.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textSent.Location = new System.Drawing.Point(19, 238);
			this.textSent.Name = "textSent";
			this.textSent.Size = new System.Drawing.Size(369, 28);
			this.textSent.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "First key:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Text:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(112, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(235, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Encryption";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Gray;
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.decriptSecondKey);
			this.tabPage2.Controls.Add(this.comboBox2);
			this.tabPage2.Controls.Add(this.decriptText);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.decriptFirstKey);
			this.tabPage2.Controls.Add(this.encriptText);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(445, 438);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Decryption";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(15, 157);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(126, 19);
			this.label12.TabIndex = 21;
			this.label12.Text = "First key:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(211, 157);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(148, 19);
			this.label11.TabIndex = 20;
			this.label11.Text = "Second Key:";
			// 
			// decriptSecondKey
			// 
			this.decriptSecondKey.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.decriptSecondKey.Location = new System.Drawing.Point(215, 179);
			this.decriptSecondKey.Name = "decriptSecondKey";
			this.decriptSecondKey.Size = new System.Drawing.Size(172, 28);
			this.decriptSecondKey.TabIndex = 19;
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Шифр Плейфра",
            "Шифр Виженера",
            "Аффинный шифр"});
			this.comboBox2.Location = new System.Drawing.Point(19, 107);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(137, 26);
			this.comboBox2.TabIndex = 18;
			this.comboBox2.Text = "Виберіть шифр";
			// 
			// decriptText
			// 
			this.decriptText.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.decriptText.Location = new System.Drawing.Point(18, 297);
			this.decriptText.Name = "decriptText";
			this.decriptText.Size = new System.Drawing.Size(369, 28);
			this.decriptText.TabIndex = 17;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(118, 358);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(202, 54);
			this.button1.TabIndex = 16;
			this.button1.Text = "Decript";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.DecriptBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 302);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 16);
			this.label5.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 269);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(209, 19);
			this.label6.TabIndex = 14;
			this.label6.Text = "Decrypted text:";
			// 
			// decriptFirstKey
			// 
			this.decriptFirstKey.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.decriptFirstKey.Location = new System.Drawing.Point(19, 179);
			this.decriptFirstKey.Name = "decriptFirstKey";
			this.decriptFirstKey.Size = new System.Drawing.Size(150, 28);
			this.decriptFirstKey.TabIndex = 13;
			// 
			// encriptText
			// 
			this.encriptText.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.encriptText.Location = new System.Drawing.Point(19, 238);
			this.encriptText.Name = "encriptText";
			this.encriptText.Size = new System.Drawing.Size(369, 28);
			this.encriptText.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(15, 216);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 19);
			this.label8.TabIndex = 10;
			this.label8.Text = "Text:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(112, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(234, 32);
			this.label9.TabIndex = 9;
			this.label9.Text = "Decryption";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Gray;
			this.tabPage3.Controls.Add(this.label15);
			this.tabPage3.Controls.Add(this.findKeyBtn);
			this.tabPage3.Controls.Add(this.listBoxKeys);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.decryptedMessBox);
			this.tabPage3.Controls.Add(this.encriptedMessBox);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(445, 438);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Find Keys";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(20, 188);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(263, 19);
			this.label15.TabIndex = 18;
			this.label15.Text = "Possible key options:";
			// 
			// findKeyBtn
			// 
			this.findKeyBtn.Location = new System.Drawing.Point(123, 114);
			this.findKeyBtn.Name = "findKeyBtn";
			this.findKeyBtn.Size = new System.Drawing.Size(202, 54);
			this.findKeyBtn.TabIndex = 17;
			this.findKeyBtn.Text = "Encript";
			this.findKeyBtn.UseVisualStyleBackColor = true;
			this.findKeyBtn.Click += new System.EventHandler(this.findKeyBtn_Click);
			// 
			// listBoxKeys
			// 
			this.listBoxKeys.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxKeys.FormattingEnabled = true;
			this.listBoxKeys.ItemHeight = 18;
			this.listBoxKeys.Location = new System.Drawing.Point(18, 210);
			this.listBoxKeys.Name = "listBoxKeys";
			this.listBoxKeys.Size = new System.Drawing.Size(408, 220);
			this.listBoxKeys.TabIndex = 16;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(219, 58);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(207, 19);
			this.label13.TabIndex = 15;
			this.label13.Text = "Decrypted mess:";
			// 
			// decryptedMessBox
			// 
			this.decryptedMessBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.decryptedMessBox.Location = new System.Drawing.Point(223, 80);
			this.decryptedMessBox.Name = "decryptedMessBox";
			this.decryptedMessBox.Size = new System.Drawing.Size(214, 28);
			this.decryptedMessBox.TabIndex = 14;
			// 
			// encriptedMessBox
			// 
			this.encriptedMessBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.encriptedMessBox.Location = new System.Drawing.Point(6, 80);
			this.encriptedMessBox.Name = "encriptedMessBox";
			this.encriptedMessBox.Size = new System.Drawing.Size(211, 28);
			this.encriptedMessBox.TabIndex = 13;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(3, 58);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(197, 19);
			this.label14.TabIndex = 12;
			this.label14.Text = "Encripted mess:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("ROG Fonts", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(117, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(192, 32);
			this.label7.TabIndex = 1;
			this.label7.Text = "Find Keys";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 467);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Лаболаторна робота №1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox FirstKeyBox;
		private System.Windows.Forms.TextBox textSent;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button EncriptBtn;
		private System.Windows.Forms.Label encriptTextLabel;
		private System.Windows.Forms.TextBox encriptTextBox;
		private System.Windows.Forms.TextBox decriptText;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox decriptFirstKey;
		private System.Windows.Forms.TextBox encriptText;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox SecondKeyBox;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox decriptSecondKey;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox decryptedMessBox;
		private System.Windows.Forms.TextBox encriptedMessBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button findKeyBtn;
		private System.Windows.Forms.ListBox listBoxKeys;
		private System.Windows.Forms.Label label15;
	}
}

