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
			NationalityId = new TextBox();
			label2 = new Label();
			FirstName = new TextBox();
			LastName = new TextBox();
			Validate = new Button();
			BirthOfYear = new DateTimePicker();
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
			// NationalityId
			// 
			NationalityId.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			NationalityId.Location = new Point(49, 133);
			NationalityId.MaxLength = 11;
			NationalityId.Name = "NationalityId";
			NationalityId.PlaceholderText = "TC Kimlik Numarası";
			NationalityId.Size = new Size(234, 27);
			NationalityId.TabIndex = 1;
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
			// FirstName
			// 
			FirstName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			FirstName.Location = new Point(49, 185);
			FirstName.MaxLength = 100;
			FirstName.Name = "FirstName";
			FirstName.PlaceholderText = "Adınız";
			FirstName.Size = new Size(234, 27);
			FirstName.TabIndex = 3;
			// 
			// LastName
			// 
			LastName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			LastName.Location = new Point(49, 239);
			LastName.MaxLength = 100;
			LastName.Name = "LastName";
			LastName.PlaceholderText = "Soyadınız";
			LastName.Size = new Size(234, 27);
			LastName.TabIndex = 4;
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
			// BirthOfYear
			// 
			BirthOfYear.Location = new Point(49, 287);
			BirthOfYear.Name = "BirthOfYear";
			BirthOfYear.Size = new Size(234, 23);
			BirthOfYear.TabIndex = 7;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(342, 498);
			Controls.Add(BirthOfYear);
			Controls.Add(Validate);
			Controls.Add(LastName);
			Controls.Add(FirstName);
			Controls.Add(label2);
			Controls.Add(NationalityId);
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
		private TextBox NationalityId;
		private Label label2;
		private TextBox FirstName;
		private TextBox LastName;
		private Button button2;
		private Button Validate;
		private DateTimePicker BirthOfYear;
	}
}