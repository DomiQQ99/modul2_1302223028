﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302223028
{
    

    public partial class Form1 : Form
    {
        int nilai1;
        int nilai2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nilai1 = Int32.Parse(label1.Text);
            label1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text +  "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nilai2 = Int32.Parse(label1.Text);
            int hasil = nilai1 + nilai2;
            label1.Text = hasil.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "8";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
