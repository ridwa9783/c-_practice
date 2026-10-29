using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreatenewfile_Click(object sender, EventArgs e)
        {



            try
            {
                StreamWriter writer = File.CreateText("DataFile.txt");
                writer.WriteLine("Magaca: roodo warsame");
                writer.WriteLine("Fasalka: CA242");
                writer.WriteLine("Maaddada: Programming C#");
                writer.Close();

                MessageBox.Show("Feylka DataFile.txt si guul leh ayaa loo abuuray!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cillad ayaa dhacday: " + ex.Message);
            }
        }

        private void btnreadingfunction_Click(object sender, EventArgs e)
        {



            try
            {
                string filePath = "DataFile.txt";

                if (File.Exists(filePath))
                {
                    // ReadAllLines creates a string array of lines
                    string[] lines = File.ReadAllLines(filePath);

                    // Clear previous items from ListBox
                    listBox1.Items.Clear();

                    // Load each line into ListBox
                    foreach (string line in lines)
                    {
                        listBox1.Items.Add(line);
                    }

                    MessageBox.Show("Xogta feylka si guul leh ayaa loogu soo daray ListBox!");
                }
                else
                {
                    MessageBox.Show("Feylka lama helin! Marka hore abuur feylka.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cillad ayaa dhacday: " + ex.Message);
            }
        }




        private void btndeletefile_Click(object sender, EventArgs e)
        {




            try
            {
                string filePath = "DataFile.txt";

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    listBox1.Items.Clear();
                    MessageBox.Show("Feylka DataFile.txt gabi ahaanba waa la tirtiray!");
                }
                else
                {
                    MessageBox.Show("Feylkan ma jiro ama mar hore ayaa la tirtiray.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cillad ayaa dhacday: " + ex.Message);
            }
        }

        private void btndeleteitem_Click(object sender, EventArgs e)
        {




            try
            {
                string filePath = "DataFile.txt";

                // Check if user selected an item in the ListBox
                if (listBox1.SelectedIndex != -1)
                {
                    // Remove selected item from ListBox
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                    // Rewrite remaining items back into the file
                    StreamWriter writer = File.CreateText(filePath);
                    foreach (var item in listBox1.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                    writer.Close();

                    MessageBox.Show("Shaygii la doortay waa la tirtiray, feylkiina waa la cusboonaysiiyay!");
                }
                else
                {
                    MessageBox.Show("Fadlan marka hore ListBox-ka ka dooro shayga aad rabto inaad tirtirto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cillad ayaa dhacday: " + ex.Message);
            }
        }
    }
}
