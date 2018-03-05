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
        List<string> history = new List<string>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string txt = ((Button)sender).Text;
            if (txt == ".")
            {
                calcBox.Text += ",";
            }
            else
            {
                calcBox.Text += ((Button)sender).Text;
            }

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
            string delete = calcBox.Text;
            bool action = true;
            string checker = calcBox.Text;
            if (calcBox.Text == "")
            {
                action = false;
            }

            if (action)
            {
                string saver = delete.Remove(delete.Length - 1);
                calcBox.Text = saver;
            }
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
            char txt = e.KeyChar;
            if (txt == '.')
            {
                e.KeyChar = ',';
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                            && (e.KeyChar != '.') && (e.KeyChar != '*')
                            && (e.KeyChar != '/') && (e.KeyChar != '+')
                            && (e.KeyChar != '-')&& (e.KeyChar != ','))
            {
                e.Handled = true;
            }

        }

        private void result_Click(object sender, EventArgs e)
        {
            string equation = calcBox.Text;
            List<char> rawInput = calcBox.Text.ToList();
            List<string> input = new List<string>();

            //for (int i = 0; i < history.Count; i++)
            //{
            //    historyBox.Items.Add(history.ElementAt(i));
            //    history.RemoveAt(i);
            //}

            bool ifNegative = false;
            string sum = null;

            if (rawInput[0] == '-')
            {
                ifNegative = true;
                rawInput.RemoveAt(0);
            }

            //list edit and rawInput processing
            for (int i = 0; i < rawInput.Count; i++)
            {

                if (rawInput[i] != '*' && rawInput[i] != '+'
                   && rawInput[i] != '-' && rawInput[i] != '/')
                {
                    sum += rawInput[i];
                    if (i + 1 == rawInput.Count)
                    {
                        input.Add(sum);
                        sum = null;
                    }
                }
                else
                {
                    if (ifNegative)
                    {
                        sum = sum.Insert(0, "-");
                        input.Add(sum);
                        sum = null;
                        ifNegative = false;
                    }
                    else
                    {
                        input.Add(sum);
                        sum = null;
                    }
                    string opMark = rawInput[i].ToString();
                    input.Add(opMark);

                }

            }

            //high priority calculations
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == "*" || input[i] == "/")
                {
                    double num1;
                    if (!double.TryParse(input[i - 1], out num1))
                    {
                        num1 = 0;
                    }
                    double num2; //double.Parse(input[i + 1]);
                    if (!double.TryParse(input[i + 1], out num2))
                    {
                        num2 = 0;
                    }

                    int indexOfOperator = i;
                    double change = 0;

                    //infinity calculations processing
                    double positive = double.PositiveInfinity;

                    if (!((num1 == positive) && (num2 == positive)))
                    {
                        if (input[i] == "*")
                        {
                            change = num1 * num2;
                        }
                        else
                        {
                            change = num1 / num2;
                        }
                        input[i] = change.ToString();
                    }
                    else
                    {
                        change = positive;
                        calcBox.Text = change.ToString();
                        break;
                    }

                    //fine

                    int itemRemove = indexOfOperator - 1;
                    int itemRemove2 = indexOfOperator;

                    input.RemoveAt(itemRemove);
                    input.RemoveAt(itemRemove2);
                    i -= 1;
                }
            }
            //simple calculations

            for (int i = 0; i < input.Count; i++)
            {
                double num1;
                double num2;
                double positive = double.PositiveInfinity;

                if (input[i] == "+" || input[i] == "-")
                {
                    double change = 0;
                    string temp = input[i - 1];
                    if (!double.TryParse(temp, out num1))
                    {
                        num1 = 0;
                    }

                    if (!double.TryParse(input[i + 1], out num2))
                    {
                        num2 = 0;
                    }

                    if (!((num1 == positive) && (num2 == positive)))
                    {
                        if (input[i] == "+")
                        {
                            change = num1 + num2;
                        }
                        else
                        {
                            change = num1 - num2;
                        }
                        input[i] = change.ToString();
                        input.RemoveAt(i + 1);
                        input.RemoveAt(i - 1);
                        i -= 1;
                    }
                    else
                    {
                        change = positive;
                        calcBox.Text = change.ToString();
                        break;
                    }
                }
            }

            //adding to history
            equation += "=";
            equation += input[0];
            history.Add(equation);

            for (int i = 0; i < history.Count; i++)
            {
                historyBox.Items.Add(history.ElementAt(i));
                history.RemoveAt(i);
            }


            calcBox.Text = input[0];
            calcBox.SelectionStart = calcBox.Text.Length + 1;
        }

        private void calcBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                result.PerformClick();
            }
        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            historyBox.Items.Clear();
        }

        private void historyBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string curItem = historyBox.SelectedItem.ToString();
            string result = "";
            int saveIndex = 0;

            for (int i = 0; i < curItem.Length; i++)
            {
                if(curItem[i]== '=')
                {
                    saveIndex = i;
                    break;
                }
            }

            for (int i = saveIndex+1; i < curItem.Length; i++)
            {
                string character = curItem[i].ToString();
                result += character;
            }
            calcBox.Text = result;
        }
    }
}
