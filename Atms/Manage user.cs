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
            
            cmbRole.Items.Add("Passenger");
            cmbRole.Items.Add("Employee");
            cmbRole.Items.Add("Staff");
            cmbRole.SelectedIndex = 0;  

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string role = cmbRole.SelectedItem.ToString();  
            string username = txtUsername.Text;             
            string name = txtName.Text;                    
            string email = txtEmail.Text;                   

           
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
            userList.Add(new User(username, name, email, role));

           
            dgvList.DataSource = null;  
            dgvList.DataSource = userList; 

            
            txtUsername.Clear();
            txtName.Clear();
            txtEmail.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dgvList.SelectedRows.Count > 0)
            {
                var selectedUser = dgvList.SelectedRows[0].DataBoundItem as User;

                if (selectedUser != null)
                {
                    userList.Remove(selectedUser);
                    dgvList.DataSource = null;  
                    dgvList.DataSource = userList; 
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtUsername.Text;  

           
            var filteredList = userList.FindAll(user => user.Username.Contains(searchTerm));

            dgvList.DataSource = null; 
            dgvList.DataSource = filteredList; 
        }
    }
    
    public class User
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public User(string username, string name, string email, string role)
        {
            Username = username;
            Name = name;
            Email = email;
            Role = role;
        }
    }
}

