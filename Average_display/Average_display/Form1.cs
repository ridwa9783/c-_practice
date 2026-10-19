using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Average_display
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            
            int validation;

            if (int.TryParse(txtscore1.Text, out validation) && int.TryParse(txtscore2.Text, out validation) && int.TryParse(txtscore3.Text, out validation))
            {
                try
                {
                    int score1, score2, score3;

                    score1 = int.Parse(txtscore1.Text);
                    score2 = int.Parse(txtscore2.Text);
                    score3 = int.Parse(txtscore3.Text);

                    double average = (score1 + score2 + score3) / 3;

                    lblaverageoutput.Text = average.ToString();

                    if (average >= 90)
                    {
                        MessageBox.Show("Grade: A");
                    }
                    else if (average >= 80)
                    {
                        MessageBox.Show("Grade: B");
                    }
                    else if (average >= 70)
                    {
                        MessageBox.Show("Grade: C");
                    }
                    else
                    {
                        MessageBox.Show("Grade: F");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("exception");
                }

            }
            else
            {
                MessageBox.Show("score's only accepts integer");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //  clear
            txtscore1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();
            lblaverageoutput.Text = "";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
