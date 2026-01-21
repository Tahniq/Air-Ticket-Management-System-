using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string email = txtEmail.Text;
            if (email == "" || !email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Invalid Email  Either @ or .com is Missing ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            string pass = txtPass.Text;
            if (pass == "" || pass.Length < 3)
            {
                MessageBox.Show("Invalid Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            } 

            StaffDashboard sd = new StaffDashboard();
            
            this.Hide();
            sd.Show();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration r = new Registration();
            r.Show();
        }
    }
}
