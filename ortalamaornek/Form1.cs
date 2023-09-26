using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalamaornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblSinav1_Click(object sender, EventArgs e)
        {

        }

        private void txtSınav1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float sinav1, sinav2, ortalama;
            sinav1 = Convert.ToSingle(txtSinav1.Text);
            sinav2 = Convert.ToSingle(txtSinav2.Text);
            ortalama=(sinav1+sinav2)/2;

            txtOrtalama.Text=ortalama.ToString();
        }
    }
}

        
        








        