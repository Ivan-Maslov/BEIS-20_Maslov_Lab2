using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Razrab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(a + b);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(a - b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(a * b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox1.Text);
            double b = Double.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(a / b);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char num = e.KeyChar;
            if (!Char.IsDigit(num))
            {
                e.Handled = true;
            }
        }
    }
}
