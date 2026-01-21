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
    public partial class FlightDetails : Form
    {
        public FlightDetails()
        {
            InitializeComponent();
        }

        private void FlightDetails_Load(object sender, EventArgs e)
        {
            dgvFd.Columns.Add("Route", "Route");
            dgvFd.Columns.Add("Seats", "Seats");
            dgvFd.Columns.Add("Fare", "Fare (BDT)");
            dgvFd.Columns.Add("TotalFare", "Total Fare (BDT)");
            dgvFd.Columns.Add("Status", "Status");


        }


        private void cmbDprt_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbArvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {




            {
                // Validation: check selections first
                if (cmbDprt.SelectedIndex == -1 || cmbArvl.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select both Departure and Arrival",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbDprt.Text == cmbArvl.Text)
                {
                    MessageBox.Show("Departure and Arrival cannot be same!",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbArvl.Focus();
                    cmbArvl.SelectedIndex = -1;
                    return;
                }

                string route = cmbDprt.Text + " → " + cmbArvl.Text;
                bool routeExists = false;
                decimal fare = 5000; // fare per seat

                // Check if route already exists in dgvFd
                foreach (DataGridViewRow row in dgvFd.Rows)
                {
                    if (row.Cells["Route"].Value != null &&
                        row.Cells["Route"].Value.ToString() == route)
                    {
                        // Increment seats by 1
                        int oldSeats = Convert.ToInt32(row.Cells["Seats"].Value);
                        oldSeats += 1;
                        row.Cells["Seats"].Value = oldSeats;

                        // Update total fare
                        row.Cells["TotalFare"].Value = oldSeats * fare;

                        routeExists = true;
                        break;
                    }
                }

                // If route does not exist, add new row with seats, fare, total fare
                if (!routeExists)
                {
                    int seats = 1;
                    decimal totalFare = seats * fare;
                    dgvFd.Rows.Add(route, seats, fare, totalFare, "Pending");
                }

                // Clear selections for next input
                cmbDprt.SelectedIndex = -1;
                cmbArvl.SelectedIndex = -1;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbDprt.SelectedIndex == -1 || cmbArvl.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both Departure and Arrival before proceeding.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // stop further execution
            }
            BookTicket bt = new BookTicket();
            this.Hide();
            bt.Show();
        }
    }
}
