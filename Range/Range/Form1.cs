using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            int number;

            if (int.TryParse(txtrange.Text, out number))
            {
                if (number >= 1 && number <= 10)
                {
                    lblrangedecision.Text = "waa sax";
                }
                else
                {
                    lblrangedecision.Text = "waa qalad";
                }
            }
            else
            {
                MessageBox.Show("enter integer number");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clear
            txtrange.Clear();
            lblrangedecision.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
