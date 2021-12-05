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
            Ki�iler.Items.Add(txtAd.Text + " " + txtSoyad.Text);
            txtAd.Clear();
            txtSoyad.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secim = Ki�iler.SelectedIndex;
            if (secim != -1)
            {
                Ki�iler.Items.RemoveAt(secim);
            }
            else
            {
                MessageBox.Show("Se�im Yap�n!");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Ki�iler.Items.Clear();
        }
    }
}