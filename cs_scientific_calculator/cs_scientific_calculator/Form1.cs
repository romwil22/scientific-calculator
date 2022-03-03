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
        double result;
        String opPerform;
        bool isOperation = false;
        public sci_cal()
        {
            InitializeComponent();
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
            result = 0;
            operation_label.Text = "";
        }

        private void plus_over_minus_Click(object sender, EventArgs e)
        {
            plusMinus = double.Parse(result_textbox.Text);
            plusMinus = plusMinus * -1;
            result_textbox.Text = plusMinus.ToString();
        }

        

        private void equal_Click(object sender, EventArgs e)
        {
            switch (opPerform)
            {
                case "+":
                    result_textbox.Text = (result + double.Parse(result_textbox.Text)).ToString();
                    break;
                case "-":
                    result_textbox.Text = (result - double.Parse(result_textbox.Text)).ToString();
                    break;
                case "*":
                    result_textbox.Text = (result * double.Parse(result_textbox.Text)).ToString();
                    break;
                case "/":
                    result_textbox.Text = (result / double.Parse(result_textbox.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(result_textbox.Text);
            operation_label.Text = ""; 
        }

        private void log_Click(object sender, EventArgs e)
        {
            result = Math.Log10(double.Parse(result_textbox.Text));
            operation_label.Text = "log(" + result_textbox.Text + ")";
            result_textbox.Text = result.ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(double.Parse(result_textbox.Text));
            operation_label.Text = "sqrt(" + result_textbox.Text + ")";
            result_textbox.Text = result.ToString();
        }

        private void pi_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            operation_label.Text = "Pi";
            result_textbox.Text = result.ToString();
        }

        private void abs_Click(object sender, EventArgs e)
        {
            result = Math.Abs(int.Parse(result_textbox.Text));
            result_textbox.Text = result.ToString();
        }

        private void exp_Click(object sender, EventArgs e)
        {
            result = Math.Exp(double.Parse(result_textbox.Text));
            result_textbox.Text = result.ToString();
        }

        private void number_click(object sender, EventArgs e)
        {
            if ((result_textbox.Text == "0") || isOperation)
            {
                result_textbox.Clear();
            }

            isOperation = false;
            Button numbers = (Button)sender;

            if (numbers.Text == ".")
            {
                if (!result_textbox.Text.Contains("."))
                {
                    result_textbox.Text = result_textbox.Text + numbers.Text;
                }
            }
            else
            {
                result_textbox.Text = result_textbox.Text + numbers.Text;
            }
            
        }

        private void operators_Click(object sender, EventArgs e)
        {
            Button operatorsButton = (Button)sender;

            if (result != 0)
            {
                equal.PerformClick();
                opPerform = operatorsButton.Text;
                operation_label.Text = result.ToString() + " " + opPerform;
                isOperation = true;
            }
            else
            {
                opPerform = operatorsButton.Text;
                result = double.Parse(result_textbox.Text);
                operation_label.Text = result.ToString() + " " + opPerform;
                isOperation = true;
            }
            
        }

        private void over_x_Click(object sender, EventArgs e)
        {
            result = 1 / double.Parse(result_textbox.Text);
            operation_label.Text = "1 / " + result_textbox.Text;
            result_textbox.Text = result.ToString();
        }

        private void e_Click(object sender, EventArgs e)
        {
            result = Math.E;
            result_textbox.Text = result.ToString();
        }

        private void raise_x_Click(object sender, EventArgs e)
        {
            result = Math.Pow(10, double.Parse(result_textbox.Text));
            operation_label.Text = "10^" + result_textbox.Text;
            result_textbox.Text = result.ToString();
        }

        private void mod_Click(object sender, EventArgs e)
        {

            result_textbox.Text = (result % double.Parse(result_textbox.Text)).ToString();
        }

        private void ln_Click(object sender, EventArgs e)
        {
            result = Math.Log10(double.Parse(result_textbox.Text));
            operation_label.Text = "ln(" + result_textbox.Text + ")";
            result_textbox.Text = result.ToString();
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            result = int.Parse(result_textbox.Text);
            int factorial = 1;

            if (result < 0)
            {
                result_textbox.Text = "Syntax Error";
            }
            else if (result == 1)
            {
                result_textbox.Text = result.ToString();
            }
            else
            {
                for (int count = (int)result; count >= 2 ; count--)
                {
                    factorial *= count;
                }

                result_textbox.Text = factorial.ToString();
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            result = Math.Pow(double.Parse(result_textbox.Text), 2);
            result_textbox.Text = result.ToString();
        }
    }
}
