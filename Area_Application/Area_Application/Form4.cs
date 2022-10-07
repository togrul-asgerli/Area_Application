using System;
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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(Double.Parse(txt_radius.Text)<=0)
                {
                    MessageBox.Show("Input has to positive");
                    return;
                }
                area.Text = "Area="+(Math.PI * (Double.Parse(txt_radius.Text) * Double.Parse(txt_radius.Text))).ToString();
                perimetr.Text = "Perimetr="+((Math.PI * 2 * Double.Parse(txt_radius.Text))).ToString();
            }
            catch
            {
                MessageBox.Show("Enter valid form of input!!");
            }
        }

        private void area_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Area_Main s = new Area_Main();
            s.Show();
        }
    }
}
