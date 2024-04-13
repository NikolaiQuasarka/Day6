namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (char.TryParse(textBox3.Text, out char ch))
                textBox2.Text = SFun.WordCount(textBox1.Text, ch).ToString();
        }
    }
}
