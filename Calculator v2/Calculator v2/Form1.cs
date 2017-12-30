using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_v2
{
    public partial class Form1 : Form
    {
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

        private void point_Click(object sender, EventArgs e)
        {
            calcBox.Text += ",";
        }

        private void c_Click(object sender, EventArgs e)
        {
            calcBox.Text = null;
        }

        private void ce_Click(object sender, EventArgs e)
        {
            var delete = calcBox.Text;
            bool action = true;
            var checker = calcBox.Text;
            if (calcBox.Text == "")
            {
                action = false;
            }

            if (action)
            {
                var saver = delete.Remove(delete.Length - 1);
                calcBox.Text = saver;
            }
        }

        private void devide_Click(object sender, EventArgs e)
        {
            calcBox.Text += "/";

        }

        private void plus_Click(object sender, EventArgs e)
        {
            calcBox.Text += "+";

        }

        private void minus_Click(object sender, EventArgs e)
        {
            calcBox.Text += "-";

        }

        private void multiply_Click(object sender, EventArgs e)
        {
            calcBox.Text += "*";

        }

        private void calcBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(calcBox.Text, " ^ [0-9]"))
            {
                calcBox.Text = "";
            }
        }

        private void calcBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            var rawInput = calcBox.Text.ToList();
            
            List<string> input = new List<string>();

            //list edit
            for (int i = 0; i < rawInput.Count; i++)
            {
                if (i + 1 < rawInput.Count)
                {
                    if (
                            rawInput[i + 1] != '*' && rawInput[i + 1] != '/'
                            && rawInput[i + 1] != '+' && rawInput[i + 1] != '-'
                            && rawInput[i] != '*' && rawInput[i] != '/'
                            && rawInput[i] != '+' && rawInput[i] != '-')
                    {
                        var edit1 = rawInput[i].ToString();
                        var edit2 = rawInput[i + 1].ToString();
                        var sum = edit1 + edit2;
                        input.Add(sum);
                        i++;
                    }
                    else
                    {
                        var prep = rawInput[i].ToString();
                        input.Add(prep);

                    }
                }
                else
                {
                    var prep = rawInput[i].ToString();
                    input.Add(prep);
                }

            }
            
            //high priority calculations
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == "*" || input[i] == "/")
                {
                    var num1 = double.Parse(input[i-1]);
                    var num2 = double.Parse(input[i + 1]);
                    double change = 0;

                    if (input[i]=="*")
                    {
                        change = num1 * num2;
                        
                    }
                    else
                    {
                        change = num1 / num2; 
                    }
                    input[i] = change.ToString();
                    input.Remove(input[i + 1]);
                    input.Remove(input[i - 1]);
                    i -= 1;
                }
            }

            //simple calculations
           
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == "+" || input[i] == "-")
                {
                    var num1 = double.Parse(input[i - 1]);
                    var num2 = double.Parse(input[i + 1]);
                    double change = 0;

                    if (input[i] == "+")
                    {
                        change = num1 + num2;

                    }
                    else
                    {
                        change = num1 - num2;
                    }
                    input[i] = change.ToString();
                    input.Remove(input[i + 1]);
                    input.Remove(input[i - 1]);
                    i -= 1;
                }
            }
            calcBox.Text = input[0];
        }
    }
}
