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
    public partial class Form2 : Form
    {
        Random MetKaul1 = new Random(); // Metamais kauliņš
        public Form2()
        {
            InitializeComponent();
        }
        public static int MSPL1 =0; // Metienu skaits, viens spēlētājs
        public static int TAPL1 =0; // Torņa augstums, viens spēlētājs
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int randomPL1 = MetKaul1.Next(1, 7);       //Metamais kauliņš no 1-6
            MSPL1++;

            switch (randomPL1)
            {
                case 1:
                    picPL1MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";//ja uzmet 1
                    TAPL1++;
                    break;
                case 2:
                    picPL1MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";//ja uzmet 2
                    TAPL1 +=2;
                    break;
                case 3:
                    picPL1MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";//ja uzmet 3
                    TAPL1 +=3;
                    break;
                case 4:
                    picPL1MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";//ja uzmet 4
                    TAPL1 +=4;
                    break;
                case 5:
                    picPL1MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";//ja uzmet 5
                    TAPL1 +=5;
                    break;
                case 6:
                    picPL1MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 6 50x50.png";//ja uzmet 6
                    TAPL1 +=6;
                    break;
                default: break;
            }
            MetSk.Text = "Metienu skaits = " + MSPL1;
            ToAug.Text = "Torņa augstums = " + TAPL1;
            if (MSPL1 == 10)
            {
                await Task.Delay(5000);
                this.Hide();
                Form5 soloRez = new Form5();
                soloRez.Show();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
