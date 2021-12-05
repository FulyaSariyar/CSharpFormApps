namespace ListBoxlarArasiVeriTasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("C#");
            listBox1.Items.Add("C++");
            listBox1.Items.Add("Java");
            listBox1.Items.Add("Phyton");
            listBox1.Items.Add("JavaScript");
            listBox1.Items.Add("JQuery");
            listBox1.Items.Add("PHP");
            listBox1.Items.Add("C");
            listBox1.Items.Add("Pascal");
            listBox1.Items.Add("HTML");
            listBox1.Items.Add("CSS");
            listBox1.Items.Add("Kotlin");
            listBox1.Items.Add("Angular");
            listBox1.Items.Add("React");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Eleman seçilmeden aktarmak istenirse hata veriyor.
            //Bu hatayý engelleyelim.
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem); // Seçili olaný aktar
                listBox1.Items.Remove(listBox1.SelectedItem); //Seçili olaný sil
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapýn.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem); // Seçili olaný aktar
                listBox2.Items.Remove(listBox2.SelectedItem); //Seçili olaný sil
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapýn.");
            }
        }
    }
}