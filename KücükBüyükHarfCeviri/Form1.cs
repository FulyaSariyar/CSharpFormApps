namespace KücükBüyükHarfCeviri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            listBox1.Items.Add(metin.ToUpper());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = textBox2.Text;
            listBox2.Items.Add(metin.ToLower());
        }
    }
}