using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatingSystemHotel
{
    public partial class Customer : Form
    {
        String nameField,addressField, contactField, qualityFood, friendlyStaff,restClean,orderAccuracy,restAmbience,valueMoney;
        DateTime dateAndTime = DateTime.Now;
        string[] rateText;
        public void DisplayTime()
        {
            label5.Text = DateTime.Now.ToString("dd - MMMM - yyyy");
        }
        public Customer()
        {
            InitializeComponent();
            DisplayTime();
        }
        private void FormDetails()
        {
            nameField = textBox1.Text;
            addressField = textBox2.Text;
            contactField = textBox3.Text;
            qualityFood = groupFoodQuality.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            friendlyStaff = groupFriendlyStaff.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            restClean = groupClean.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            orderAccuracy = groupAccuracy.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            restAmbience = groupAmbience.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            valueMoney = groupValueMoney.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            string[] cusDetails = { nameField,addressField,contactField,qualityFood,friendlyStaff,restClean,orderAccuracy,restAmbience,valueMoney,dateAndTime.ToString()};
            rateText = cusDetails;
            for (int i = 3; i < rateText.Length; i++)
            {
                if (Equals(rateText[i], "Excellent"))
                {
                    rateText[i] = "4";
                }
                if (Equals(rateText[i], "Good"))
                {
                    rateText[i] = "3";
                }
                if (Equals(rateText[i], "Average"))
                {
                    rateText[i] = "2";
                }
                if (Equals(rateText[i], "Dissatisfied"))
                {
                    rateText[i] = "1";
                }
            }
        }
        private void CustomerDetails(string[] cusDetails)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("Records.csv", true))
                {
                    foreach(var cus in cusDetails)
                    {
                        file.Write(cus + ",");
                    }
                    file.Write("\n");
                    file.Close();
                }
                MessageBox.Show("Feedback has been saved!", "Feedback Confirmation");
            }
            catch(Exception e)
            {
                MessageBox.Show(e + "Exception");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String readRecordFile = System.IO.File.ReadAllText("Records.csv");
            String readCustomerFile = System.IO.File.ReadAllText("Customer.csv");

            MessageBox.Show(readRecordFile + readCustomerFile, "Customer Details");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Customer.csv");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FormDetails();
            CustomerDetails(rateText);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
