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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void authenticationLogin()
        {
            var adminBox = textBox1.Text.Trim();
            var passBox = textBox2.Text.Trim();
            if (String.Equals(adminBox,"admin") && String.Equals(passBox,"admin"))
            {
                MessageBox.Show("Credentials Approved. Welcome!","Login Verification");
                MainPanelAdmin admin = new MainPanelAdmin();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrent Input. Please Try Again!","Login Verification");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            authenticationLogin();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            cs.Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
