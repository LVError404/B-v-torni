using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

        Rez.Text = "Rezultāts: " + Form2.TAPL1;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Rez_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form2 solo = new Form2();
            solo.Show();
       
    }
    }
}
