﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Application
{
    public partial class Area_Main : Form
    {
        public Area_Main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangle t = new Triangle();
            t.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rectangle rc = new Rectangle();

            rc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Circle cr = new Circle();
            cr.Show();
            this.Hide();
        }
    }
}
