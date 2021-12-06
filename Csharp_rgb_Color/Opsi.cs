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
    public partial class Opsi : Form
    {
        public Opsi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 rgbform = new Form1();
            rgbform.ShowDialog();
            Form3 cmykform=new Form3();
            //cmykform.ShowDialog();
            cmykform.Close();
            cmykform.Hide();
            Form4 hex=new Form4();
            //hex.ShowDialog();
            hex.Close();
            hex.Hide();
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 rgbform = new Form1();
            //rgbform.ShowDialog();
            //rgbform.Close();
            //rgbform.Hide();
            //Form1.ActiveForm.Close();

           
            //cmykform.Hide();
            Form4 hex = new Form4();
            //hex.ShowDialog();
            hex.Close();
            hex.Hide();
            Form3 cmykform = new Form3();
            cmykform.ShowDialog();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 rgbform = new Form1();
            //rgbform.ShowDialog();
            rgbform.Close();
            rgbform.Hide();
            Form3 cmykform = new Form3();
            //cmykform.ShowDialog();
            cmykform.Close();
            cmykform.Hide();
            Form4 hex = new Form4();
            hex.ShowDialog();
            //hex.Hide();
            
        }
    }
}
