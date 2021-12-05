namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbSiyah.Checked == true)
            {
                MessageBox.Show("Siyah seçildi.");
                this.BackColor = Color.Black;
            }
            else if (rbGri.Checked == true)
            {
                MessageBox.Show("Gri seçildi.");
                this.BackColor = Color.Gray;
            }
            else if (rbBeyaz.Checked == true)
            {
                MessageBox.Show("Beyaz seçildi");
                this.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Seçim yapýlmadý.");
            }
        }
    }
}