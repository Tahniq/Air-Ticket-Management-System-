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
        // List to hold the added airline/flight data
        private List<Flight> flightList = new List<Flight>();

        public Manage_Airline_Flight()
        {
            InitializeComponent();
        }

        private void Manage_Airline_Flight_Load(object sender, EventArgs e)
        {
            // Set default departure time
            txtDepartureTime.Value = DateTime.Now;

            // Manually adding columns for the DataGridView
            dgvFlightList.Columns.Add("colAirlineName", "Airline Name");
            dgvFlightList.Columns.Add("colFlightCode", "Flight Code");
            dgvFlightList.Columns.Add("colFrom", "From");
            dgvFlightList.Columns.Add("colTo", "To");
            dgvFlightList.Columns.Add("colDepartureTime", "Departure Time");

            // Bind DataGridView columns to the Flight class properties
            dgvFlightList.Columns["colAirlineName"].DataPropertyName = "AirlineName";
            dgvFlightList.Columns["colFlightCode"].DataPropertyName = "FlightCode";
            dgvFlightList.Columns["colFrom"].DataPropertyName = "From";
            dgvFlightList.Columns["colTo"].DataPropertyName = "To";
            dgvFlightList.Columns["colDepartureTime"].DataPropertyName = "DepartureTime";
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            string airlineName = txtAirlineName.Text;     // Get Airline Name
            string flightCode = txtFlightCode.Text;       // Get Flight Code
            string from = txtFrom.Text;                   // Get From (Source)
            string to = txtTo.Text;                       // Get To (Destination)
            DateTime departureTime = txtDepartureTime.Value; // Get Departure Time

            // Validate to make sure no fields are empty
            if (string.IsNullOrEmpty(airlineName) || string.IsNullOrEmpty(flightCode) ||
                string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Add new flight to the list
            flightList.Add(new Flight(airlineName, flightCode, from, to, departureTime));

            // Refresh the DataGridView to show updated data
            dgvFlightList.DataSource = null;  // Clear existing data
            dgvFlightList.DataSource = flightList;  // Bind the flight list to DataGridView

            // Optionally clear input fields after adding
            txtAirlineName.Clear();
            txtFlightCode.Clear();
            txtFrom.Clear();
            txtTo.Clear();
            txtDepartureTime.Value = DateTime.Now;
        }

        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in DataGridView
            if (dgvFlightList.SelectedRows.Count > 0)
            {
                var selectedFlight = dgvFlightList.SelectedRows[0].DataBoundItem as Flight;

                // Make sure the selected flight is not null
                if (selectedFlight != null)
                {
                    // Update flight details with the values from the TextBoxes
                    selectedFlight.AirlineName = txtAirlineName.Text;
                    selectedFlight.FlightCode = txtFlightCode.Text;
                    selectedFlight.From = txtFrom.Text;
                    selectedFlight.To = txtTo.Text;
                    selectedFlight.DepartureTime = txtDepartureTime.Value;

                    // Refresh the DataGridView to show updated data
                    dgvFlightList.DataSource = null;  // Clear existing data
                    dgvFlightList.DataSource = flightList;  // Bind the updated list to DataGridView

                    // Optionally, clear the input fields after updating
                    txtAirlineName.Clear();
                    txtFlightCode.Clear();
                    txtFrom.Clear();
                    txtTo.Clear();
                    txtDepartureTime.Value = DateTime.Now;
                }
            }

            else
            {
                // Show message if no row is selected for update
                MessageBox.Show("Please select a flight to update.");
            }

        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvFlightList.SelectedRows.Count > 0)
            {
                var selectedFlight = dgvFlightList.SelectedRows[0].DataBoundItem as Flight;

                if (selectedFlight != null)
                {
                    flightList.Remove(selectedFlight);  // Remove the flight from the list
                    dgvFlightList.DataSource = null;  // Clear existing data
                    dgvFlightList.DataSource = flightList;  // Refresh the DataGridView
                }
            }
            else
            {
                MessageBox.Show("Please select a flight to delete.");
            }
        }
        

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            string searchTerm = txtFlightCode.Text;  // Search based on flight code

            // Filter the flight list based on the search term
            var filteredList = flightList.FindAll(flight => flight.FlightCode.Contains(searchTerm));

            dgvFlightList.DataSource = null;  // Clear existing data
            dgvFlightList.DataSource = filteredList;  // Bind the filtered list to DataGridView
        }

    }
    
    public class Flight
    {
        public string AirlineName { get; set; }
        public string FlightCode { get; set; }
        public string From { get; set; }  // Changed from Source to From
        public string To { get; set; }    // Changed from Destination to To
        public DateTime DepartureTime { get; set; }

        // Constructor to initialize a new flight
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
