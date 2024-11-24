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
    public partial class Form3 : Form
    {
        Random MetKaul21 = new Random(); // Metamais kauliņš
        Random MetKaul22 = new Random(); // Metamais kauliņš
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int randomPL21 = MetKaul21.Next(1, 7);       //Metamais kauliņš no 1-6

            switch (randomPL21)
            {
                case 1:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";//ja uzmet 1
                    break;
                case 2:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";//ja uzmet 2
                    break;
                case 3:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";//ja uzmet 3
                    break;
                case 4:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";//ja uzmet 4
                    break;
                case 5:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";//ja uzmet 5
                    break;
                case 6:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 6 50x50.png";//ja uzmet 6
                    break;
                default: break;
            }
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int randomPL22 = MetKaul22.Next(1, 7);       //Metamais kauliņš no 1-6

            switch (randomPL22)
            {
                case 1:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";//ja uzmet 1
                    break;
                case 2:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";//ja uzmet 2
                    break;
                case 3:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";//ja uzmet 3
                    break;
                case 4:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";//ja uzmet 4
                    break;
                case 5:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";//ja uzmet 5
                    break;
                case 6:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 6 50x50.png";//ja uzmet 6
                    break;
                default: break;
            }
            button2.Enabled = false;
            button1.Enabled = true;

        }
    }
}
