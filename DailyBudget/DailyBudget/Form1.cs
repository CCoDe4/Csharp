using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DailyBudget
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            DateTime localDate = DateTime.Now;
            currentDate.Text = localDate.ToString();
            
            
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {

            decimal totalMoney = decimal.Parse(monthlyBudget.Text);
            decimal rent = decimal.Parse(homeRent.Text);
            decimal communication = decimal.Parse(communicationMoney.Text);
            decimal transport = decimal.Parse(transportMoney.Text);
            decimal other = decimal.Parse(otherMoney.Text);


            totalMoney = totalMoney - rent - communication - transport - other;
            var perDay = totalMoney / 31;
            perDay = Convert.ToDecimal(String.Format("{0:0.00}", perDay));
            dailyMoney.Text = perDay.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            monthlyBudget.Text = "0";
            homeRent.Text = "0";
            communicationMoney.Text = "0";
            transportMoney.Text = "0";
            dailyMoney.Text = "0";
            otherMoney.Text = "0";
        }
    }
}
