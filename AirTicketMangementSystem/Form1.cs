using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketMangementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();
            b.Show();
            this.Hide();

        }

        private void btnPassengerFlight_Click(object sender, EventArgs e)
        {
            Flight f = new Flight();
            f.Show();
            this.Hide();
        }

        private void btnPassengerPayment_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
            this.Hide();

        }

        private void btnPassengerRefund_Click(object sender, EventArgs e)
        {

        Refund p = new Refund();
         p.Show();
         this.Hide();
        }

        private void btnPassengerSignOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do You Want to Sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
