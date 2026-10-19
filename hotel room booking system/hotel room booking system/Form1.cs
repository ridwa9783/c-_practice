using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_room_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblpasengername_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string name;
            int age ;
            int number_night;
            int number_of_guests;
            string room_type = "";
            string Breakfast ="";

            if (int.TryParse(txtguestage.Text, out age) && int.TryParse(txtnumbernight.Text, out number_night) && int.TryParse(txtnumberofguest.Text, out number_of_guests))
            {
                name = txtguestname.Text;
                age = int.Parse(txtguestage.Text);
                number_night = int.Parse(txtnumbernight.Text);
                number_of_guests = int.Parse(txtnumberofguest.Text);


                // room rate
                double room_rate = 0;

                if (radiostandard.Checked)
                {
                    room_rate = 30;
                    room_type = "Standard";
                } else if (radionormal.Checked)
                {
                    room_rate = 80;
                    room_type = "Normal";
                } else if (radiohight.Checked)
                {
                    room_rate = 130;
                    room_type = "Hight";
                }

                // boocking cost
                double booking_cost = number_night * room_rate;

                // discount
                double discount = 0;
                if (number_night >=1 && number_night <=4)
                {
                    discount = 0;
                } else if (number_night >=5 && number_night <= 9)
                {
                    discount = booking_cost * 0.05;
                } else if (number_night >= 10)
                {
                    discount = booking_cost * 0.12;

                }


                // breakfast calculate
                double breakfast_amount = 0;
                if (chbreakfast.Checked)
                {
                    breakfast_amount = 10 * number_of_guests * number_night;
                    Breakfast = "Yes";
                } else
                {
                    breakfast_amount = 0;
                    Breakfast = "No";

                }

                // 
                double sub_charge = 0;
                if (number_of_guests > 4)
                {
                    sub_charge = booking_cost * 0.05;
                } else
                {
                    sub_charge = 0;

                }



                // above 60 
                double senior_discount = 0;
                if (age >= 60)
                {
                    senior_discount = booking_cost * 0.05;
                }
                else
                {
                    senior_discount = 0;

                }


                // total amount
                double total_amount = (booking_cost + breakfast_amount + sub_charge) - discount - senior_discount;


                if (name == "")
                {
                    MessageBox.Show("name can not be empty");
                }
                else
                {
                    if (age >= 18 && age <= 90)
                    {
                        if (number_night >= 1 && number_night <= 30)
                        {
                            if (number_of_guests >= 1 && number_of_guests <= 6)
                            {
                                string booking_status = "";

                                //
                                if (radiostandard.Checked && number_of_guests > 2)
                                {
                                    MessageBox.Show("you selected standar so number of guest allowed is lessthan 2");
                                    booking_status = "reject";

                                }
                                else if (radionormal.Checked && number_of_guests > 4)
                                {
                                    MessageBox.Show("you selected normal so number of guest allowed is lessthan 4");
                                    booking_status = "reject";


                                }
                                else if (radiohight.Checked && number_of_guests > 6)
                                {
                                    MessageBox.Show("you selected hight so number of guest allowed is lessthan 6");
                                    booking_status = "reject";


                                }
                                else
                                {
                                    booking_status = "Approved";

                                    // display
                                    listBox1.Items.Add("Guest name: " + name);
                                    listBox1.Items.Add("Guest age: " + age);
                                    listBox1.Items.Add("Guest name: " + name);
                                    listBox1.Items.Add("number of night: " + number_night);
                                    listBox1.Items.Add("number of guest: " + number_of_guests);
                                    listBox1.Items.Add("room type: " + room_type);
                                    listBox1.Items.Add("Breakfast is selected: " + Breakfast);
                                    listBox1.Items.Add("");
                                    listBox1.Items.Add("Break fast: " + breakfast_amount);
                                    listBox1.Items.Add("Room rate: " + room_rate);

                                    listBox1.Items.Add("Booking cost: " + booking_cost);
                                    listBox1.Items.Add("discount: " + discount);
                                    listBox1.Items.Add("senior discount: " + senior_discount);
                                    listBox1.Items.Add("Sub charge: " + sub_charge);
                                    listBox1.Items.Add("Total amount: " + total_amount);
                                    listBox1.Items.Add("");

                                    listBox1.Items.Add("Booking status: " + booking_status);


                                }
                            }
                            else
                            {
                                MessageBox.Show("number of guest must be between 1-6");

                            }
                        }
                        else
                        {
                            MessageBox.Show("number of night must be between 1-30");

                        }
                    }
                    else
                    {
                        MessageBox.Show("age must be between 8-90");
                    }
                }


            } else
            {
                MessageBox.Show("Only accepts numeric value");
            }

        }
    }
}
