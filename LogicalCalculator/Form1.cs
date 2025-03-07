namespace LogicalCalculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			cbFirst.SelectedIndex = 0;
			cbSecond.SelectedIndex = 0;
			cbOperation.SelectedIndex = 0;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} > {numValue2.Value} = {numValue1.Value > numValue2.Value}\n\n";
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} < {numValue2.Value} => {numValue1.Value < numValue2.Value}\n\n";
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} >= {numValue2.Value} => {numValue1.Value >= numValue2.Value}\n\n";
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} <= {numValue2.Value} => {numValue1.Value <= numValue2.Value}\n\n";
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} == {numValue2.Value} => {numValue1.Value == numValue2.Value}\n\n";
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} != {numValue2.Value} => {numValue1.Value != numValue2.Value}\n\n";
		}

		private void BtnExecute_Click(object sender, EventArgs e)
		{
			var value1 = ToBoolean(cbFirst.SelectedItem!.ToString()!);
			var value2 = ToBoolean(cbSecond.SelectedItem!.ToString()!);
			var result = cbOperation.SelectedItem switch
			{
				"|" => value1 | value2,
				"&" => value1 & value2,
				"&&" => value1 && value2,
				"||" => value1 || value2,
				"^" => value1 ^ value2,
				_ => throw new NotImplementedException(),
			};

			txtResult.Text += $"{cbFirst.SelectedItem} {cbOperation.SelectedItem} {cbSecond.SelectedItem} = {result}\n\n";
		}

		private static bool ToBoolean(string value) => value == "True";
	}
}
