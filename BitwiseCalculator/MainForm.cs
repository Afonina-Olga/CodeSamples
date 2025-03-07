namespace BitwiseCalculator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} & {numValue2.Value} = {(int)numValue1.Value & (int)numValue2.Value}\n";
			var result = Convert.ToString((int)numValue1.Value & (int)numValue2.Value, 2);
			txtResult.Text += $"{Convert.ToString((int)numValue1.Value, 2)} & {Convert.ToString((int)numValue2.Value, 2)} = {result}\n";
			txtResult.Text += $"{result}(2) = {Convert.ToInt32(result, 2)}(10)\n";
			txtResult.Text += "\n";
		}

		private void NumValue1_ValueChanged(Object sender, EventArgs e)
		{
			txtValue1.Text = Convert.ToString((int)numValue1.Value, 2);
		}

		private void NumValue2_ValueChanged(Object sender, EventArgs e)
		{
			txtValue2.Text = Convert.ToString((int)numValue2.Value, 2);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} | {numValue2.Value} = {(int)numValue1.Value | (int)numValue2.Value}\n";
			var result = Convert.ToString((int)numValue1.Value | (int)numValue2.Value, 2);
			txtResult.Text += $"{Convert.ToString((int)numValue1.Value, 2)} | {Convert.ToString((int)numValue2.Value, 2)} = {result}\n";
			txtResult.Text += $"{result}(2) = {Convert.ToInt32(result, 2)}(10)\n";
			txtResult.Text += "\n";
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} ^ {numValue2.Value} = {(int)numValue1.Value ^ (int)numValue2.Value}\n";
			var result = Convert.ToString((int)numValue1.Value ^ (int)numValue2.Value, 2);
			txtResult.Text += $"{Convert.ToString((int)numValue1.Value, 2)} ^ {Convert.ToString((int)numValue2.Value, 2)} = {result}\n";
			txtResult.Text += $"{result}(2) = {Convert.ToInt32(result, 2)}(10)\n";
			txtResult.Text += "\n";
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"~{numValue1.Value} = {~(int)numValue1.Value}\n";
			var result = Convert.ToString(~(int)numValue1.Value, 2);
			txtResult.Text += $"~{Convert.ToString((int)numValue1.Value, 2)} = {result}\n";
			txtResult.Text += $"{result}(2) = {Convert.ToInt32(result, 2)}(10)\n";
			txtResult.Text += "\n";
		}

		private void Button5_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} << {numValue2.Value} = {(int)numValue1.Value << (int)numValue2.Value}\n";
			var result = Convert.ToString((int)numValue1.Value << (int)numValue2.Value, 2);
			txtResult.Text += $"{Convert.ToString((int)numValue1.Value, 2)} << {numValue2.Value} = {result}\n";
			txtResult.Text += $"{result}(2) = {Convert.ToInt32(result, 2)}(10)\n";
			txtResult.Text += "\n";
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			txtResult.Text += $"{numValue1.Value} >> {numValue2.Value} = {(int)numValue1.Value >> (int)numValue2.Value}\n";
			var result = Convert.ToString((int)numValue1.Value >> (int)numValue2.Value, 2);
			txtResult.Text += $"{Convert.ToString((int)numValue1.Value, 2)} >> {numValue2.Value} = {result}\n";
			txtResult.Text += $"{result}(2) = {Convert.ToInt32(result, 2)}(10)\n";
			txtResult.Text += "\n";
		}
	}
}
