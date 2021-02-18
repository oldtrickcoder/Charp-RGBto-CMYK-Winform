using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Csharp_rgb_Color
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            label15.Visible = false;
            label14.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            label4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {




            int x, y, z;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);

            if (x > 255 || y > 255 || z > 255)
            {
                MessageBox.Show("angka yang anda masukan melebihi kapasitas warna rgb, mohon di perhatikan : maksimum nilai adalah 255", "NOTED !!");
            }
            else
            {
                pictureBox1.BackColor = Color.FromArgb(x, y, z);
         
            }
           

            
            











        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int x, y, z;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);

            double rd = x / 255.000;
            double grn = y / 255.000;
            double bleu = z / 255.000;
        
            double maxwarna;
            if (rd > grn)
            {
               

                if (rd > bleu)
                {
                    maxwarna = rd;
                }
                else
                {
                    maxwarna = bleu;
                }


            }else if (grn > bleu)
            {
                maxwarna = grn;
            }
            else
            {
                maxwarna = bleu;
            }

            double cyan, magenta, yellow, k,k_publish;
            k = (1-maxwarna) ;
            cyan = ((1-rd-k)/ (1-k))*100;
            magenta = ((1 - grn - k) / (1 - k))*100;
            yellow = ((1 - bleu - k) / (1 - k))*100;
            k_publish = k * 100;

            
            Console.WriteLine(String.Format("{0:0.#}", cyan));
            Console.WriteLine(String.Format("{0:0.#}", magenta));
            Console.WriteLine(String.Format("{0:0.#}", yellow));
            Console.WriteLine(String.Format("{0:0.#}", k_publish));
            label7.Text = String.Format("{0:0}", k_publish);
            label6.Text = String.Format("{0:0}", yellow);
            label5.Text = String.Format("{0:0}", magenta);
            label4.Text = String.Format("{0:0}", cyan);

            label15.Visible = true;
            label14.Visible = true;
            label13.Visible = true;
            label12.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label4.Visible = true;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = trackBar3.Value.ToString();
        }
    }
}
