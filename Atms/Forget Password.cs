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
    public partial class Forget_Password : Form
    {
        public Forget_Password()
        {
            InitializeComponent();
        }

        private void Forget_Password_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnnewsubmit_Click(object sender, EventArgs e)
        {
            string email = txtforgotemail.Text;
            if (email == "" || !email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("Invalid Email  Either @ or .com is Missing ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtforgotemail.Focus();
                return;
            }
            string password = txtnewpassword.Text;
            if (password == "" || password.Length < 3)
            {
                MessageBox.Show("Invalid Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnewpassword.Focus();
                return;
            }

            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();

        }
    }
}
