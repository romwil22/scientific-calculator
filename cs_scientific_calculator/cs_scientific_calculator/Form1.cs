﻿using System;
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
            opPerform = operatorsButton.Text;
            result = double.Parse(result_textbox.Text);
            operation_label.Text = result.ToString() + " " + opPerform;
            isOperation = true;
        }
    }
}
