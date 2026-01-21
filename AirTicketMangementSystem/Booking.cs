using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketMangementSystem
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void txtBId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPassengerBookingAdd_Click(object sender, EventArgs e)
        {
            string BId = txtBId.Text;
            if (BId == "")
            {
                MessageBox.Show(" Please Input Booking ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBId.Focus();
                return;

            }

            string PId = txtPId.Text;
            if (PId == "")
            {
                MessageBox.Show(" Please Input Booking ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPId.Focus();
                return;

            }

            string Dst = txtDst.Text;
            if (Dst == "")
            {
                MessageBox.Show(" Please Input Booking Destination ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDst.Focus();
                return;

            }
            Payment p = new Payment();
            this.Hide();
            p.Show();

        }

        private void btnPassengerBookingDelete_Click(object sender, EventArgs e)
        {
            
            Flight f = new Flight();
            this.Hide();
            f.Show();
        }

        private void pnlPassengerBookingManage_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void lblPassengerBookingStatus_Click(object sender, EventArgs e)
        {

        }

        private void txtDst_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassengerBookingInfo_Click(object sender, EventArgs e)
        {

        }

        private void txtBIdKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtPIdKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtDstKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
