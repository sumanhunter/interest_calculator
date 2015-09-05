using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Type Casting
            double principal = Convert.ToDouble(principalText.Text);
            double time = Convert.ToDouble(timeText.Text);
            double rate = Convert.ToDouble(rateText.Text);

            Interest inc = new Interest(principal, time, rate);

            lblResult.Text = "Interest is NRs. " + inc.getInterest().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void principalText_TextChanged(object sender, EventArgs e)
        {
            TextBox r = new TextBox();
            r.Text = "Please Enter in NRP";
        }

        private void timeText_TextChanged(object sender, EventArgs e)
        {
            TextBox p = new TextBox();
            p.Text = "Please Enter in Years";
        }

        private void rateText_TextChanged(object sender, EventArgs e)
        {
            TextBox s = new TextBox();
            s.Text = "Please Enter in Percentage";
        }


    }
}
