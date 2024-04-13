namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<string> list = SFun.WordSEndings(richTextBox1.Text);
            foreach (string s in list)
            {
                listView1.Items.Add(s);
            }
           
        }
    }
}
