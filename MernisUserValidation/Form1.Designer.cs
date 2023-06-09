namespace MernisUserValidation
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			button2 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			monthCalendar1 = new MonthCalendar();
			Validate = new Button();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(button2);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(342, 42);
			panel1.TabIndex = 0;
			// 
			// button2
			// 
			button2.Location = new Point(294, 9);
			button2.Name = "button2";
			button2.Size = new Size(36, 23);
			button2.TabIndex = 7;
			button2.Text = "X";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(229, 20);
			label1.TabIndex = 0;
			label1.Text = "Mernis User Validation Control";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox1.Location = new Point(49, 133);
			textBox1.MaxLength = 11;
			textBox1.Name = "textBox1";
			textBox1.PlaceholderText = "TC Kimlik Numarası";
			textBox1.Size = new Size(234, 27);
			textBox1.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(127, 84);
			label2.Name = "label2";
			label2.Size = new Size(84, 24);
			label2.TabIndex = 2;
			label2.Text = "MERNİS";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox2.Location = new Point(49, 185);
			textBox2.MaxLength = 11;
			textBox2.Name = "textBox2";
			textBox2.PlaceholderText = "Adınız";
			textBox2.Size = new Size(234, 27);
			textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			textBox3.Location = new Point(49, 239);
			textBox3.MaxLength = 11;
			textBox3.Name = "textBox3";
			textBox3.PlaceholderText = "Soyadınız";
			textBox3.Size = new Size(234, 27);
			textBox3.TabIndex = 4;
			// 
			// monthCalendar1
			// 
			monthCalendar1.Location = new Point(49, 278);
			monthCalendar1.Name = "monthCalendar1";
			monthCalendar1.TabIndex = 5;
			// 
			// Validate
			// 
			Validate.Location = new Point(208, 463);
			Validate.Name = "Validate";
			Validate.Size = new Size(122, 23);
			Validate.TabIndex = 6;
			Validate.Text = "Kontrol Et";
			Validate.UseVisualStyleBackColor = true;
			Validate.Click += Validate_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(342, 498);
			Controls.Add(Validate);
			Controls.Add(monthCalendar1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Mernis User Validation Control";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button button2;
		private MonthCalendar monthCalendar1;
		private Button Validate;
	}
}