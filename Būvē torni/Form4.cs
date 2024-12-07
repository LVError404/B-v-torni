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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            RezPL1.Text = "Rezultāts: " + Form3.TAPL21;
            RezPL2.Text = "Rezultāts: " + Form3.TAPL22;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
