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
    public partial class Manage_Airline_Flight : Form
    {
        private static List<Flight> flightList = new List<Flight>();

        public Manage_Airline_Flight()
        {
            InitializeComponent();
            
        }

        private void Manage_Airline_Flight_Load(object sender, EventArgs e)
        {
            txtDepartureTime.Value = DateTime.Now;
            txtDepartureTime.Enabled = true;
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            string airlineName = txtAirlineName.Text;
            string flightCode = txtFlightCode.Text;
            string from = txtFrom.Text;
            string to = txtTo.Text;
            DateTime departureTime = txtDepartureTime.Value;

           
            if (string.IsNullOrEmpty(airlineName) || string.IsNullOrEmpty(flightCode) ||
                string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }



            flightList.Add(new Flight(airlineName, flightCode, from, to, departureTime));

            txtAirlineName.Clear();
            txtFlightCode.Clear();
            txtFrom.Clear();
            txtTo.Clear();
            txtDepartureTime.Value = DateTime.Now;

            MessageBox.Show("Flight added successfully!");
        }
        


        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            string flightCode = txtFlightCode.Text;

            
            if (string.IsNullOrEmpty(flightCode))
            {
                MessageBox.Show("Please enter the Flight Code to delete.");
                return;
            }

            
            var flightToDelete = flightList.Find(f => f.FlightCode == flightCode);

            if (flightToDelete != null)
            {
                flightList.Remove(flightToDelete);
                MessageBox.Show("Flight deleted successfully!");

                txtFlightCode.Clear();
            }
            else
            {
                MessageBox.Show("Flight not found.");
            }
        }
    
        

        
        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            
            View_Booking_List viewBookingListForm = new View_Booking_List(flightList);
            viewBookingListForm.Show();
        }
      
        

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 from = new Form1();
            from.Show();
            this.Hide();
        }

        private void btnviewbooking_Click(object sender, EventArgs e)
        {
           
            View_Booking_List viewBookingListForm = new View_Booking_List(flightList);
            viewBookingListForm.Show();

        }
    }

    public class Flight
    {
        public string AirlineName { get; set; }
        public string FlightCode { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DepartureTime { get; set; }

        public Flight(string airlineName, string flightCode, string from, string to, DateTime departureTime)
        {
            AirlineName = airlineName;
            FlightCode = flightCode;
            From = from;
            To = to;
            DepartureTime = departureTime;
        }
    }
}
