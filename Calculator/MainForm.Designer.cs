namespace Calculator
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
			txtResult = new RichTextBox();
			btnPlus = new Button();
			btnMinus = new Button();
			btnMultiply = new Button();
			btnDivision = new Button();
			btnMod = new Button();
			btnPostIncrement = new Button();
			btnPostDecrement = new Button();
			btnPreIncrement = new Button();
			btnPreDecrement = new Button();
			((System.ComponentModel.ISupportInitialize)numValue1).BeginInit();
			((System.ComponentModel.ISupportInitialize)numValue2).BeginInit();
			SuspendLayout();
			// 
			// numValue1
			// 
			numValue1.Location = new Point(88, 12);
			numValue1.Name = "numValue1";
			numValue1.Size = new Size(150, 27);
			numValue1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 14);
			label1.Name = "label1";
			label1.Size = new Size(64, 20);
			label1.TabIndex = 1;
			label1.Text = "Число 1";
			// 
			// numValue2
			// 
			numValue2.Location = new Point(88, 56);
			numValue2.Name = "numValue2";
			numValue2.Size = new Size(150, 27);
			numValue2.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 58);
			label2.Name = "label2";
			label2.Size = new Size(64, 20);
			label2.TabIndex = 1;
			label2.Text = "Число 2";
			// 
			// txtResult
			// 
			txtResult.Location = new Point(258, 12);
			txtResult.Name = "txtResult";
			txtResult.Size = new Size(145, 301);
			txtResult.TabIndex = 2;
			txtResult.Text = "";
			// 
			// btnPlus
			// 
			btnPlus.Location = new Point(18, 96);
			btnPlus.Name = "btnPlus";
			btnPlus.Size = new Size(65, 65);
			btnPlus.TabIndex = 3;
			btnPlus.Text = "+";
			btnPlus.UseVisualStyleBackColor = true;
			btnPlus.Click += BtnPlus_Click;
			// 
			// btnMinus
			// 
			btnMinus.Location = new Point(95, 96);
			btnMinus.Name = "btnMinus";
			btnMinus.Size = new Size(65, 65);
			btnMinus.TabIndex = 3;
			btnMinus.Text = "-";
			btnMinus.UseVisualStyleBackColor = true;
			btnMinus.Click += BtnMinus_Click;
			// 
			// btnMultiply
			// 
			btnMultiply.Location = new Point(172, 96);
			btnMultiply.Name = "btnMultiply";
			btnMultiply.Size = new Size(65, 65);
			btnMultiply.TabIndex = 3;
			btnMultiply.Text = "*";
			btnMultiply.UseVisualStyleBackColor = true;
			btnMultiply.Click += BtnMultiply_Click;
			// 
			// btnDivision
			// 
			btnDivision.Location = new Point(18, 172);
			btnDivision.Name = "btnDivision";
			btnDivision.Size = new Size(65, 65);
			btnDivision.TabIndex = 3;
			btnDivision.Text = "/";
			btnDivision.UseVisualStyleBackColor = true;
			btnDivision.Click += BtnDivision_Click;
			// 
			// btnMod
			// 
			btnMod.Location = new Point(95, 172);
			btnMod.Name = "btnMod";
			btnMod.Size = new Size(65, 65);
			btnMod.TabIndex = 3;
			btnMod.Text = "%";
			btnMod.UseVisualStyleBackColor = true;
			btnMod.Click += BtnMod_Click;
			// 
			// btnPostIncrement
			// 
			btnPostIncrement.Location = new Point(172, 172);
			btnPostIncrement.Name = "btnPostIncrement";
			btnPostIncrement.Size = new Size(65, 65);
			btnPostIncrement.TabIndex = 3;
			btnPostIncrement.Text = "x++";
			btnPostIncrement.UseVisualStyleBackColor = true;
			btnPostIncrement.Click += BtnPostIncrement_Click;
			// 
			// btnPostDecrement
			// 
			btnPostDecrement.Location = new Point(18, 248);
			btnPostDecrement.Name = "btnPostDecrement";
			btnPostDecrement.Size = new Size(65, 65);
			btnPostDecrement.TabIndex = 3;
			btnPostDecrement.Text = "x--";
			btnPostDecrement.UseVisualStyleBackColor = true;
			btnPostDecrement.Click += btnPostDecrement_Click;
			// 
			// btnPreIncrement
			// 
			btnPreIncrement.Location = new Point(95, 248);
			btnPreIncrement.Name = "btnPreIncrement";
			btnPreIncrement.Size = new Size(65, 65);
			btnPreIncrement.TabIndex = 3;
			btnPreIncrement.Text = "++x";
			btnPreIncrement.UseVisualStyleBackColor = true;
			btnPreIncrement.Click += this.BtnPreIncrement_Click;
			// 
			// btnPreDecrement
			// 
			btnPreDecrement.Location = new Point(173, 248);
			btnPreDecrement.Name = "btnPreDecrement";
			btnPreDecrement.Size = new Size(65, 65);
			btnPreDecrement.TabIndex = 3;
			btnPreDecrement.Text = "--x";
			btnPreDecrement.UseVisualStyleBackColor = true;
			btnPreDecrement.Click += this.BtnPreDecrement_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(417, 326);
			Controls.Add(btnPreDecrement);
			Controls.Add(btnPreIncrement);
			Controls.Add(btnPostDecrement);
			Controls.Add(btnPostIncrement);
			Controls.Add(btnMultiply);
			Controls.Add(btnMod);
			Controls.Add(btnDivision);
			Controls.Add(btnMinus);
			Controls.Add(btnPlus);
			Controls.Add(txtResult);
			Controls.Add(label2);
			Controls.Add(numValue2);
			Controls.Add(label1);
			Controls.Add(numValue1);
			Name = "MainForm";
			Text = "Калькулятор";
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
		private RichTextBox txtResult;
		private Button btnPlus;
		private Button btnMinus;
		private Button btnMultiply;
		private Button btnDivision;
		private Button btnMod;
		private Button btnPostIncrement;
		private Button btnPostDecrement;
		private Button btnPreIncrement;
		private Button btnPreDecrement;
	}
}
