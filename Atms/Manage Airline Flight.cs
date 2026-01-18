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
        
        private List<Flight> flightList = new List<Flight>();

        public Manage_Airline_Flight()
        {
            InitializeComponent();
        }

        private void Manage_Airline_Flight_Load(object sender, EventArgs e)
        {
            
            txtDepartureTime.Value = DateTime.Now;

            
            dgvFlightList.Columns.Add("colAirlineName", "Airline Name");
            dgvFlightList.Columns.Add("colFlightCode", "Flight Code");
            dgvFlightList.Columns.Add("colFrom", "From");
            dgvFlightList.Columns.Add("colTo", "To");
            dgvFlightList.Columns.Add("colDepartureTime", "Departure Time");

            
            dgvFlightList.Columns["colAirlineName"].DataPropertyName = "AirlineName";
            dgvFlightList.Columns["colFlightCode"].DataPropertyName = "FlightCode";
            dgvFlightList.Columns["colFrom"].DataPropertyName = "From";
            dgvFlightList.Columns["colTo"].DataPropertyName = "To";
            dgvFlightList.Columns["colDepartureTime"].DataPropertyName = "DepartureTime";
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

            
            dgvFlightList.DataSource = null;  
            dgvFlightList.DataSource = flightList;  

            
            txtAirlineName.Clear();
            txtFlightCode.Clear();
            txtFrom.Clear();
            txtTo.Clear();
            txtDepartureTime.Value = DateTime.Now;
        }

        private void btnUpdateFlight_Click(object sender, EventArgs e)
        {

            if (dgvFlightList.SelectedRows.Count > 0)
            {
                var selectedFlight = dgvFlightList.SelectedRows[0].DataBoundItem as Flight;

                
                if (selectedFlight != null)
                {
                    
                    selectedFlight.AirlineName = txtAirlineName.Text;
                    selectedFlight.FlightCode = txtFlightCode.Text;
                    selectedFlight.From = txtFrom.Text;
                    selectedFlight.To = txtTo.Text;
                    selectedFlight.DepartureTime = txtDepartureTime.Value;

                    
                    dgvFlightList.DataSource = null;  
                    dgvFlightList.DataSource = flightList;  

                    
                    txtAirlineName.Clear();
                    txtFlightCode.Clear();
                    txtFrom.Clear();
                    txtTo.Clear();
                    txtDepartureTime.Value = DateTime.Now;
                }
            }

            else
            {
               
                MessageBox.Show("Please select a flight to update.");
            }

        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            
            if (dgvFlightList.SelectedRows.Count > 0)
            {
                var selectedFlight = dgvFlightList.SelectedRows[0].DataBoundItem as Flight;

                if (selectedFlight != null)
                {
                    flightList.Remove(selectedFlight);  
                    dgvFlightList.DataSource = null; 
                    dgvFlightList.DataSource = flightList; 
                }
            }
            else
            {
                MessageBox.Show("Please select a flight to delete.");
            }
        }
        

        private void btnSearchFlight_Click(object sender, EventArgs e)
        {
            string searchTerm = txtFlightCode.Text; 

            
            var filteredList = flightList.FindAll(flight => flight.FlightCode.Contains(searchTerm));

            dgvFlightList.DataSource = null; 
            dgvFlightList.DataSource = filteredList;  
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
