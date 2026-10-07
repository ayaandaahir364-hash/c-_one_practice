using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating variables
            double salary, years;
            try
            {
                salary = double.Parse(txtsalary.Text);
                years = double.Parse(txtyear.Text);

                // check qualification
                if (salary > 300)
                {
                    {
                        MessageBox.Show("Qualify on load");
                    }
                    // checking years
                    if (years >= 2) ;
                    else
                    {
                        MessageBox.Show("waa laguu ogolyahy deen");
                    }
                }
            }
            catch
            {
               
            }
        }
    }
}
