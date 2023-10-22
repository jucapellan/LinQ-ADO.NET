namespace LinQ_ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] numbers = "10, 9, 5, 0, 3, 20, 1, 4, 8, 5, 18, 22, 25".Split(',').ToArray();
            textBox1.Text = string.Join(Environment.NewLine, numbers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = textBox1.Text.Split(',').Select(int.Parse).ToArray();

            // LINQ query to order and filter the numbers
            var orderedNumbers = numbers.OrderBy(n => n);
            var numbersGreaterThan15 = numbers.Where(n => n > 15);

            // Convert the results to strings
            string orderedNumbersText = string.Join(Environment.NewLine, orderedNumbers);
            MessageBox.Show(orderedNumbersText);
            string numbersGreaterThan15Text = string.Join(Environment.NewLine, numbersGreaterThan15);

            // TextBox controls named textBox1 and textBox2
            textBox1.Text = orderedNumbersText;
            textBox2.Text = numbersGreaterThan15Text;
        }
    }
}