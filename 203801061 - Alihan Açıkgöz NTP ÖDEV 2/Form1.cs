﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int sayi = rastgele.Next(1, 100);
            btn.Text = sayi.ToString();

            btn.Visible = false;

            if (btn.Visible)
            {
                btn.Visible = false;
            }
            else
            {
                btn.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = (Int32.Parse(button1.Text) + Int32.Parse(button2.Text) + Int32.Parse(button3.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = (Int32.Parse(button1.Text) * Int32.Parse(button2.Text) * Int32.Parse(button3.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
