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
    public partial class Form2 : Form
    {
        Form1 frm;
        public Form2(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        int dakika = 0, saniye = 0;
        Random rnd = new Random();
        int toplam;

        private void Form2_Load(object sender, EventArgs e)
        {
            lblVeriCek.Text = Form1.veriyigonder ;
            if(Form1.radiogonderKolay == true)
            {
                this.Size = new Size(300, 300);
                timer2.Interval = 1200;
                saniye = 60;
                dakika = 00;
            }
            else if (Form1.radiogonderOrta == true)
            {
                this.Size = new Size(500, 500);
                timer2.Interval = 600;
                saniye = 40;
                dakika = 00;
            }
            else if(Form1.radiogonderZor == true)
            {
                this.Size = new Size(700, 700);
                timer2.Interval = 200;
                saniye = 20;
                dakika = 00;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Form1.radiogonderKolay == true)
            {
                Button btn = new Button();
                btn.Size = new Size(rnd.Next(20, 100), 50);
                btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlSkor.Width - btn.Width),
                     rnd.Next(this.ClientSize.Height - btn.Height));
                btn.Text = rnd.Next(10, 100).ToString();
                btn.Click += btn_Click;
                this.Controls.Add(btn);
            }
            else if (Form1.radiogonderOrta == true)
            {
                Button btn = new Button();
                btn.Size = new Size(rnd.Next(20, 100), 50);
                btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlSkor.Width - btn.Width),
                     rnd.Next(this.ClientSize.Height - btn.Height));

                btn.Text = rnd.Next(10, 100).ToString();
                btn.Click += btn_Click;
                this.Controls.Add(btn);
            }
            else if(Form1.radiogonderZor == true)
            {
                Button btn = new Button();
                btn.Size = new Size(rnd.Next(20, 100), 50);
                btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlSkor.Width - btn.Width),
                     rnd.Next(this.ClientSize.Height - btn.Height));

                btn.Text = rnd.Next(10, 100).ToString();
                btn.Click += btn_Click;
                this.Controls.Add(btn);
            }

        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            btn.Visible = false;
            lblSkor.Text = ("SKORUNUZ: " + " " + Convert.ToString(toplam) + "" + ".");

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye == 00 && dakika !=00)
            {
                dakika = dakika-1;
                saniye = 60;
            }
            else if (saniye==00 && dakika==00)
                {
                timer1.Stop();
                timer2.Stop();
                this.BackColor = Color.Red;
                MessageBox.Show("Süreniz bitti" +" " +lblSkor.Text);

                string yazdir = "Skorunuz : " ;
                System.IO.File.WriteAllText(@"c:\ödevler\ntp\ödev2\dosya.txt", yazdir);
            }
            lblSayac.Text = String.Format("{0:D2}", dakika) + ":" + String.Format("{0:D2}", saniye);
            saniye--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            this.BackColor = Color.Green;
            timer1.Enabled = true;
            timer1.Interval = 1000;

        }
    }
    }
    

