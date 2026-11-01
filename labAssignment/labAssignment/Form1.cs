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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace labAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // creating variable

            int id;
            double mark;

            // Validate ID
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Student ID must be a whole number.");
                return;
            }
            if (id < 0)
            {
                MessageBox.Show("Student ID cannot be negative.");
                return;
            }

            // Validate Mark
            if (!double.TryParse(txtmarks.Text, out mark))
            {
                MessageBox.Show("Mark must be a number.");
                return;
            }
            if (mark < 0)
            {
                MessageBox.Show("Mark cannot be negative.");
                return;
            }

            // Validate the other fields
            if (txtName.Text == "" || txtDepartmen.Text == "")
            {
                MessageBox.Show("Please enter the name and department.");
                return;
            }
            if (!rundergrow.Checked && !rpost.Checked)
            {
                MessageBox.Show("Please choose a student type.");
                return;
            }

            //string type = rundergrow.Checked ? "Undergraduate" : "Postgraduate";

            try
            {
                // AppendText keeps the old records and adds the new one at the end
                StreamWriter outputFile = File.CreateText("student.txt");
                outputFile.Write(txtID.Text);
                outputFile.WriteLine(txtName.Text);
                outputFile.WriteLine(txtDepartmen.Text);
                outputFile.WriteLine(mark);
               // outputFile.WriteLine(type);
                outputFile.WriteLine();

                outputFile.Close();


                MessageBox.Show("xogtaada wala save gareye.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      

        private void btnreadfromfile_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                StreamReader inputFile = File.OpenText("student.txt");
                while (!inputFile.EndOfStream)
                {
                    string line = inputFile.ReadLine();
                    listBox1.Items.Add(line);
                }
                inputFile.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("student.txt was not found. Save a student first.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtDepartmen.Clear();
            txtmarks.Clear();
            rundergrow.Checked = false;
            rpost.Checked = false;
            txtID.Focus();
            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

