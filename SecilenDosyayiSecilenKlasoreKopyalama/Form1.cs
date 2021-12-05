using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecilenDosyayiSecilenKlasoreKopyalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kaynakDosya = "", kaynakDosyaIsmi = "", hedefKlasor = "";

        private void btnKaynak_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Kopyalanacak Dosyay� Se�iniz.";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                kaynakDosyaIsmi = openFileDialog1.SafeFileName.ToString();
                kaynakDosya = openFileDialog1.FileName.ToString();
                txtKaynak.Text = kaynakDosya;
            }
            else
            {
                MessageBox.Show("Dosya Se�mediniz.", "Uyar�!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnHedef_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                hedefKlasor = folderBrowserDialog1.SelectedPath.ToString();
                txtHedef.Text = hedefKlasor;
            }
            else
            {
                MessageBox.Show("Dosyan�n Kopyalanaca�� Klas�r� Se�mediniz.", "Uyar�!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKaynak.Enabled = false;
            txtHedef.Enabled = false;
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (hedefKlasor != "" && kaynakDosya != "")
            {
                if (File.Exists(hedefKlasor + "\\" + kaynakDosyaIsmi))
                {
                    MessageBox.Show("Belirtilen klas�rde " + kaynakDosyaIsmi + " isimli dosya zaten mevcut.", "Uyar�!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    File.Copy(kaynakDosya, hedefKlasor + "\\" + kaynakDosyaIsmi);
                    MessageBox.Show("Dosya Kopyalama ��lemi Ba�ar�l�", "Dosya Kopyaland�.");
                }
            }
        }
    }
}