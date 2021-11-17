using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string veriyigonder;

        public static bool radiogonderKolay;
        public static bool radiogonderOrta;
        public static bool radiogonderZor;



        private void buttonBasla_Click(object sender, EventArgs e)
        {

            if (textboxAdi.Text == "")
            {
                MessageBox.Show("Ad alanı boş geçilemez.");
            }
            else if (textboxSoyadi.Text == "")
            {
                MessageBox.Show("Soyad alanı boş geçilemez.");
            }
            else
            {
                veriyigonder = textboxAdi.Text +" "+ textboxSoyadi.Text;

                Form2 f2 = new Form2(this);
                f2.Owner = this;
                f2.Show();

            }

        }

        private void radioKolay_CheckedChanged(object sender, EventArgs e)
        {
            radiogonderKolay = radioKolay.Checked;

        }

        private void radioOrta_CheckedChanged(object sender, EventArgs e)
        {
            radiogonderOrta = radioOrta.Checked;
        }

        private void radioZor_CheckedChanged(object sender, EventArgs e)
        {
            radiogonderZor = radioZor.Checked;

        }
    }
}
