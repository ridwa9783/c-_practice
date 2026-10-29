using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)

        {



            //variable
            int NumberOfPackages;
            double PricePerPackage;

            if (int.TryParse(txtnumber.Text, out NumberOfPackages) && double.TryParse(txtperpackage.Text, out PricePerPackage))

                NumberOfPackages = int.Parse(txtnumber.Text);
            PricePerPackage = double.Parse(txtnumber.Text);

            if (NumberOfPackages < 0)
            {
                MessageBox.Show("Numberkan lama ogolo tiro negative ah");
                return;

            }

            //subtotal Before Discount
            double SubTotal;

            SubTotal = NumberOfPackages * PricePerPackage;

            //Discount Rate
            double discountRate = 0;

            //Discount Amount
            double discountAmount = 0;

            // discount calculation
            if (NumberOfPackages >= 10 && NumberOfPackages <= 19)
            {
                discountAmount = SubTotal * 0.2;
                discountRate = 20;
            }
            else if (NumberOfPackages >= 20 && NumberOfPackages <= 49)
            {
                discountAmount = SubTotal * 0.3;
                discountRate = 30;
            }
            else if (NumberOfPackages >= 50 && NumberOfPackages <= 99)
            {
                discountAmount = SubTotal * 0.4;
                discountRate = 40;
            }
            else if (NumberOfPackages >= 100)
            {
                discountAmount = SubTotal * 0.5;
                discountRate = 50;
            }


            //total
            double Total;
            Total = SubTotal - discountAmount;
         

            //list box
            listBox1.Items.Add("Number Of Packages : " + txtnumber.Text);
            listBox1.Items.Add("Price Per Package : $ " + txtperpackage.Text);
            listBox1.Items.Add("Subtotal(Before Discount) : $ " + SubTotal);
            listBox1.Items.Add("Discount Rate : " + discountRate);
            listBox1.Items.Add("Discount Amount : " + discountAmount);
            listBox1.Items.Add("Total Amount (After Discount) : " + Total);


        }
            
       


        private void btnclear_Click(object sender, EventArgs e)
        {
            txtperpackage.Clear();
            txtperpackage.Clear();

            listBox1.Items.Clear();




        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
    
    


