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

namespace fileExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwriter_Click(object sender, EventArgs e)
        {
            //creating files
            StreamWriter lines;
            lines = File.CreateText("Ayan.doc");
            lines.WriteLine("class ca244");
            lines.WriteLine("ToUpper()");
            lines.WriteLine(" cimilada somalia waa kuleel");
            lines.WriteLine("ca244 waa class: ");
            // closing the read line 
            lines.Close();


        }

        private void btnreadline_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (File.Exists("Ayan.doc"))
            {
                foreach (string line in File.ReadLines("Ayan.doc"))
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("Faylku ma jiro! Fadlan marka hore 'writeline' riix.");
            }
        }


        private void btnreadallLines_Click(object sender, EventArgs e)
        {
            // Open and read the file 
            string[] allLines = File.ReadAllLines("Ayan.doc");

            // Process the file
            foreach (string line in allLines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("reading.doc"))
            {
                // delete the button 
                File.Delete("Ayan.doc");
                listBox1.Items.Clear();
                MessageBox.Show("All items from the Ayan.doc was deleted");
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("Ayan.doc"))
            {
                File.Delete("Ayan.doc");
                listBox1.Items.Clear();
                MessageBox.Show("the file was deleted successfuly");
            }
            else
            {
                MessageBox.Show("the file does not exist");
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
    
}

    

    

