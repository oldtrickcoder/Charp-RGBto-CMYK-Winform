﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Csharp_rgb_Color
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch(Exception )
            {
                MessageBox.Show("Unable to connect to internet, please check your connection", "info");
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.instagram.com/yodagunawan");
        }
    }
}
