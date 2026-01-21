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
    public partial class Flights : Form
    {

        string flightTime;
        decimal fare;
        int seats;

        public Flights(string time, decimal fareAmount, int seatCount)
        {
            InitializeComponent();
            flightTime = time;
            fare = fareAmount;
            seats = seatCount;
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            decimal totalFare = fare * seats;
            dgvF.Rows.Add(flightTime, seats, fare, totalFare);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
