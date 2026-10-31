using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // creating varables :

            string guestName = txtname.Text;
            int age, nights, guests;

            bool isAgeValid = int.TryParse(txtage.Text, out age);
            bool isNightsValid = int.TryParse(txtNumberofnight.Text, out nights);
            bool isGuestsValid = int.TryParse(txtnumberofGuest.Text, out guests);
            try
            {
                if (string.IsNullOrWhiteSpace(guestName))
                {
                    MessageBox.Show("Enter guest name!");
                }
                else if (!isAgeValid || age < 18 || age > 90)
                {
                    MessageBox.Show("Age must be between 18 and 90!");
                }
                else if (!isNightsValid || nights < 1 || nights > 30)
                {
                    MessageBox.Show("Nights must be between 1 and 30!");
                }
                else if (!isGuestsValid || guests < 1 || guests > 6)
                {
                    MessageBox.Show("Guests must be between 1 and 6!");
                }
                else if (!rStandard.Checked && !rNormal.Checked && !rHight.Checked)
                {
                    MessageBox.Show("Select a room type!");
                }
                else
                {
                    string roomType = "";
                    double rate = 0;
                    int maxCapacity = 0;

                    if (rStandard.Checked)
                    {
                        roomType = "Standard Room";
                        maxCapacity = 2;
                    }
                    else if (rNormal.Checked)
                    {
                        roomType = "Normal Room";
                        maxCapacity = 4;
                    }
                    else if (rHight.Checked)
                    {
                        roomType = "High Room";
                        maxCapacity = 6;
                    }

                    switch (roomType)
                    {
                        case "Standard Room":
                            rate = 50;
                            break;
                        case "Normal Room":
                            rate = 80;
                            break;
                        case "High Room":
                            rate = 130;
                            break;
                    }

                    bool approved = guests <= maxCapacity;

                    if (!approved)
                    {
                        listBox1.Items.Add("BOOKING REJECTED");
                        listBox1.Items.Add("Guest: " + guestName);
                        listBox1.Items.Add("Room: " + roomType);
                        listBox1.Items.Add("Maximum Guests: " + maxCapacity);
                        listBox1.Items.Add("Guests: " + guests);
                        MessageBox.Show("Too many guests for this room!");
                    }
                    else
                    {
                        double baseCost = rate * nights;
                        double stayDiscount = 0;
                        double seniorDiscount = 0;
                        double breakfastCost = 0;
                        double serviceSurcharge = 0;

                        if (nights >= 10)
                            stayDiscount = baseCost * 0.12;
                        else if (nights >= 5)
                            stayDiscount = baseCost * 0.05;

                        if (age >= 60)
                            seniorDiscount = baseCost * 0.05;

                        if (checkbreakfast.Checked)
                            breakfastCost = 10 * guests * nights;

                        double subtotal = baseCost - stayDiscount
                                          - seniorDiscount + breakfastCost;

                        if (guests > 4)
                            serviceSurcharge = subtotal * 0.05;

                        double finalCost = subtotal + serviceSurcharge;

                        listBox1.Items.Add("----- BOOKING SUMMARY -----");
                        listBox1.Items.Add("Guest: " + guestName);
                        listBox1.Items.Add("Age: " + age);
                        listBox1.Items.Add("Nights: " + nights);
                        listBox1.Items.Add("Guests: " + guests);
                        listBox1.Items.Add("Room: " + roomType);
                        listBox1.Items.Add("Status: Approved");
                       listBox1.Items.Add("Rate: $" + rate.ToString("F2"));
                        listBox1.Items.Add("Base Cost: $" + baseCost.ToString("F2"));
                       listBox1.Items.Add("Stay Discount: $" + stayDiscount.ToString("F2"));
                        listBox1.Items.Add("Senior Discount: $" + seniorDiscount.ToString("F2"));
                        listBox1.Items.Add("Breakfast: $" + breakfastCost.ToString("F2"));
                       listBox1.Items.Add("Service Surcharge: $" + serviceSurcharge.ToString("F2"));
                        listBox1.Items.Add("---------------------------");
                        listBox1.Items.Add("FINAL COST: $" + finalCost.ToString("F2"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btbClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtname.Clear();
            txtage.Clear();
            txtNumberofnight.Clear();
            txtnumberofGuest.Clear();

            // Reset room selections
            rStandard.Checked = false;
            rNormal.Checked = false;
            rHight.Checked = false;

            // Uncheck breakfast
            checkbreakfast.Checked = false;

            // Clear booking details
            listBox1.Items.Clear();

            // Focus on guest name
           txtname.Focus();

        }

        private void btbExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}


