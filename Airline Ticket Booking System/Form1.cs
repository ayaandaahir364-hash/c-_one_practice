using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Variables
                string name = txtname.Text.Trim();
                int age;
                int tickets;
                double baggage;
                double ticketPrice = 0;
                double total;
                double insurance = 0;

                // 2. Validate passenger name
                if (name == "" || int.TryParse(name, out _))
                {
                    MessageBox.Show("Enter a valid passenger name.");
                    txtname.Focus();
                    return;
                }

                // 3. Validate age
                if (!int.TryParse(txtage.Text, out age) ||
                    age < 1 || age > 120)
                {
                    MessageBox.Show("Enter a valid age (1-120).");
                    txtage.Focus();
                    return;
                }

                // 4. Validate number of tickets
                if (!int.TryParse(txttickets.Text, out tickets) ||
                    tickets < 1 || tickets > 10)
                {
                    MessageBox.Show("Enter tickets between 1 and 10.");
                    txttickets.Focus();
                    return;
                }

                // 5. Validate baggage weight
                if (!double.TryParse(txtbaggage.Text, out baggage) ||
                    baggage < 0)
                {
                    MessageBox.Show("Enter a valid baggage weight.");
                    txtbaggage.Focus();
                    return;
                }

                // 6. Decision structure: Travel class
                if (rfirstClass.Checked)
                {
                    ticketPrice = 500;
                }
                else if (rnormalclass.Checked)
                {
                    ticketPrice = 250;
                }
                else if (rBusiness.Checked)
                {
                    ticketPrice = 400;
                }
                else
                {
                    MessageBox.Show("Please select a travel class.");
                    return;
                }

                // 7. Calculate ticket cost
                total = ticketPrice * tickets;

                // 8. Optional travel insurance ($25 per ticket)
                if (checkadd.Checked)
                {
                    insurance = 25 * tickets;
                }

                total = total + insurance;



                // 9. Display results in ListBox
                listBox1.Items.Clear();
                listBox1.Items.Add("AIRLINE BOOKING DETAILS");
                listBox1.Items.Add("----------------------------");
                listBox1.Items.Add("Passenger: " + name);
                listBox1.Items.Add("Age: " + age);
                listBox1.Items.Add("Number of Tickets: " + tickets);
                listBox1.Items.Add("Baggage Weight: " + baggage + " kg");

                listBox1.Items.Add("Travel Class: " +
                    (rfirstClass.Checked ? "First Class" :
                    rnormalclass.Checked ? "Normal Class" :
                    "Business Class"));

                listBox1.Items.Add("Ticket Price: $" + ticketPrice);
                listBox1.Items.Add("Insurance: $" + insurance);
                listBox1.Items.Add("Total Amount: $" + total);

                //MessageBox.Show("Booking calculated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtage.Clear();
            txtbaggage.Clear();
            txtname.Clear();
            txttickets.Clear();

            // Reset room selections
            rBusiness.Checked = false;
            rfirstClass.Checked = false;
            rnormalclass.Checked = false;

            // Uncheck breakfast
            checkadd.Checked = false;

            // Clear booking details
            listBox1.Items.Clear();

            // Focus on guest name
            txtname.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }

    }
    

