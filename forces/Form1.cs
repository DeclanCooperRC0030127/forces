using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Force = Convert.ToDouble(textBox2.Text);
            double Angle = Convert.ToDouble(textBox1.Text);
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);
            MessageBox.Show("Fx =" + Fx);
            MessageBox.Show("Fy =" + Fy);



        }
        double sin (double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }


        double cos (double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }


    }
}
