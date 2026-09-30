using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
       
        
            private void btncalculate_Click(object sender, EventArgs e)
        {
            // Get values from TextBoxes
            try
            {
                // creating variables
                string customerName;
                double previousReading, currentReading, pricePerUnit;
                double usage, baseCost, tax, totalBill;

                // constants
                const double TAX_PERCENTAGE = 7;
                const double FIXED_CHARGE = 5;

                // getting input
               customerName =txtCustomer.Text;
                previousReading = double.Parse(txtprevious.Text);
                currentReading = double.Parse(txtcurrent.Text);
                pricePerUnit = double.Parse(txtUnitprice.Text);

                // process
                usage = currentReading - previousReading;
                baseCost = usage * pricePerUnit;
                tax = baseCost * (TAX_PERCENTAGE / 100);
                totalBill = baseCost + tax + FIXED_CHARGE;

                // displaying the result
                Usage.Text = usage.ToString();
                Taxamount.Text = tax.ToString("c", new CultureInfo("en-US"));
              TotalBill.Text = totalBill.ToString("c", new CultureInfo("en-US"));
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter  text in the customer name and valid numbers in the reading and price boxes.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //

    }

    }


    
    


