using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            double validation;

            double hoursWorked = double.Parse(hourseworkedtextbox.Text);
            double payRate = double.Parse(hourlypayratetextbox.Text);


            if (double.TryParse(hourseworkedtextbox.Text, out validation) && double.TryParse(hourlypayratetextbox.Text, out validation))
            {
                if (hoursWorked >= 0 && payRate <= 168)
                {
                        if (payRate >= 0)
                        {
                            double grossPay = hoursWorked * payRate;
                            grossbylabel.Text = grossPay.ToString();
                        }
                        else
                        {
                            MessageBox.Show("payrate ka kama yaraan karo zero dollar");
                        }
                }
                else
                {
                    MessageBox.Show("saacada shaqada kama yaraan karto zero");
                }

            }
            else
            {
                MessageBox.Show("hour's worked and payrate only accepts double or integer");
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            // clear
            hourseworkedtextbox.Clear();
            hourlypayratetextbox.Clear();
            grossbylabel.Text = "";

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
