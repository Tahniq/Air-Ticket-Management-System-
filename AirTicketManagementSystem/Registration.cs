using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AirTicketManagementSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
              string name = txtName.Text;
            if (name == "")
            {
                MessageBox.Show("Invalid Name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            string pass = txtPass.Text;
            if (pass == "" || pass.Length < 3)
            {
                MessageBox.Show("Invalid Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            DateTime dob;
            try
            {
                dob = DateTime.Parse(dtpDob.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Date of Birth  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDob.Focus();
                return;
            }
            string address = txtAdd.Text;
            if (address == "")
            {
                MessageBox.Show("Invalid  Address ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd.Focus();
                return;
            }

            string email = txtEmail.Text;
            if (email == "" || !email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Invalid Email  Either @ or .com is Missing ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            string MobNo = txtMobNo.Text;
            if (MobNo == "" || MobNo.Length < 11)

            {
                MessageBox.Show("Invalid Mobile Number  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobNo.Focus();
                return;
            }
            //  DEKSTOP - OKU0PH5
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=localhost/SQLEXPRESS;Initial Catalog = Atms;Integrated Security =True;Encrypt=False;";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"insert into AirFareUserInfo values('{name}','{MobNo}', '{dob}', '{address}', '{email}','{pass}') ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful");



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEye_MouseHover(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void btnEye_MouseLeave(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtMobNo_TextChanged(object sender, EventArgs e)
        {

        }

    }
    
}
