using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ComboBoxResimSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void cmbResim_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secim = cmbResim.SelectedIndex;
            switch (secim)
            {
                case 0:
                   pbResim.Image = Image.FromFile("C:\\Users\\win10\\source\\repos\\Mouse\\ComboBoxResimSec\\Resimler\\Frida1.png");
                    break;
                case 1:
                    pbResim.Image = Image.FromFile("C:\\Users\\win10\\source\\repos\\Mouse\\ComboBoxResimSec\\Resimler\\Frida2.png");
                    break;
                case 2:
                    pbResim.Image = Image.FromFile("C:\\Users\\win10\\source\\repos\\Mouse\\ComboBoxResimSec\\Resimler\\Firda3.png");
                    break;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbResim.Items.Add("Frida 1");
            cmbResim.Items.Add("Frida 2");
            cmbResim.Items.Add("Frida 3");
        }
    }
}