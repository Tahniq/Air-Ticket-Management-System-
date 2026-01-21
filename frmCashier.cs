//Code for using SQL// 
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
//using System.Data.SqlClient;

namespace AirTicketManagementSystem
{
    public partial class CashierDashboard : Form
    {
        //string connectionString = "Data Source=.;Initial Catalog=AirTicketDB;Integrated Security=True";

        public CashierDashboard()
        {
            InitializeComponent();
            rbAll.Checked = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchBookingID.Text == "")
            {
                MessageBox.Show("Please enter Booking ID");
                return;
            }

            //SqlConnection con = new SqlConnection(connectionString);

            //SqlDataAdapter da = new SqlDataAdapter(
            //    "SELECT BookingID, PassengerName, FlightNo, TravelDate, TotalAmount, PaymentStatus " +
            //    "FROM Bookings WHERE BookingID = '" + txtSearchBookingID.Text + "'", con);

            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //if (dt.Rows.Count == 0)
            //{
            //    MessageBox.Show("No booking found.");
            //}

            //dgvBookings.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbAll.Checked)
            //    LoadAllBookings();
        }

        private void dgvBookingDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            //LoadAllBookings();
            //LoadCashierProfile();
        }

        //private void LoadAllBookings()
        //{
        //    SqlConnection con = new SqlConnection(connectionString);

        //    SqlDataAdapter da = new SqlDataAdapter(
        //        "SELECT BookingID, PassengerName, FlightNo, TravelDate, TotalAmount, PaymentStatus FROM Bookings",
        //        con);

        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    dgvBookings.DataSource = dt;
        //}

        //private void LoadCashierProfile()
        //{
        //    SqlConnection con = new SqlConnection(connectionString);

        //    SqlCommand cmd = new SqlCommand(
        //        "SELECT * FROM Cashier WHERE CashierID = 1", con);

        //    con.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();

        //    if (dr.Read())
        //    {
        //        txtCashierID.Text = dr["CashierID"].ToString();
        //        txtName.Text = dr["Name"].ToString();
        //        txtEmail.Text = dr["Email"].ToString();
        //        txtPhone.Text = dr["Phone"].ToString();
        //    }

        //    con.Close();
        //}

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblSeatNoValue_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();

            //SqlCommand cmdPayment = new SqlCommand(
            //    "INSERT INTO Payments (BookingID, PaymentMethod, PaymentDate, Amount) VALUES ('"
            //    + txtBookingID.Text + "', '"
            //    + cmbPaymentMethod.Text + "', GETDATE(), '"
            //    + txtAmount.Text + "')", con);

            //cmdPayment.ExecuteNonQuery();

            //SqlCommand cmdUpdate = new SqlCommand(
            //    "UPDATE Bookings SET PaymentStatus='Paid' WHERE BookingID='"
            //    + txtBookingID.Text + "'", con);

            //cmdUpdate.ExecuteNonQuery();

            //con.Close();

            MessageBox.Show("Payment confirmed successfully.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            rtbReceipt.Clear();

            rtbReceipt.Text =
            "---------------- PAYMENT RECEIPT ----------------\n" +
            "Booking ID:      " + txtBookingID.Text + "\n" +
            "Passenger Name:  " + txtPassengerName.Text + "\n" +
            "Payment Method:  " + cmbPaymentMethod.Text + "\n" +
            "Amount Paid:     " + txtAmount.Text + "\n" +
            "Payment Date:    " + DateTime.Now.ToString("dd-MMM-yyyy") + "\n" +
            "-------------------------------------------------\n";
        }

        private void tabPayment_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(
                rtbReceipt.Text,
                new Font("Consolas", 11),
                Brushes.Black,
                new PointF(50, 50)
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookings.Rows[e.RowIndex];

                lblBookingIDValue.Text = row.Cells["BookingID"].Value.ToString();
                lblPassengerNameValue.Text = row.Cells["PassengerName"].Value.ToString();
                lblFlightNoValue.Text = row.Cells["FlightNo"].Value.ToString();
                lblTravelDateValue.Text = Convert.ToDateTime(
                    row.Cells["TravelDate"].Value).ToString("dd-MMM-yyyy");
                lblTotalAmountValue.Text = row.Cells["TotalAmount"].Value.ToString();
                lblPaymentStatusValue.Text = row.Cells["PaymentStatus"].Value.ToString();

                txtBookingID.Text = row.Cells["BookingID"].Value.ToString();
                txtPassengerName.Text = row.Cells["PassengerName"].Value.ToString();
                txtAmount.Text = row.Cells["TotalAmount"].Value.ToString();
            }
        }

        private void tabBookings_Click(object sender, EventArgs e)
        {

        }

        private void rbPaid_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbPaid.Checked)
            //    LoadFilteredBookings("Paid");
        }

        private void rbUnpaid_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbUnpaid.Checked)
            //    LoadFilteredBookings("Unpaid");
        }

        //private void LoadFilteredBookings(string status)
        //{
        //    SqlConnection con = new SqlConnection(connectionString);

        //    SqlDataAdapter da = new SqlDataAdapter(
        //        "SELECT BookingID, PassengerName, FlightNo, TravelDate, TotalAmount, PaymentStatus " +
        //        "FROM Bookings WHERE PaymentStatus='" + status + "'", con);

        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    dgvBookings.DataSource = dt;
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchBookingID.Clear();
            //rbAll.Checked = true;
            //LoadAllBookings();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            //SqlConnection con = new SqlConnection(connectionString);

            //SqlCommand cmd = new SqlCommand(
            //    "UPDATE Cashier SET Name='" + txtName.Text +
            //    "', Email='" + txtEmail.Text +
            //    "', Phone='" + txtPhone.Text +
            //    "' WHERE CashierID='" + txtCashierID.Text + "'", con);

            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();

            MessageBox.Show("Profile updated successfully.");
        }
    }
}
