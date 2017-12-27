using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultParam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            calcBox.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            calcBox.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            calcBox.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            calcBox.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            calcBox.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            calcBox.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            calcBox.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            calcBox.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            calcBox.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            calcBox.Text += "0";
        }

        private void clearEntire_Click(object sender, EventArgs e)
        {
            var delete = calcBox.Text;
            bool action = true;
            var checker = calcBox.Text; 
            if (calcBox.Text == "")
            {
                action = false;
            }

            if(action)
            {
                var saver = delete.Remove(delete.Length - 1);
                calcBox.Text = saver;
            }
            
        }

        private void clearLast_Click(object sender, EventArgs e)
        {
            calcBox.Text = null;
            result.Text = null;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            var number = double.Parse(calcBox.Text);
            var toCalculate  = double.Parse(result.Text)+number;
            result.Text = toCalculate.ToString();
            calcBox.Text = null;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            var number = double.Parse(calcBox.Text);
            var toCalculate = double.Parse(result.Text) - number;
            result.Text = toCalculate.ToString();
            calcBox.Text = null;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            var number = double.Parse(calcBox.Text);
            var toCalculate = double.Parse(result.Text) * number;
            result.Text = toCalculate.ToString();
            calcBox.Text = null;
        }

        private void devide_Click(object sender, EventArgs e)
        {
            var number = double.Parse(calcBox.Text);
            var toCalculate = double.Parse(result.Text) / number;
            result.Text = toCalculate.ToString();
            calcBox.Text = null;
        }

        private void point_Click(object sender, EventArgs e)
        {
            calcBox.Text += ",";
        }
    }
}
