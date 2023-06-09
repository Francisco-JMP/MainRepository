using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT488_Weight_Conversion
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

        private void kgsCalculation(object sender, EventArgs e)
        {
            double outputValue = 0;
            bool isDouble = false;

            isDouble = double.TryParse(textBox1.Text, out outputValue);

            if (!isDouble)
            {
                MessageBox.Show("Type a number in the text boxes");
            }
            else
            {

                double pounds;
                pounds = double.Parse(textBox1.Text);
                double kgsWeight = pounds * 0.45359237;

                textBox2.Text = kgsWeight.ToString("#.000");
            }
        }

        private void lbsCalculation(object sender, EventArgs e)
        {

            double outputValue = 0;
            bool isDouble = false;

            isDouble = double.TryParse(textBox3.Text, out outputValue);

            if (!isDouble)
            {
                MessageBox.Show("Type a number in the text boxes");
            }
            else
            {

                double kilograms;
                kilograms = double.Parse(textBox3.Text);
                double lbsWeight = kilograms * 2.20462262185;

                textBox4.Text = lbsWeight.ToString("#.000");

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
