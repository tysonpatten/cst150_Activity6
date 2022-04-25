// tyson patten
// cst 150
// Topic 1 // Activity 2
// this is my own work


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {


            // try catch block performing F to C conversion, and rounding to 3 decimal places
            try
            {
                double fahrenheit = double.Parse(textBox1.Text);
                double celsius = (fahrenheit - 32) * 5 / 9;
                textBox2.Text = celsius.ToString("n3");
                textBox1.Text = fahrenheit.ToString("n3");
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number");
            }


        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
