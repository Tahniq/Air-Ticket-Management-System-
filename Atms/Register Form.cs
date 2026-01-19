using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Atms
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

        }

        private void txtRegAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegSubmit_Click(object sender, EventArgs e)
        {
            string name = txtRegName.Text;
            if (name == "")
            {
                MessageBox.Show("Enter Name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegName.Focus();
                return;
            }

            string email = txtRegEmail.Text;
            if (email == "" || !email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Invalid Email. Either @ or .com is Missing ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegEmail.Focus();
                return;
            }

            string mobNo = txtRegMobileNumber.Text;
            if (mobNo == "" || mobNo.Length < 11)
            {
                MessageBox.Show("Invalid Mobile Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegMobileNumber.Focus();
                return;
            }

            string address = txtRegAddress.Text;
            if (address == "")
            {
                MessageBox.Show("Enter Address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegAddress.Focus();
                return;
            }

            DateTime dob;
            try
            {
                dob = DateTime.Parse(txtDateofBirth.Text);  
            }
            catch
            {
                MessageBox.Show("Enter Date of Birth  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDateofBirth.Focus();
                return;
            }

            string gender = "";
            if (radiomale.Checked)
            {
                gender = "Male";
            }
            else if (radiofemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Please select a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string pass = txtRegPassword.Text;
            if (pass == "" || pass.Length < 3)
            {
                MessageBox.Show("Enter Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegPassword.Focus();
                return;
            }

            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 from = new Form1();
            from.Show();
            this.Hide();
        }

        private void btnEye_MouseHover(object sender, EventArgs e)
        {
            txtRegPassword.UseSystemPasswordChar = false;
        }

        private void btnEye_MouseLeave(object sender, EventArgs e)
        {
            txtRegPassword.UseSystemPasswordChar = true;
        }

        private void txtDateofBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void linkhaveaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 from = new Form1();
            from.Show();
            this.Hide();
        }
    }
}
