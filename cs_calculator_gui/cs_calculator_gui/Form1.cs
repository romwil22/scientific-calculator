using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_calculator_gui
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "0";
        }

        private void point_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + ".";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            calcuDisplay.Text = calcuDisplay.Text + "-";
        }

        private void multiple_Click(object sender, EventArgs e)
        {

            calcuDisplay.Text = calcuDisplay.Text + "x";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            
            calcuDisplay.Text = calcuDisplay.Text + "/";
        }
    }
}
