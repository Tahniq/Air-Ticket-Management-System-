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
    public partial class Flight : Form
    {
        public Flight()
        {
            InitializeComponent();
        }

        private void Flight_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPassengerFlightInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblPassengerFlightId_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TimeSpan depTime = dtpDepartureTime.Value.TimeOfDay;
            TimeSpan arrTime = dtpArrivalTime.Value.TimeOfDay;

            if (arrTime <= depTime)
            {
                MessageBox.Show(" Arrival Time must be later than Departure Time ",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                dtpArrivalTime.Focus();
                return;
            }






            string FId = txtFId.Text;
            if (FId == "")
            {
                MessageBox.Show(" Please Input Flight ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFId.Focus();
                return;

            }
            string FNo = txtFNo.Text;
            if (FNo == "")
            {
                MessageBox.Show(" Please Input Flight No ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFNo.Focus();
                return;

            }

            
            string Or = txtOr.Text;
            if (Or == "")
            {
                MessageBox.Show(" Please Input Flight Or ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOr.Focus();
                return;

            }
            string Dstn = txtDstn.Text;
            if (Dstn == "")
            {
                MessageBox.Show(" Please Input Flight Dstn ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDstn.Focus();
                return;

            }
            string PassengerFlightDepartureTime = dtpDepartureTime.Text;
            if (PassengerFlightDepartureTime == "")
            {
                MessageBox.Show(" Please Input Flight PassengerFlightDepartureTime ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDepartureTime.Focus();
                return;

            }
            Booking b = new Booking();  
            this.Hide();
            b.Show();






        }

        private void txtFId_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void txtFId_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        
        
        private void txtOrKeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDstnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpPassengerFlightDepartureTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

