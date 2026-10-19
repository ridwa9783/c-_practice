using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airplane_ticket_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string name;
            int age;
            int number_ticket;
            double baggage_weight;
            string travel_class = "";
            string travel_insurance = "";

            if (int.TryParse(txtage.Text, out age) && int.TryParse(txtnumber.Text, out number_ticket) && double.TryParse(txtweight.Text, out baggage_weight))
            {

                name = txtname.Text;
                age = int.Parse(txtage.Text);
                number_ticket = int.Parse(txtnumber.Text);
                baggage_weight = int.Parse(txtweight.Text);

                // travel class
                double fee_per_ticket = 0;
                if (radiofirstclass.Checked)
                {
                    travel_class = "First class";
                    fee_per_ticket = 150;
                }
                else if (radionormalclass.Checked)
                {
                    travel_class = "Normal class";
                    fee_per_ticket = 200;
                }
                else if (radiobusnessclass.Checked)
                {
                    travel_class = "Bussines class";
                    fee_per_ticket = 350;
                }

                // basic ticket cost 
                double basic_ticket_cost = number_ticket * fee_per_ticket;

                // discounts
                double discount = 0;
                if (number_ticket >= 1 && number_ticket <= 2)
                {
                    discount = 0;
                }
                else if (number_ticket >= 3 && number_ticket <= 4)
                {
                    discount = number_ticket * 0.05;

                }
                else if (number_ticket > 5)
                {
                    discount = number_ticket * 0.10;

                }
                else
                {
                    discount = 0;
                }

                // 20% child discount
                double child_discount = 0;
                if (age < 12)
                {
                    child_discount = number_ticket * 0.2;
                }
                else
                {
                    child_discount = 0;
                }


                // above 60
                double age_discount = 0;
                if (age > 60)
                {
                    age_discount = number_ticket * 0.1;
                }
                else
                {
                    age_discount = 0;
                }

                // travel insurance
                double insurance_cost = 0;
                if (chinsurance.Checked)
                {
                    insurance_cost = number_ticket * 25;
                    travel_insurance = "Yes";
                }
                else
                {
                    insurance_cost = 0;
                    travel_insurance = "No";

                }

                // upto 20kg baggage 
                double baggage_amount = 0;
                if (baggage_weight <= 20)
                {
                    baggage_amount = 0;
                }
                else
                {
                    baggage_amount = baggage_weight * 10;
                }

                // total amount calculate
                double total_amount = (basic_ticket_cost + baggage_amount + insurance_cost) - discount - child_discount - age_discount;

                if (age >= 1 && age <= 100)
                {
                    if (number_ticket >= 1 && number_ticket <= 5)
                    {
                        if (baggage_weight >= 0 && baggage_weight <= 50)
                        {
                            if (age < 12 && radiofirstclass.Checked)
                            {
                                string booking_status = "rejected";
                                // display
                                listBox1.Items.Add("Passenger name: " + name);
                                listBox1.Items.Add("Passenger age: " + age);
                                listBox1.Items.Add("number of ticket: " + number_ticket);
                                listBox1.Items.Add("Baggage weight: " + baggage_weight);
                                listBox1.Items.Add("Travel class: " + travel_class);
                                listBox1.Items.Add("travel insurance is selected: " + travel_insurance);
                                listBox1.Items.Add("");
                                listBox1.Items.Add("Booking Status: " + booking_status);

                                MessageBox.Show("Sababta reject lakuu siiyey waa inay da'da ka yartahay 12 sano sidoo kalena aad doratay first class");

                            }
                            else
                            {
                                string booking_status = "approved";
                                // display
                                listBox1.Items.Add("Passenger name: " + name);
                                listBox1.Items.Add("Passenger age: " + age);
                                listBox1.Items.Add("number of ticket: " + number_ticket);
                                listBox1.Items.Add("Baggage weight: " + baggage_weight);
                                listBox1.Items.Add("Travel class: " + travel_class);
                                listBox1.Items.Add("travel insurance is selected: " + travel_insurance);
                                listBox1.Items.Add("");

                                listBox1.Items.Add("travel insurance cost: " + insurance_cost);
                                listBox1.Items.Add("baggage cost: " + baggage_amount);
                                listBox1.Items.Add("Basic ticket cost: " + basic_ticket_cost);
                                listBox1.Items.Add("Discount: " + discount);
                                listBox1.Items.Add("Child discount: " + child_discount);
                                listBox1.Items.Add("above 60 age discount: " + age_discount);
                                listBox1.Items.Add("Total Amount: " + total_amount);

                                listBox1.Items.Add("");
                                listBox1.Items.Add("Booking Status: " + booking_status);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Baggage weight need to between 1 upto 50 kg");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Number of ticked need to bee 1 - 5");
                    }
                }
                else
                {
                    MessageBox.Show("Age need to be 1-100");
                }
            }
            else
            {
                MessageBox.Show("enter numeric value");
            }
        }
    }
}
