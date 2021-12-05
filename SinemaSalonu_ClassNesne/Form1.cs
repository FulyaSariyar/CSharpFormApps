namespace SinemaSalonu_ClassNesne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema salon;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label3.Text = "Salon Olu�turuldu. Koltuk say�s� : " + salon.BosKoltukOgren();
            }
            catch
            {
                label3.Text = "Salon Olu�turulamad�. Bilgileri kontrol edin.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salon.BiletSat(checkBox1.Checked);
            label3.Text = "Bilet sat�ld�. Kalan koltuk say�s� : " + salon.BosKoltukOgren();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salon.BiletIptal(checkBox1.Checked);
            label3.Text = "Bilet iptal edildi. Kalan koltuk say�s� : " + salon.BosKoltukOgren();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "�u anki bakiye " + salon.BakiyeOgren() + " TL";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Bo� koltuk say�s� " + salon.BosKoltukOgren();
        }
    }
}