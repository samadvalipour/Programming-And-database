using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            label9.Visible = false;
        }
        int n = 7;
        Random rnd = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            n = rnd.Next(1, 9);
            string s = "..\\..\\images\\img" + n.ToString() + ".jpg";
            Console.WriteLine(s);
            pictureBox1.ImageLocation = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (n)
            {
                case 1:
                    MessageBox.Show("این مکان ارگ بم می‌باشد", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 2:
                    MessageBox.Show("این مکان چهل ستون می‌باشد", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 3:
                    MessageBox.Show("این مکان دروازه قران می‌باشد", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 4:
                    MessageBox.Show("ابن مکان گنبد سلطانیه می‌باشد", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 5:
                    MessageBox.Show("این مکان باغ ارم می‌باشد", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 6:
                    MessageBox.Show("این مکان غار علیصدر می‌باشد", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 7:
                    MessageBox.Show("این مکان مقبره فردوسی می‌باشد", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
                case 8:
                    MessageBox.Show("این مکان ایلگلی می‌باشد", "پاسخ صحیح", MessageBoxButtons.OKCancel);
                    break;
            }
        }
    }
}
