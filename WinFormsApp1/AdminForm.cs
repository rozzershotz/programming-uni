using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;


namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        // BindingList automatically updates the DataGridView
        BindingList<Client> clients = new BindingList<Client>();

        public AdminForm()
        {
            InitializeComponent();

            // Grid settings
            dgvClients.AutoGenerateColumns = true;
            dgvClients.AllowUserToAddRows = false;
            dgvClients.DataSource = clients;

            // Hook up safe CellClick event
            dgvClients.CellClick += dgvClients_CellClick;

            LoadClientsFromFile();

            dgvClients.DataSource = clients;
        }

        private string dataFile = "clients.json"; // file in app folder

        // Save clients to JSON
        private void SaveClientsToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(clients);
                File.WriteAllText(dataFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving clients: " + ex.Message);
            }
        }

        // Load clients from JSON
        private void LoadClientsFromFile()
        {
            try
            {
                if (File.Exists(dataFile))
                {
                    string json = File.ReadAllText(dataFile);
                    var loadedClients = JsonSerializer.Deserialize<BindingList<Client>>(json);
                    if (loadedClients != null)
                    {
                        clients = loadedClients;
                        dgvClients.DataSource = clients;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
        }

        // Back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        // Add client
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtClientID.Text) ||
                string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Please enter ClientID and Client Name.");
                return;
            }

            // Optional: prevent duplicate ClientID
            foreach (var c in clients)
            {
                if (c.ClientID == txtClientID.Text)
                {
                    MessageBox.Show("ClientID already exists!");
                    return;
                }
            }

            // Create client object
            Client client = new Client
            {
                ClientID = txtClientID.Text,
                ClientName = txtClientName.Text,
                ClientAddress = txtClientAddress.Text,
                ClientPhone = txtClientPhone.Text
            };

            clients.Add(client);

            clients.Add(client);
            SaveClientsToFile(); // save after adding
            ClearTextboxes();
            MessageBox.Show("Client record added successfully!");
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveClientsToFile();
        }


        // Safely populate textboxes when a row is clicked
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only valid rows
            if (e.RowIndex < 0 || e.RowIndex >= clients.Count)
                return;

            var client = clients[e.RowIndex];

            if (client == null) return; // Extra safety

            txtClientID.Text = client.ClientID;
            txtClientName.Text = client.ClientName;
            txtClientAddress.Text = client.ClientAddress;
            txtClientPhone.Text = client.ClientPhone;
        }

        // Helper method to clear input fields
        private void ClearTextboxes()
        {
            txtClientID.Clear();
            txtClientName.Clear();
            txtClientAddress.Clear();
            txtClientPhone.Clear();
            txtClientID.Focus();
        }
    }
}


