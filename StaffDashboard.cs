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
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightDetails fd = new FlightDetails();
            this.Close();
            fd.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.Show();
            

        }
    }
}
