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
       // Random MetKaul21 = new Random(); // Metamais kauliņš
        //Random MetKaul22 = new Random(); // Metamais kauliņš
        public Form3()
        {
            InitializeComponent();
            MSPL21 = 0;
            MSPL22 = 0;
            TAPL21 = 0;
            TAPL22 = 0;
        }
        public static int MSPL21 = 0; // Metienu skaits, divi spēlētāji, pirmais spēlētājs.
        public static int TAPL21 = 0; // Torņa augstums, divi spēlētāji, pirmais spēlētājs.
        public static int MSPL22 = 0; // Metienu skaits, divi spēlētāji, otrais spēlētājs.
        public static int TAPL22 = 0; // Torņa augstums, divi spēlētāji, otrais spēlētājs.
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
            Ka2.Image = null;
            Ka3.Image = null;
            Ka4.Image = null;
            Ka5.Image = null;
            Ka6.Image = null;
            Ka2.BackColor = Color.Transparent;
            Ka3.BackColor = Color.Transparent;
            Ka4.BackColor = Color.Transparent;
            Ka5.BackColor = Color.Transparent;
            Ka6.BackColor = Color.Transparent;
            Ka22.Image = null;
            Ka23.Image = null;
            Ka24.Image = null;
            Ka25.Image = null;
            Ka26.Image = null;
            Ka22.BackColor = Color.Transparent;
            Ka23.BackColor = Color.Transparent;
            Ka24.BackColor = Color.Transparent;
            Ka25.BackColor = Color.Transparent;
            Ka26.BackColor = Color.Transparent;
            Random MetKaul21 = new Random(); // Metamais kauliņš
            int randomPL21 = MetKaul21.Next(1, 7);       //Metamais kauliņš no 1-6
            MSPL21++;
            switch (randomPL21)
            {
                case 1:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";//ja uzmet 1
                    Ka1.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka1.BackColor = Color.CornflowerBlue;
                    TAPL21++;
                    break;
                case 2:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";//ja uzmet 2
                    Ka1.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka2.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka1.BackColor = Color.CornflowerBlue;
                    Ka2.BackColor = Color.CornflowerBlue;
                    TAPL21 += 2;
                    break;
                case 3:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";//ja uzmet 3
                    Ka1.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka2.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka3.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";
                    Ka1.BackColor = Color.CornflowerBlue;
                    Ka2.BackColor = Color.CornflowerBlue;
                    Ka3.BackColor = Color.CornflowerBlue;
                    TAPL21 += 3;
                    break;
                case 4:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";//ja uzmet 4
                    Ka1.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka2.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka3.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";
                    Ka4.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";
                    Ka1.BackColor = Color.CornflowerBlue;
                    Ka2.BackColor = Color.CornflowerBlue;
                    Ka3.BackColor = Color.CornflowerBlue;
                    Ka4.BackColor = Color.CornflowerBlue;
                    TAPL21 += 4;
                    break;
                case 5:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";//ja uzmet 5
                    Ka1.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka2.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka3.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";
                    Ka4.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";
                    Ka5.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";
                    Ka1.BackColor = Color.CornflowerBlue;
                    Ka2.BackColor = Color.CornflowerBlue;
                    Ka3.BackColor = Color.CornflowerBlue;
                    Ka4.BackColor = Color.CornflowerBlue;
                    Ka5.BackColor = Color.CornflowerBlue;
                    TAPL21 += 5;
                    break;
                case 6:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 6 50x50.png";//ja uzmet 6
                    Ka1.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka2.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka3.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";
                    Ka4.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";
                    Ka5.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";
                    Ka6.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 6 50x50.png";
                    Ka1.BackColor = Color.CornflowerBlue;
                    Ka2.BackColor = Color.CornflowerBlue;
                    Ka3.BackColor = Color.CornflowerBlue;
                    Ka4.BackColor = Color.CornflowerBlue;
                    Ka5.BackColor = Color.CornflowerBlue;
                    Ka6.BackColor = Color.CornflowerBlue;
                    TAPL21 += 6;
                    break;
                default: break;
            }
            MetSkPL1.Text = "Metienu skaits = " + MSPL21;
            ToAugPL1.Text = "Torņa augstums = " + TAPL21;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Random MetKaul22 = new Random(); // Metamais kauliņš
            int randomPL22 = MetKaul22.Next(1, 7);       //Metamais kauliņš no 1-6
            MSPL22 ++;
            switch (randomPL22)
            {
                case 1:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";//ja uzmet 1
                    Ka21.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka21.BackColor = Color.CornflowerBlue;
                    TAPL22++;
                    break;
                case 2:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";//ja uzmet 2
                    Ka21.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka22.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka21.BackColor = Color.CornflowerBlue;
                    Ka22.BackColor = Color.CornflowerBlue;
                    TAPL22 += 2;
                    break;
                case 3:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";//ja uzmet 3
                    Ka21.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka22.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka23.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";
                    Ka21.BackColor = Color.CornflowerBlue;
                    Ka22.BackColor = Color.CornflowerBlue;
                    Ka23.BackColor = Color.CornflowerBlue;
                    TAPL22 += 3;
                    break;
                case 4:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";//ja uzmet 4
                    Ka21.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka22.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka23.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";
                    Ka24.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";
                    Ka21.BackColor = Color.CornflowerBlue;
                    Ka22.BackColor = Color.CornflowerBlue;
                    Ka23.BackColor = Color.CornflowerBlue;
                    Ka24.BackColor = Color.CornflowerBlue;
                    TAPL22 += 4;
                    break;
                case 5:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";//ja uzmet 5
                    Ka21.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka22.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka23.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";
                    Ka24.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";
                    Ka25.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";
                    Ka21.BackColor = Color.CornflowerBlue;
                    Ka22.BackColor = Color.CornflowerBlue;
                    Ka23.BackColor = Color.CornflowerBlue;
                    Ka24.BackColor = Color.CornflowerBlue;
                    Ka25.BackColor = Color.CornflowerBlue;
                    TAPL22 += 5;
                    break;
                case 6:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 6 50x50.png";//ja uzmet 6
                    Ka21.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";
                    Ka22.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";
                    Ka23.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";
                    Ka24.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";
                    Ka25.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";
                    Ka26.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 6 50x50.png";
                    Ka21.BackColor = Color.CornflowerBlue;
                    Ka22.BackColor = Color.CornflowerBlue;
                    Ka23.BackColor = Color.CornflowerBlue;
                    Ka24.BackColor = Color.CornflowerBlue;
                    Ka25.BackColor = Color.CornflowerBlue;
                    Ka26.BackColor = Color.CornflowerBlue;
                    TAPL22 += 6;
                    break;
                default: break;
            }
            MetSkPL2.Text = "Metienu skaits = " + MSPL22;
            ToAugPL2.Text = "Torņa augstums = " + TAPL22;
            if (MSPL22 == 10)
            {
                button2.Enabled = false;
                await Task.Delay(5000);
                this.Hide();
                Form4 duoRez = new Form4();
                duoRez.Show();
            }
            button2.Enabled = false;
            button1.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
