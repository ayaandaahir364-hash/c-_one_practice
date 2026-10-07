using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyroll_with_overtime
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
            // create variables
            double houra_worked, payraye, grosspay;
            double validation;

            // prevent exception data convertion using try parse methods:
            if (double.TryParse(txtHours.Text, out validation) & double.TryParse(txtPayrate.Text, out validation)){
                // asing barivales
                houra_worked = double.Parse(txtHours.Text);
                payraye = double.Parse(txtPayrate.Text);

                // checking validation
                if (houra_worked > 0 & payraye > 0)

                {
                    // calculate the gross bay
                    grosspay = houra_worked * payraye;
                    lblgrospay.Text = grosspay.ToString("c");
                }
                else
                {
                    MessageBox.Show(" Hours worked  or payrate must be greater then");
                }


            }

            else
            {
                MessageBox.Show(" txthours,txtpayrate only  access");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtHours.Clear();
            txtPayrate.Text = " ";
            lblgrospay.Text = String.Empty;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
