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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double width = Double.Parse(txt_width.Text);
                double height = Double.Parse(txt_Length.Text);
                if(width<=0 || height <= 0)
                {
                    MessageBox.Show("Input has to positive");
                    return;
                }

                txt_area.Text = "Area =" + (width * height).ToString();
                txt_perm.Text = "Perimetr =" + (width + height).ToString();
            }
            catch
            {
                MessageBox.Show("Enter valid form of number!!");
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Area_Main a = new Area_Main();
            a.Show();
        }
    }
}
