using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayOfWeekTextBox_TextChanged(object sender, EventArgs e)
        {
            // create  variables
            

        }

        private void dayOfWeekTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DayOfMonthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            DayOfMonthTextBox.Clear();
            txtyear.Clear();
            lblDateOutPut.Text = " ";
        }

        private void showDate_Click(object sender, EventArgs e)
        {
            string Dayofweek, month, dayofmonth, year, showDate;

            Dayofweek = dayOfWeekTextBox.Text;
            month = monthTextBox.Text;
            dayofmonth = DayOfMonthTextBox.Text;
            year = txtyear.Text;


            //process 
            showDate = Dayofweek + " " + month + " " + dayofmonth + " " + year;


            // display
            lblDateOutPut.Text = showDate;

            // clear


        }
    }
}
