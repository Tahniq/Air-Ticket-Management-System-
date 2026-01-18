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
    public partial class Manage_user : Form
    {
        // This list will hold the data added by the user
        private List<User> userList = new List<User>();
        public Manage_user()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manage_user_Load(object sender, EventArgs e)
        {
            // Adding roles to the ComboBox
            cmbRole.Items.Add("Passenger");
            cmbRole.Items.Add("Employee");
            cmbRole.Items.Add("Staff");
            cmbRole.SelectedIndex = 0;  // Default role is Passenger

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string role = cmbRole.SelectedItem.ToString();  // Get selected role
            string username = txtUsername.Text;             // Get Username
            string name = txtName.Text;                     // Get Name
            string email = txtEmail.Text;                   // Get Email

            // Validate to make sure no fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Add a new user to the list
            userList.Add(new User(username, name, email, role));

            // Refresh the DataGridView to show updated data
            dgvList.DataSource = null;  // Clear existing data
            dgvList.DataSource = userList;  // Bind the list of users to the DataGridView

            // Optionally clear the input fields after adding
            txtUsername.Clear();
            txtName.Clear();
            txtEmail.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvList.SelectedRows.Count > 0)
            {
                var selectedUser = dgvList.SelectedRows[0].DataBoundItem as User;

                if (selectedUser != null)
                {
                    userList.Remove(selectedUser);  // Remove the user from the list
                    dgvList.DataSource = null;  // Clear existing data
                    dgvList.DataSource = userList;  // Refresh the DataGridView
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtUsername.Text;  // Search based on username

            // Filter the user list based on the search term
            var filteredList = userList.FindAll(user => user.Username.Contains(searchTerm));

            dgvList.DataSource = null;  // Clear existing data
            dgvList.DataSource = filteredList;  // Bind the filtered list to the DataGridView
        }
    }
    // User class to store user data
    public class User
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        // Constructor to initialize a new user
        public User(string username, string name, string email, string role)
        {
            Username = username;
            Name = name;
            Email = email;
            Role = role;
        }
    }
}

