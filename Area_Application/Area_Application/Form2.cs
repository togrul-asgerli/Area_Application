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
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }
       
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Area_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                double a = Double.Parse(f_side.Text);
                double b = Double.Parse(s_side.Text);
                double c = Double.Parse(th_side.Text);

                if(a<=0 || b<=0 || c<=0)
                {
                    MessageBox.Show("Input has to positive");
                    return;
                }

                double max = Math.Max(a, b);
                max = Math.Max(max, c);

                if (max == a)
                {
                    a = c;
                    c = max;
                }
                else if (max == b)
                {
                    b = c;
                    c = max;
                }
                else
                {
                    c = max;
                }

                if (Math.Abs(a - b) < c && c < a + b)
                {
                    if (a == b && a == c)
                    {
                        txt_area.Text = "Area =" + (a * Math.Sqrt(3) / 2).ToString();
                    }
                    else if ((a * a) + (b * b) == (c * c))
                    {
                        txt_area.Text = "Area =" + ((a * b) / 2).ToString();
                    }
                    else
                    {
                        double p = (a + b + c) / 2;
                        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        txt_area.Text = "Area =" + area.ToString();
                    }

                }
                else
                {
                    txt_area.Text = txt_area.Text + "Opeartion Failed!";
                }
                txt_perm.Text = "Perimetr =" + (Double.Parse(f_side.Text) + Double.Parse(s_side.Text) + Double.Parse(th_side.Text)).ToString();
                }
            catch
            {
                MessageBox.Show("Enter number in valid format!!");
            }
            }

        private void Triangle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Area_Main a = new Area_Main();
            a.Show();
        }
    }
    
}
