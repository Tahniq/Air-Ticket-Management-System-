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
    public partial class View_Booking_List : Form
    {
        private List<Flight> flightList;
        public View_Booking_List(List<Flight> flights)
        {
            InitializeComponent();
            flightList = flights;

            // Bind the flightList to the DataGridView
            dvgFlights.DataSource = flightList;
        }

        private void View_Booking_List_Load(object sender, EventArgs e)
        {
            // Optionally, format the DataGridView columns
            dvgFlights.Columns["AirlineName"].HeaderText = "Airline Name";
            dvgFlights.Columns["FlightCode"].HeaderText = "Flight Code";
            dvgFlights.Columns["From"].HeaderText = "From";
            dvgFlights.Columns["To"].HeaderText = "To";
            dvgFlights.Columns["DepartureTime"].HeaderText = "Departure Time";

            // Optionally, adjust column width or format
            dvgFlights.AutoResizeColumns();
            dvgFlights.Columns["DepartureTime"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm"; // Format the departure time
        }

        private void btnbackview_Click(object sender, EventArgs e)
        {
            Manage_Airline_Flight manage = new Manage_Airline_Flight();
            manage.Show();
            this.Hide();
        }
    }
}
