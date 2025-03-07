namespace Calculator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void BtnPlus_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} + {numValue2.Value} = {numValue1.Value + numValue2.Value}\n";
		}

		private void BtnMinus_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} - {numValue2.Value} = {numValue1.Value - numValue2.Value}\n";
		}

		private void BtnMultiply_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} * {numValue2.Value} = {numValue1.Value * numValue2.Value}\n";
		}

		private void BtnDivision_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} / {numValue2.Value} = {numValue1.Value / numValue2.Value}\n";
		}

		private void BtnMod_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} % {numValue2.Value} = {numValue1.Value % numValue2.Value}\n";
		}

		private void btnPostDecrement_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value}-- = {numValue1.Value--}\n";
		}

		private void BtnPostIncrement_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value}++ = {numValue1.Value++}\n";
		}

		private void BtnPreIncrement_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"++{numValue1.Value} = {++numValue1.Value}\n";
		}

		private void BtnPreDecrement_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"--{numValue1.Value} = {--numValue1.Value}\n";
		}
	}
}
