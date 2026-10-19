using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // creating varibales
            string name;
            int age;
            int rental_days;
            double experience;
            string vehicle_type = "";
            string insurance = "";

            if (int.TryParse(txtage.Text, out age) 
                && int.TryParse(txtnumber.Text, out rental_days) 
                && double.TryParse(txtyear.Text, out experience))
            {
                // assigning values to variables 
                name = txtname.Text;
                age = int.Parse(txtage.Text);
                rental_days = int.Parse(txtnumber.Text);
                experience = double.Parse(txtyear.Text);

                int daily_rate = 0;
                double discount = 0;
                double rental_cost = 0;
                double Insurance_amount = 0;
                double young_driver = 0;
                double final_rental_cost = 0;
                string rental_status = "";


                // daily rental rates
                if (rdeconomy.Checked)
                {
                    vehicle_type = "Economy";
                    daily_rate = 35;
                } else if (rdsuv.Checked)
                {
                    vehicle_type = "SUV";
                    daily_rate = 60;
                } else if (rdluxury.Checked)
                {
                    vehicle_type = "Lexury";
                    daily_rate = 100;
                }

                // calculate basic rental cost
                rental_cost = rental_days * daily_rate;

                // discount rates
                if (rental_days >= 7 && rental_days <= 13)
                {
                    discount = rental_cost * 0.5;
                } else if (rental_days >= 14)
                {
                    discount = rental_cost * 0.1;
                }
                else
                {
                    discount = 0;
                }

                // Insurance selected
                if (cbinsurance.Checked)
                {
                    Insurance_amount = rental_days * 15;
                }
                else
                {
                    Insurance_amount = 0;
                }

                // Age 21–24: Add 10% young-driver surcharge
                if (age >= 21 && age <= 24)
                {
                    young_driver = rental_cost * 0.10;
                } else
                {
                    young_driver = 0;
                }


                // final rental cost
                final_rental_cost = rental_cost + Insurance_amount + young_driver - discount;


                if (age >= 18 && age <= 80)
                {
                    if (rental_days >= 1 && rental_days <= 30)
                    {
                        if (experience >= 0)
                        {
                            if (age >= 21)
                            {
                                if (experience >= 1)
                                {


                                    if (rdluxury.Checked && age < 25 && experience <3)
                                    {
                                        rental_status = "Rejected";
                                        // display
                                        listBox1.Items.Add("Customer name: " + name);
                                        listBox1.Items.Add("Customer age: " + age);
                                        listBox1.Items.Add("Rental days: " + rental_days);
                                        listBox1.Items.Add("Driving experience: " + experience);
                                        listBox1.Items.Add("Vehicle Type: " + vehicle_type);
                                        listBox1.Items.Add("");
                                        listBox1.Items.Add("Final Rental Cost: " + rental_status);
                                        MessageBox.Show("You choose Luxury so your age must be 25 or higher and your experience must be 3 or higher");
                                    } 
                                    else
                                    {
                                        rental_status = "approved";
                                        // display
                                        listBox1.Items.Add("Customer name: " + name);
                                        listBox1.Items.Add("Customer age: " + age);
                                        listBox1.Items.Add("Rental days: " + rental_days);
                                        listBox1.Items.Add("Driving experience: " + experience);
                                        listBox1.Items.Add("Vehicle Type: " + vehicle_type);
                                        listBox1.Items.Add("Daily Rate: " + daily_rate);
                                        listBox1.Items.Add("Basic rental cost: " + rental_cost);
                                        listBox1.Items.Add("Discount: " + discount);
                                        listBox1.Items.Add("insurance cost: " + Insurance_amount);
                                        listBox1.Items.Add("Young driving subcharch: " + young_driver);
                                        listBox1.Items.Add("Final Rental Cost: " + final_rental_cost);
                                        listBox1.Items.Add("");
                                        listBox1.Items.Add("Final Rental Cost: " + rental_status);
                                    }

                                }
                                else
                                {
                                    rental_status = "Rejected";
                                    MessageBox.Show("You must to have one year of experience");

                                    // display
                                    listBox1.Items.Add("Customer name: " + name);
                                    listBox1.Items.Add("Customer age: " + age);
                                    listBox1.Items.Add("Rental days: " + rental_days);
                                    listBox1.Items.Add("Driving experience: " + experience);
                                    listBox1.Items.Add("Vehicle Type: " + vehicle_type);
                                    listBox1.Items.Add("");
                                    listBox1.Items.Add("Final Rental Cost: " + rental_status);

                                }
                            }
                            else
                            {
                                MessageBox.Show("You are not eligible to rent a vehicle");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Year of experience can't be nagative value");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rental days must be between 1 and 30");
                    }
                }
                else
                {
                    MessageBox.Show("Age must be between 18 and 80");
                }

            }
            else
            {
                MessageBox.Show("Enter only numerical value");
            }
        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
