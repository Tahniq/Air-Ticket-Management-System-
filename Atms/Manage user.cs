using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Atms
{
    public partial class Manage_user : Form
    {
        
        private List<User> userList = new List<User>();

        public Manage_user()
        {
            InitializeComponent();
        }

        
        private void Manage_user_Load(object sender, EventArgs e)
        {
            
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Manage_Airline_Flight flight = new Manage_Airline_Flight();
            flight.Show();
            this.Hide();


        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
          
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }

    
    public class User
    {
        public string Username { get; set; }

        public User(string username)
        {
            Username = username;
        }
    }
}
