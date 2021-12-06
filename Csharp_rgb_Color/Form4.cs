using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;


namespace Csharp_rgb_Color
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hexstring = textBox1.Text;
          
            
            if (textBox1.Text.Length > 6)
            {
                MessageBox.Show("Jumlah karakter Warna Hex hanya sampai 6 cek lagi warna yang kamu maksud");
            }else if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Mohon Isi dahulu datanya");
            }else if (textBox1.Text.Length<6 )
            {
                MessageBox.Show("Sepertinya tidak ada data itu di kode warna Hexadecimal");
            }
            else
            {
                
                int r, g, b;
                r = int.Parse(hexstring.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                g = int.Parse(hexstring.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                b = int.Parse(hexstring.Substring(4, 2), NumberStyles.AllowHexSpecifier);
                pictureBox1.BackColor = Color.FromArgb(r, g, b);
                double rd = r / 255.000;
                double grn = g / 255.000;
                double bleu = b / 255.000;

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


                }
                else if (grn > bleu)
                {
                    maxwarna = grn;
                }
                else
                {
                    maxwarna = bleu;
                }

                double cyan, magenta, yellow, k, k_publish;
                k = (1 - maxwarna);
                cyan = ((1 - rd - k) / (1 - k)) * 100;
                magenta = ((1 - grn - k) / (1 - k)) * 100;
                yellow = ((1 - bleu - k) / (1 - k)) * 100;
                k_publish = k * 100;

                double cyancode = Math.Round(cyan, 0);
                double magcode = Math.Round(magenta, 0);
                double yellowcode = Math.Round(yellow, 0);
                double kcode = Math.Round(k_publish, 0);
                label19.Text=r.ToString();
                label18.Text = g.ToString();
                label17.Text = b.ToString();
                label19.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
                label10.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label5.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                label11.Visible = true;
                //
                label20.Text = cyancode.ToString();
                label16.Text = magcode.ToString();
                label6.Text = yellowcode.ToString();
                label7.Text = kcode.ToString();
                label20.Visible = true;
                label16.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                //
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
            }

         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte[] b;

            string s = "";

            s += e.KeyChar;

            b = ASCIIEncoding.ASCII.GetBytes(s);


            if (e.KeyChar != (char)Keys.Back)

            {

                //check if character is any 0-9/a-f/A-F

                if (!(((0x30 <= b[0]) && (b[0] <= 0x39)) || ((0x41 <= b[0]) && (b[0] <= 0x46)) || ((0x61 <= b[0]) && (b[0] <= 0x66))))

                {

                    e.Handled = true;

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Opsi xyz = new Opsi();
            xyz.ShowDialog();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            this.Hide();
            Form1 xyz=new Form1();
            xyz.ShowDialog();

        }



        private void Form4_Load(object sender, EventArgs e)
        {
            label19.Visible = false;
            label18.Visible = false;    
            label17.Visible = false;
            label10.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label11.Visible = false;
            //
            label20.Visible = false;
            label16.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            //
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
