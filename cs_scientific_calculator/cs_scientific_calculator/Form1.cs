using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_scientific_calculator
{
    public partial class sci_cal : Form
    {
        double plusMinus;
        double num1;
        double result;
        String oprtr;
        bool isOp = false;
        public sci_cal()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (result_textbox.Text == "0" || isOp)
            {
                result_textbox.Clear();
            }
            isOp = false;
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (result_textbox.Text.Contains("."))
                {
                    result_textbox.Text += btn.Text;
                }
                
            }
            else
            {
                result_textbox.Text += btn.Text;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            int strIndex= result_textbox.Text.Length - 1;
            result_textbox.Text = result_textbox.Text.Remove(strIndex);

            if (result_textbox.Text == "")
            {
                result_textbox.Text = "0";
            }
        }

        private void ce_Click(object sender, EventArgs e)
        {
            result_textbox.Text = "0";
        }

        private void plus_over_minus_Click(object sender, EventArgs e)
        {
            plusMinus = double.Parse(result_textbox.Text);
            plusMinus = plusMinus * -1;
            result_textbox.Text = plusMinus.ToString();
        }

        private void times_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(result_textbox.Text);
            Button op = (Button)sender;
            oprtr = op.Text;
            isOp = true;

        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (oprtr)
            {
                case "+":
                    result_textbox.Text = (num1 + double.Parse(result_textbox.Text)).ToString();
                    break;
                case "-":
                    result_textbox.Text = (num1 - double.Parse(result_textbox.Text)).ToString();
                    break;
                case "*":
                    result_textbox.Text = (num1 * double.Parse(result_textbox.Text)).ToString();
                    break;
                case "/":
                    result_textbox.Text = (num1 / double.Parse(result_textbox.Text)).ToString();
                    break;
                
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            result = Math.Log10(double.Parse(result_textbox.Text));
            result_textbox.Text = result.ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(double.Parse(result_textbox.Text));
            result_textbox.Text = result.ToString();
        }

        private void pi_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            result_textbox.Text = result.ToString();
        }
    }
}
