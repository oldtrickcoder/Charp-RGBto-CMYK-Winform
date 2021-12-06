using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_rgb_Color
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 xyz=new Form1();
            xyz.ShowDialog();



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
            textBox3.Text=trackBar3.Value.ToString();

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            textBox4.Text=trackBar4.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
            {
                MessageBox.Show("Mohon isi angkanya terlebih dahulu", "NOTED !!");
                return;
            }

            Double c, y, m, k;
            c = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            m = Convert.ToDouble(textBox3.Text);
            k = Convert.ToDouble(textBox4.Text);
            if (c > 100 || m > 100 || y > 100 || k>100)
            {
                MessageBox.Show("angka yang anda masukan melebihi kapasitas warna CMYK, mohon di perhatikan : maksimum nilai adalah 100(Dalam satuan persen)", "NOTED !!");
            }
            else
            {
                double p_red, p_green, p_blue,p_k;
                p_red = c / 100;
                p_green = m / 100;
                p_blue = y / 100;
                p_k=k / 100;

                double red, green, blue;
                red = 255 * (1 - p_red)  * (1 - p_k);
                green = 255 * (1 - p_green) * (1 - p_k);
                blue = 255 * (1 - p_blue) * (1 - p_k);
                int intr, intg, intb;
                intr = Convert.ToInt32(red);
                intg = Convert.ToInt32(green);
                intb = Convert.ToInt32(blue);

                pictureBox1.BackColor = Color.FromArgb(intr,intg,intb);
                Color myColor = Color.FromArgb(intr,intg,intb);
                string hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                label16.Text = "#" + hex;
                label16.Visible = true;
                double rx, gx, bx;
                rx = Math.Round(red, 0);
                gx = Math.Round(green, 0);
                bx = Math.Round(blue,0);
                string r_display,g_display, b_display;
                r_display = rx.ToString();
               
                g_display = gx.ToString();
                b_display=bx.ToString();
                label19.Text=r_display;
                label18.Text = g_display;
                label17.Text = b_display;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label16.Visible = false;
            label19.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 bio = new Form2();
            bio.ShowDialog();



        }
    }
}
