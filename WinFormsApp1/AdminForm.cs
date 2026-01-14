using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        BindingList<Client> clients = new BindingList<Client>();
        private Client selectedClient = null;

        // Role of logged-in user
        private string currentRole;

        // Path to clients.json
        private string dataFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "clients.json");

        public AdminForm(string role)
        {
            InitializeComponent();

            currentRole = role;

            dgvClients.AutoGenerateColumns = true;
            dgvClients.AllowUserToAddRows = false;
            dgvClients.DataSource = clients;

            dgvClients.CellClick += dgvClients_CellClick;

            LoadClientsFromFile();

            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            if (currentRole == "Staff")
            {
                btnDeleteClient.Enabled = false;
                btnEditClient.Enabled = false;
            }
        }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientID.Text) ||
                string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Please enter ClientID and Client Name.");
                return;
            }

            foreach (var c in clients)
            {
                if (c.ClientID == txtClientID.Text)
                {
                    MessageBox.Show("ClientID already exists!");
                    return;
                }
            }

            Client client = new Client
            {
                ClientID = txtClientID.Text,
                ClientName = txtClientName.Text,
                ClientAddress = txtClientAddress.Text,
                ClientPhone = txtClientPhone.Text
            };

            clients.Add(client);
            SaveClientsToFile();
            ClearTextboxes();
            MessageBox.Show("Client record added successfully!");
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= clients.Count)
                return;

            selectedClient = clients[e.RowIndex];

            txtClientID.Text = selectedClient.ClientID;
            txtClientName.Text = selectedClient.ClientName;
            txtClientAddress.Text = selectedClient.ClientAddress;
            txtClientPhone.Text = selectedClient.ClientPhone;
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (selectedClient == null)
            {
                MessageBox.Show("Please select a client to edit.");
                return;
            }

            selectedClient.ClientID = txtClientID.Text;
            selectedClient.ClientName = txtClientName.Text;
            selectedClient.ClientAddress = txtClientAddress.Text;
            selectedClient.ClientPhone = txtClientPhone.Text;

            dgvClients.Refresh();
            SaveClientsToFile();
            MessageBox.Show("Client updated successfully!");
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (selectedClient == null)
            {
                MessageBox.Show("Please select a client to delete.");
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete {selectedClient.ClientName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                clients.Remove(selectedClient);
                selectedClient = null;
                ClearTextboxes();
                SaveClientsToFile();
                MessageBox.Show("Client deleted successfully!");
                dgvClients.Refresh();
            }
        }

        private void ClearTextboxes()
        {
            txtClientID.Clear();
            txtClientName.Clear();
            txtClientAddress.Clear();
            txtClientPhone.Clear();
            dgvClients.ClearSelection();
            selectedClient = null;
            txtClientID.Focus();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveClientsToFile();
        }
    }
}
