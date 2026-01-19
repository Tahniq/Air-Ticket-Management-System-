using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtloguser.Text;
            if (email == "" || !email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Invalid Email  Either @ or .com is Missing ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtloguser.Focus();
                return;
            }
            string password = txtlogpass.Text;
            if (password == "" || password.Length < 3)
            {
                MessageBox.Show("Invalid Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlogpass.Focus();
                return;
            }
            Manage_user manage = new Manage_user();
            manage.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register_Form register = new Register_Form();   
            register.Show();
            this.Hide();
        }

        private void txtloguser_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkforgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget_Password forgotpass = new Forget_Password();
            forgotpass.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About_Us about = new About_Us();
            about.Show();
            this.Hide();
        }
    }
}
