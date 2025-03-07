namespace LogicalCalculator
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
			label1 = new Label();
			numValue1 = new NumericUpDown();
			label2 = new Label();
			numValue2 = new NumericUpDown();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			txtResult = new RichTextBox();
			cbFirst = new ComboBox();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			btnExecute = new Button();
			cbSecond = new ComboBox();
			cbOperation = new ComboBox();
			((System.ComponentModel.ISupportInitialize)numValue1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numValue2).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(23, 33);
			label1.Name = "label1";
			label1.Size = new Size(64, 20);
			label1.TabIndex = 0;
			label1.Text = "Число 1";
			// 
			// numValue1
			// 
			numValue1.Location = new Point(103, 31);
			numValue1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numValue1.Name = "numValue1";
			numValue1.Size = new Size(150, 27);
			numValue1.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(23, 66);
			label2.Name = "label2";
			label2.Size = new Size(64, 20);
			label2.TabIndex = 0;
			label2.Text = "Число 2";
			// 
			// numValue2
			// 
			numValue2.Location = new Point(103, 64);
			numValue2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numValue2.Name = "numValue2";
			numValue2.Size = new Size(150, 27);
			numValue2.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(46, 97);
			button1.Name = "button1";
			button1.Size = new Size(65, 65);
			button1.TabIndex = 2;
			button1.Text = ">";
			button1.UseVisualStyleBackColor = true;
			button1.Click += Button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(117, 97);
			button2.Name = "button2";
			button2.Size = new Size(65, 65);
			button2.TabIndex = 2;
			button2.Text = "<";
			button2.UseVisualStyleBackColor = true;
			button2.Click += Button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(188, 97);
			button3.Name = "button3";
			button3.Size = new Size(65, 65);
			button3.TabIndex = 2;
			button3.Text = ">=";
			button3.UseVisualStyleBackColor = true;
			button3.Click += Button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(46, 168);
			button4.Name = "button4";
			button4.Size = new Size(65, 65);
			button4.TabIndex = 2;
			button4.Text = "<=";
			button4.UseVisualStyleBackColor = true;
			button4.Click += Button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(117, 168);
			button5.Name = "button5";
			button5.Size = new Size(65, 65);
			button5.TabIndex = 2;
			button5.Text = "==";
			button5.UseVisualStyleBackColor = true;
			button5.Click += Button5_Click;
			// 
			// button6
			// 
			button6.Location = new Point(188, 168);
			button6.Name = "button6";
			button6.Size = new Size(65, 65);
			button6.TabIndex = 2;
			button6.Text = "!=";
			button6.UseVisualStyleBackColor = true;
			button6.Click += Button6_Click;
			// 
			// txtResult
			// 
			txtResult.Location = new Point(310, 22);
			txtResult.Name = "txtResult";
			txtResult.Size = new Size(330, 408);
			txtResult.TabIndex = 3;
			txtResult.Text = "";
			// 
			// cbFirst
			// 
			cbFirst.FormattingEnabled = true;
			cbFirst.Items.AddRange(new object[] { "True", "False" });
			cbFirst.Location = new Point(20, 31);
			cbFirst.Name = "cbFirst";
			cbFirst.Size = new Size(241, 28);
			cbFirst.TabIndex = 4;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(numValue1);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(button6);
			groupBox1.Controls.Add(numValue2);
			groupBox1.Controls.Add(button5);
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(button3);
			groupBox1.Controls.Add(button2);
			groupBox1.Controls.Add(button4);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(282, 254);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Операции сравнения";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnExecute);
			groupBox2.Controls.Add(cbSecond);
			groupBox2.Controls.Add(cbOperation);
			groupBox2.Controls.Add(cbFirst);
			groupBox2.Location = new Point(15, 286);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(279, 180);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Логические операции";
			// 
			// btnExecute
			// 
			btnExecute.Location = new Point(154, 133);
			btnExecute.Name = "btnExecute";
			btnExecute.Size = new Size(107, 29);
			btnExecute.TabIndex = 5;
			btnExecute.Text = "Выполнить";
			btnExecute.UseVisualStyleBackColor = true;
			btnExecute.Click += BtnExecute_Click;
			// 
			// cbSecond
			// 
			cbSecond.FormattingEnabled = true;
			cbSecond.Items.AddRange(new object[] { "True", "False" });
			cbSecond.Location = new Point(20, 99);
			cbSecond.Name = "cbSecond";
			cbSecond.Size = new Size(241, 28);
			cbSecond.TabIndex = 4;
			// 
			// cbOperation
			// 
			cbOperation.FormattingEnabled = true;
			cbOperation.Items.AddRange(new object[] { "|", "&", "||", "&&", "^" });
			cbOperation.Location = new Point(20, 65);
			cbOperation.Name = "cbOperation";
			cbOperation.Size = new Size(241, 28);
			cbOperation.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(653, 482);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(txtResult);
			Name = "Form1";
			Text = "Логический калькулятор";
			((System.ComponentModel.ISupportInitialize)numValue1).EndInit();
			((System.ComponentModel.ISupportInitialize)numValue2).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private NumericUpDown numValue1;
		private Label label2;
		private NumericUpDown numValue2;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private RichTextBox txtResult;
		private ComboBox cbFirst;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private ComboBox cbSecond;
		private ComboBox cbOperation;
		private Button btnExecute;
	}
}
