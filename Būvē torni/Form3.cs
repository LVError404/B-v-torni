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
            Random MetKaul21 = new Random(); // Metamais kauliņš
            int randomPL21 = MetKaul21.Next(1, 7);       //Metamais kauliņš no 1-6
            MSPL21++;
            switch (randomPL21)
            {
                case 1:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 1 50x50.png";//ja uzmet 1
                    TAPL21++;
                    break;
                case 2:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";//ja uzmet 2
                    TAPL21 += 2;
                    break;
                case 3:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";//ja uzmet 3
                    TAPL21 += 3;
                    break;
                case 4:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";//ja uzmet 4
                    TAPL21 += 4;
                    break;
                case 5:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";//ja uzmet 5
                    TAPL21 += 5;
                    break;
                case 6:
                    picPL21MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 6 50x50.png";//ja uzmet 6
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
                    TAPL22++;
                    break;
                case 2:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 2 50x50.png";//ja uzmet 2
                    TAPL22 += 2;
                    break;
                case 3:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 3 50x50.png";//ja uzmet 3
                    TAPL22 += 3;
                    break;
                case 4:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 4 50x50.png";//ja uzmet 4
                    TAPL22 += 4;
                    break;
                case 5:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 5 50x50.png";//ja uzmet 5
                    TAPL22 += 5;
                    break;
                case 6:
                    picPL22MetKaul.ImageLocation = @"C:\Users\Error404\Desktop\Dice\dice 6 50x50.png";//ja uzmet 6
                    TAPL22 += 6;
                    break;
                default: break;
            }
            MetSkPL2.Text = "Metienu skaits = " + MSPL22;
            ToAugPL2.Text = "Torņa augstums = " + TAPL22;
            if (MSPL22 == 10)
            {
                await Task.Delay(5000);
                this.Hide();
                Form4 duoRez = new Form4();
                duoRez.Show();
            }
            button2.Enabled = false;
            button1.Enabled = true;

        }
    }
}
