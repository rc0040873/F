using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x * Math.PI / 180.0));
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        double acos(double x)
        {
            return (Math.Acos(x * Math.PI / 180.0));
        }
        double tan(double x)
        {
            return (Math.Tan(x * Math.PI / 180.0));
        }
        double atan(double x)
        {
            return (Math.Atan(x * Math.PI / 180.0));
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read values for force and angle from textbox 
                double Force = double.Parse(textBox2.Text);
                double Angle = double.Parse(textBox1.Text);
                //calcuate fx and fy using equations fx = fcos and fy = fsin
                double Fx = Force * cos(Angle);
                double Fy = Force * sin(Angle);
                //output solutions lable1 and lable2
                label1.Text = "Fx = " + Fx;
                label2.Text = "Fy = " + Fy;
            }
            catch
            {
                MessageBox.Show("Error on input");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
