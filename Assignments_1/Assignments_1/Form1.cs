using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignments_1
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

        private void btnshowinfo_Click(object sender, EventArgs e)
        {

            // create variables and store data from textboxes
            string name = txtname.Text;
            string id = txtstudentid.Text;
            string department = txtdepartment.Text;
            int semester = int.Parse(txtsemester.Text);

            // concatenate
            string fullinfo = name + " , " + id + " , " + department + " , " + semester;

            // displaying the data
            lbloutput.Text = fullinfo;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clear
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();

            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
