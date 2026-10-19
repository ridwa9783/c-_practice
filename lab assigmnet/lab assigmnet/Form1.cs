using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_assigmnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e) { 
        }
            private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtcustomername.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            // Age
            if (!int.TryParse(txtcustomerage.Text, out int age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (age < 18 || age > 80)
            {
                MessageBox.Show("Age must be between 18 and 80.");
                return;
            }

            // Rental Days
            if (!int.TryParse(txtnumber.Text, out int days))
            {
                MessageBox.Show("Please enter valid rental days.");
                return;
            }

            if (days < 1 || days > 30)
            {
                MessageBox.Show("Rental days must be between 1 and 30.");
                return;
            }

            // Driving Exp
            if (!int.TryParse(txtexperience.Text, out int experience))
            {
                MessageBox.Show("Please enter valid driving experience.");
                return;
            }

            if (experience < 0)
            {
                MessageBox.Show("Driving experience cannot be negative.");
                return;
            }

            // Below 21 not 
            if (age < 21)
            {
                MessageBox.Show("Customer is not eligible to rent.");
                return;
            }

            // At least 1 year experience
            if (experience < 1)
            {
                MessageBox.Show("Customer must have at least 1 year of driving experience.");
                return;
            }

            // Vehicle rate
            string vehicle = txteconomy.Text;
            double dailyRate = 0;

            if (vehicle == "Economy")
            {
                dailyRate = 35;
            }
            else if (vehicle == "SUV")
            {
                dailyRate = 60;
            }
            else if (vehicle == "Luxury")
            {
                dailyRate = 100;

                if (age < 25 || experience < 3)
                {
                    MessageBox.Show(
                        "Luxury requires at least 25 years of age and 3 years of driving experience."
                    );
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select vehicle type.");
                return;
            }

            // Basic cost
            double basicCost = dailyRate * days;

            // Discount
            double discountRate = 0;

            if (days >= 14)
            {
                discountRate = 0.10;
            }
            else if (days >= 7)
            {
                discountRate = 0.05;
            }

            double discount = basicCost * discountRate;

            // Insurance
            double insurance = 0;

            if (txtoption.Text == "Yes")
            {
                insurance = 15 * days;
            }
            else if (txtoption.Text != "No")
            {
                MessageBox.Show("Please select insurance option.");
                return;
            }

            // Young driver surcharge
            double youngDriver = 0;

            if (age >= 21 && age <= 24)
            {
                youngDriver = (basicCost - discount) * 0.10;
            }

            // Final cost
            double finalCost =
                basicCost - discount + insurance + youngDriver;

            // Display
            lblcustomername.Text = name;
            lblcustomerage.Text = vehicle;
            lblnumberdays.Text = "$" + basicCost.ToString("0.00");
            lblyearsdriving.Text = "$" + discount.ToString("0.00");
            lbltypeeconomy.Text = "$" + insurance.ToString("0.00");
            lbloption.Text = "$" + youngDriver.ToString("0.00");
            
        }




    }

       
        

        }
    

