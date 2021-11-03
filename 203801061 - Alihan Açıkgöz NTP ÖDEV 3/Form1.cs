﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Form frm = new Form();

        Random rnd = new Random();
        int toplam;

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Font = new Font("Segoe Script", 12, FontStyle.Bold);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Size = new Size(rnd.Next(20, 100), 50);
            btn.Location = new Point(rnd.Next(800),
                rnd.Next(400));

            frm.ClientSize = new Size(800, 400);


            btn.Text = rnd.Next(10, 100).ToString();
            btn.Click += btn_Click;
            this.Controls.Add(btn);
        }
        string yazdir;
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            btn.Visible = false;

            label1.Text = ("SKORUNUZ: " + " " + Convert.ToString(toplam) + "" + ".");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int saniye = 60;
        int dakika = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;

            saniye = saniye - 1;
            lblSaniye.Text = Convert.ToString(saniye);
            lblDakika.Text = Convert.ToString(dakika - 1);

            if (saniye == 0)
            {

                dakika = dakika - 1;
                lblDakika.Text = Convert.ToString(dakika);
                saniye = 60;
            }

            if (lblDakika.Text == "-1")
            {
                timer1.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                this.BackColor = Color.Red;

                yazdir = "Skorunuz : ";
                System.IO.File.WriteAllText(@"c:\ödevler\ntp\ödev2\dosya.txt", yazdir);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            dakika = Convert.ToInt32(textBox1.Text);
            this.BackColor = Color.Green;


        }

     
    }
}

