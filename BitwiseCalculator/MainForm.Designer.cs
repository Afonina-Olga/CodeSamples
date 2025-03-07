namespace BitwiseCalculator
{
	partial class MainForm
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
			numValue1 = new NumericUpDown();
			label1 = new Label();
			numValue2 = new NumericUpDown();
			label2 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			txtResult = new RichTextBox();
			txtValue1 = new TextBox();
			txtValue2 = new TextBox();
			((System.ComponentModel.ISupportInitialize)numValue1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numValue2).BeginInit();
			SuspendLayout();
			// 
			// numValue1
			// 
			numValue1.Location = new Point(82, 14);
			numValue1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
			numValue1.Name = "numValue1";
			numValue1.Size = new Size(150, 27);
			numValue1.TabIndex = 0;
			numValue1.ValueChanged += NumValue1_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 16);
			label1.Name = "label1";
			label1.Size = new Size(64, 20);
			label1.TabIndex = 1;
			label1.Text = "Число 1";
			// 
			// numValue2
			// 
			numValue2.Location = new Point(82, 87);
			numValue2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numValue2.Name = "numValue2";
			numValue2.Size = new Size(150, 27);
			numValue2.TabIndex = 0;
			numValue2.ValueChanged += NumValue2_ValueChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 89);
			label2.Name = "label2";
			label2.Size = new Size(64, 20);
			label2.TabIndex = 1;
			label2.Text = "Число 2";
			// 
			// button1
			// 
			button1.Location = new Point(12, 151);
			button1.Name = "button1";
			button1.Size = new Size(65, 65);
			button1.TabIndex = 2;
			button1.Text = "&&";
			button1.UseVisualStyleBackColor = true;
			button1.Click += Button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(90, 151);
			button2.Name = "button2";
			button2.Size = new Size(65, 65);
			button2.TabIndex = 2;
			button2.Text = "|";
			button2.UseVisualStyleBackColor = true;
			button2.Click += Button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(168, 151);
			button3.Name = "button3";
			button3.Size = new Size(65, 65);
			button3.TabIndex = 2;
			button3.Text = "^";
			button3.UseVisualStyleBackColor = true;
			button3.Click += Button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(12, 228);
			button4.Name = "button4";
			button4.Size = new Size(65, 65);
			button4.TabIndex = 2;
			button4.Text = "~";
			button4.UseVisualStyleBackColor = true;
			button4.Click += Button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(90, 228);
			button5.Name = "button5";
			button5.Size = new Size(65, 65);
			button5.TabIndex = 2;
			button5.Text = "<<";
			button5.UseVisualStyleBackColor = true;
			button5.Click += Button5_Click;
			// 
			// button6
			// 
			button6.Location = new Point(168, 228);
			button6.Name = "button6";
			button6.Size = new Size(65, 65);
			button6.TabIndex = 2;
			button6.Text = ">>";
			button6.UseVisualStyleBackColor = true;
			button6.Click += Button6_Click;
			// 
			// txtResult
			// 
			txtResult.Location = new Point(239, 14);
			txtResult.Name = "txtResult";
			txtResult.Size = new Size(476, 279);
			txtResult.TabIndex = 3;
			txtResult.Text = "";
			// 
			// txtValue1
			// 
			txtValue1.BorderStyle = BorderStyle.None;
			txtValue1.Location = new Point(12, 47);
			txtValue1.Name = "txtValue1";
			txtValue1.ReadOnly = true;
			txtValue1.RightToLeft = RightToLeft.Yes;
			txtValue1.Size = new Size(221, 20);
			txtValue1.TabIndex = 5;
			// 
			// txtValue2
			// 
			txtValue2.BorderStyle = BorderStyle.None;
			txtValue2.Location = new Point(12, 120);
			txtValue2.Name = "txtValue2";
			txtValue2.ReadOnly = true;
			txtValue2.RightToLeft = RightToLeft.Yes;
			txtValue2.Size = new Size(221, 20);
			txtValue2.TabIndex = 5;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(727, 310);
			Controls.Add(txtValue2);
			Controls.Add(txtValue1);
			Controls.Add(txtResult);
			Controls.Add(button6);
			Controls.Add(button5);
			Controls.Add(button3);
			Controls.Add(button4);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(numValue2);
			Controls.Add(numValue1);
			Name = "MainForm";
			Text = "Калькулятор поразрядных операций";
			((System.ComponentModel.ISupportInitialize)numValue1).EndInit();
			((System.ComponentModel.ISupportInitialize)numValue2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown numValue1;
		private Label label1;
		private NumericUpDown numValue2;
		private Label label2;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private RichTextBox txtResult;
		private TextBox txtValue1;
		private TextBox txtValue2;
	}
}
