﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Būvē_torni
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PL1_Click(object sender, EventArgs e)
        {
              this.Hide();
            Form2 solo = new Form2();
            solo.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 duo = new Form3();
            duo.Show();
        }
    }
}
