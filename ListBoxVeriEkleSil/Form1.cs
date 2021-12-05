namespace ListBoxVeriEkleSil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kiþiler.Items.Add(txtAd.Text + " " + txtSoyad.Text);
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secim = Kiþiler.SelectedIndex;
            if (secim != -1)
            {
                Kiþiler.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Seçim Yapýn!");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Kiþiler.Items.Clear();
        }
    }
}