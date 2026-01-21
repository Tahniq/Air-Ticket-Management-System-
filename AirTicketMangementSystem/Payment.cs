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
    public partial class Payment : Form
    {
        internal static string SavedPId;

        public Payment()
        {
            InitializeComponent();
        }

        private void btnPassengerPaymentPay_Click(object sender, EventArgs e)
        {
            string PAId = txtPAId.Text;
            if (PAId == "")
            {
                MessageBox.Show(" Please Input Payment Id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPAId.Focus();
                return;

            }
            string PId = txtPId.Text;
            if (PId == "")
            {
                MessageBox.Show(" Please Input Passenger Id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPId.Focus();
                return;

            }
            string PA = txtPA.Text;
            if (PA == "")
            {
                MessageBox.Show(" Please Input Payment Amaount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPA.Focus();
                return;

            }




            Refund r = new Refund();
            this.Hide();
            r.Show();
        }

        private void pnlPassengerPaymentManage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPAId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPAIdKeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPAKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void lblPId_Click(object sender, EventArgs e)
        {

        }
    }
}
