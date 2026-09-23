using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_ca242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            //stage of input
            //creating variables
            string day_of_the_week;
            string name_of_the_month;
            string numericday;
            string year;
            string full_data;

            //initial values to varaible
            day_of_the_week = txtweek.Text;
            name_of_the_month = txtname.Text;
            numericday =  txtnumeric.Text;
            year = txtyear.Text;

            //store process conactination of full date
            full_data = day_of_the_week + " , " + name_of_the_month + " , " + numericday + " , " + year;


            //store3= the output using label
            lbloutput.Text = full_data;

    }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbx and label
            txtweek.Clear();
            txtname.Clear();
            txtnumeric.Text = string.Empty;
            txtyear.Clear();

            //
            lbloutput.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
