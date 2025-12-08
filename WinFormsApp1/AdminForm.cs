using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {

        private string connectionString = "server=localhost;user=root;password=3PYYWCCE;database=xenstathatos_clientDB";
        private List<Client> clientList = new List<Client>();
        private int editingRowIndex = -1;

        public AdminForm()
        {
            InitializeComponent();
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.MultiSelect = false;
            dgvClients.AutoGenerateColumns = false;

            LoadClientsFromDatabase();
        }



        private void LoadClientsFromDatabase()
        {
            clientList.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ClientID, ClientName, ClientAddress, ClientPhone FROM Clients";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clientList.Add(new Client
                            {
                                ClientID = reader["ClientID"].ToString(),
                                ClientName = reader["ClientName"].ToString(),
                                ClientAddress = reader["ClientAddress"].ToString(),
                                ClientPhone = reader["ClientPhone"].ToString()
                            });
                        }
                    }
                }
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
        }

        private void AddClientToDatabase(Client client)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Clients (ClientID, ClientName, ClientAddress, ClientPhone) 
                                     VALUES (@id, @name, @address, @phone)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", client.ClientID);
                    cmd.Parameters.AddWithValue("@name", client.ClientName);
                    cmd.Parameters.AddWithValue("@address", client.ClientAddress);
                    cmd.Parameters.AddWithValue("@phone", client.ClientPhone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding client: " + ex.Message);
            }
        }

        private void UpdateClientInDatabase(Client client)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Clients SET 
                                     ClientName=@name, ClientAddress=@address, ClientPhone=@phone 
                                     WHERE ClientID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", client.ClientID);
                    cmd.Parameters.AddWithValue("@name", client.ClientName);
                    cmd.Parameters.AddWithValue("@address", client.ClientAddress);
                    cmd.Parameters.AddWithValue("@phone", client.ClientPhone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating client: " + ex.Message);
            }
        }

        private void DeleteClientFromDatabase(string clientId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Clients WHERE ClientID=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", clientId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting client: " + ex.Message);
            }
        }



        private void LoadGrid()
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = clientList;
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editingRowIndex = e.RowIndex;
                txtClientID.Text = dgvClients.Rows[e.RowIndex].Cells["ClientID"].Value?.ToString();
                txtClientName.Text = dgvClients.Rows[e.RowIndex].Cells["ClientName"].Value?.ToString();
                txtClientAddress.Text = dgvClients.Rows[e.RowIndex].Cells["ClientAddress"].Value?.ToString();
                txtClientPhone.Text = dgvClients.Rows[e.RowIndex].Cells["ClientPhone"].Value?.ToString();
            }
        }



        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientID.Text))
            {
                MessageBox.Show("ClientID cannot be empty!");
                return;
            }

            Client client = new Client
            {
                ClientID = txtClientID.Text,
                ClientName = txtClientName.Text,
                ClientAddress = txtClientAddress.Text,
                ClientPhone = txtClientPhone.Text
            };

            AddClientToDatabase(client);
            clientList.Add(client);
            LoadGrid();

            MessageBox.Show("Client record added successfully!");
            ClearInputs();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (editingRowIndex < 0 || editingRowIndex >= clientList.Count)
            {
                MessageBox.Show("Please select a client record to edit.");
                return;
            }

            Client client = clientList[editingRowIndex];
            client.ClientID = txtClientID.Text;
            client.ClientName = txtClientName.Text;
            client.ClientAddress = txtClientAddress.Text;
            client.ClientPhone = txtClientPhone.Text;

            UpdateClientInDatabase(client);
            LoadGrid();
            MessageBox.Show("Client record updated successfully!");
            editingRowIndex = -1;
            ClearInputs();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (editingRowIndex < 0 || editingRowIndex >= clientList.Count)
            {
                MessageBox.Show("Please select a client to delete.");
                return;
            }

            string clientId = clientList[editingRowIndex].ClientID;
            DeleteClientFromDatabase(clientId);
            clientList.RemoveAt(editingRowIndex);
            LoadGrid();
            editingRowIndex = -1;
            MessageBox.Show("Client deleted successfully!");
            ClearInputs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }



        private void ClearInputs()
        {
            txtClientID.Text = "";
            txtClientName.Text = "";
            txtClientAddress.Text = "";
            txtClientPhone.Text = "";
        }

        
    }
}

