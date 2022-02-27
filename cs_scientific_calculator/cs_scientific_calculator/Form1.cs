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
        public sci_cal()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (result_textbox.Text == "0")
            {
                result_textbox.Clear();
            }

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

        }
    }
}
