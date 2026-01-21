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
    public partial class Refund : Form
    {
        public Refund()
        {
            InitializeComponent();
        }

        private void btnPassengerRefundPay_Click(object sender, EventArgs e)
        {
         
            string PId = txtPId.Text;
            if (PId == "")
            {
                MessageBox.Show(" Please Input Payment Id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPId.Focus();
                return;

            }
            string RId = txtRId.Text;
            if (RId == "")
            {
                MessageBox.Show(" Please Input Payment Amaount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRId.Focus();
                return;

            }
            string RA = txtRA.Text;
            if (RA == "")
            {
                MessageBox.Show(" Please Input Payment Amaount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRA.Focus();
                return;

            }
            // Show success message
            MessageBox.Show(
                "Refund request accepted",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Open Refund form
            Refund r = new Refund();
            this.Hide();
            r.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void txtPIdKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtRIdKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtRAKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void lblPIdClick(object sender, EventArgs e)
        {

        }
    }
}
