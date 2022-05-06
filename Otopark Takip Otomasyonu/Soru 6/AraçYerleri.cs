using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_6
{
    public partial class AraçYerleri : Form
    {
        public void konumdegistirmedosya()
        {
            AraçYerleri f2 = new AraçYerleri();
            for (int i = 0; i < 21; i++)
            {
                if (a1.Text == Form1.yeniaracyerdegis[i])
                {
                    a1.Text =Form1. yeniplaka[i];
                    a1.BackColor = Color.Red;
                }

                else if (a2.Text == Form1.yeniaracyerdegis[i])
                {
                    a2.Text =Form1. yeniplaka[i];
                    a2.BackColor = Color.Red;

                }
                else if (a3.Text == Form1.yeniaracyerdegis[i])
                {
                    a3.Text =Form1. yeniplaka[i];
                    a3.BackColor = Color.Red;

                }
                else if (a4.Text == Form1.yeniaracyerdegis[i])
                {
                    a4.Text =Form1. yeniplaka[i];
                    a4.BackColor = Color.Red;

                }
                else if (a5.Text == Form1.yeniaracyerdegis[i])
                {
                    a5.Text =Form1. yeniplaka[i];
                    a5.BackColor = Color.Red;

                }

                else if (b1.Text == Form1.yeniaracyerdegis[i])
                {
                    b1.Text =Form1. yeniplaka[i];
                    b1.BackColor = Color.Red;

                }
                else if (b2.Text == Form1.yeniaracyerdegis[i])
                {
                    b2.Text =Form1. yeniplaka[i];
                    b2.BackColor = Color.Red;

                }
                else if (b3.Text == Form1.yeniaracyerdegis[i])
                {
                    b3.Text =Form1. yeniplaka[i];
                    b3.BackColor = Color.Red;

                }
                else if (b4.Text == Form1.yeniaracyerdegis[i])
                {
                    b4.Text =Form1. yeniplaka[i];
                    b4.BackColor = Color.Red;

                }
                else if (b5.Text == Form1.yeniaracyerdegis[i])
                {
                    b5.Text =Form1. yeniplaka[i];
                    b5.BackColor = Color.Red;

                }
                else if (c1.Text == Form1.yeniaracyerdegis[i])
                {
                    c1.Text =Form1. yeniplaka[i];
                    c1.BackColor = Color.Red;

                }
                else if (c2.Text == Form1.yeniaracyerdegis[i])
                {
                    c2.Text =Form1. yeniplaka[i];
                    c2.BackColor = Color.Red;

                }
                else if (c3.Text == Form1.yeniaracyerdegis[i])
                {
                    c3.Text =Form1. yeniplaka[i];
                    c3.BackColor = Color.Red;

                }
                else if (c4.Text == Form1.yeniaracyerdegis[i])
                {
                    c4.Text =Form1. yeniplaka[i];
                    c4.BackColor = Color.Red;

                }
                else if (c5.Text == Form1.yeniaracyerdegis[i])
                {
                    c5.Text =Form1. yeniplaka[i];
                    c5.BackColor = Color.Red;

                }
                else if (d1.Text == Form1.yeniaracyerdegis[i])
                {
                    d1.Text =Form1. yeniplaka[i];
                    d1.BackColor = Color.Red;

                }
                else if (d2.Text == Form1.yeniaracyerdegis[i])
                {
                    d2.Text =Form1. yeniplaka[i];
                    d2.BackColor = Color.Red;

                }
                else if (d3.Text == Form1.yeniaracyerdegis[i])
                {
                    d3.Text =Form1. yeniplaka[i];
                    d3.BackColor = Color.Red;

                }
                else if (d4.Text == Form1.yeniaracyerdegis[i])
                {
                    d4.Text =Form1. yeniplaka[i];
                    d4.BackColor = Color.Red;

                }
                else if (d5.Text == Form1.yeniaracyerdegis[i])
                {
                    d5.Text =Form1. yeniplaka[i];
                    d5.BackColor = Color.Red;

                }
            }
        }

        public AraçYerleri()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();//Formlar arası geçiş ile ana menüye dönülmesi için kullandım
            f3.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            AraçBilgileriForm F2 = new AraçBilgileriForm();// araç bilgilerinin girildiği forma gidilmesi için kullandım
            F2.ShowDialog();
        }

        private void AraçYerleri_Load(object sender, EventArgs e)
        {
            konumdegistirmedosya();

        }
    }
}
