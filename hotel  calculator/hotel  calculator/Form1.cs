using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel__calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                // declaring the varibales 
                string guestname = txtguestname.Text;
                string roomtype = txtroomtype.Text;
                double nights_number = double.Parse(txtnight.Text);
                double price = double.Parse(txtpricenight.Text);

                // calculate room cost
                double roomcost = price * nights_number;


                // calculate tax and iscount
                double tax = roomcost * 0.1;
                double discountpercentage = roomcost * 0.05;


                // calculate total amount
                double finaltotal = roomcost + tax - discountpercentage;

                // displaying the outputs
                lblservicetax.Text = tax.ToString();
                lbldiscount.Text = discountpercentage.ToString();
                lbltotalamount.Text = finaltotal.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter correct way");
            }

        }
    }
}
