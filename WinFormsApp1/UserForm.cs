using System;
using System.ComponentModel;
using System.Text.Json;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Text;

namespace WinFormsApp1
{
    public partial class UserForm : Form
    {
        BindingList<Client> clients = new BindingList<Client>();

        public UserForm()
        {
            InitializeComponent();

            dgvClients.AutoGenerateColumns = true;
            dgvClients.AllowUserToAddRows = false;
            dgvClients.DataSource = clients;

            // Hook up safe CellClick event
            dgvClients.CellClick += dgvClients_CellClick;

            LoadClientsFromFile();

            dgvClients.DataSource = clients;
        }
        private Client selectedClient = null;


        private string dataFile = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
    "clients.json");






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

        private void FilterClients(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                // Show all clients if query is empty
                dgvClients.DataSource = clients;
                return;
            }

            query = query.ToLower(); // case-insensitive

            // Filter clients
            var filtered = clients.Where(c =>
                (!string.IsNullOrEmpty(c.ClientID) && c.ClientID.ToLower().Contains(query)) ||
                (!string.IsNullOrEmpty(c.ClientName) && c.ClientName.ToLower().Contains(query)) ||
                (!string.IsNullOrEmpty(c.ClientAddress) && c.ClientAddress.ToLower().Contains(query)) ||
                (!string.IsNullOrEmpty(c.ClientPhone) && c.ClientPhone.ToLower().Contains(query))
            ).ToList();

            // Bind filtered results
            dgvClients.DataSource = new BindingList<Client>(filtered);
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
            if (e.RowIndex < 0 || e.RowIndex >= clients.Count)
                return;

            selectedClient = clients[e.RowIndex];

            txtClientID.Text = selectedClient.ClientID;
            txtClientName.Text = selectedClient.ClientName;
            txtClientAddress.Text = selectedClient.ClientAddress;
            txtClientPhone.Text = selectedClient.ClientPhone;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterClients(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterClients(txtSearch.Text);
        }
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dgvClients.DataSource = clients;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (clients.Count == 0)
            {
                MessageBox.Show("No clients to print.");
                return;
            }

            // Create a list to print
            var listToPrint = chkSortByName.Checked
                ? clients.OrderBy(c => c.ClientName).ToList()
                : clients.ToList(); // as stored

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Client Records");
            sb.AppendLine("==============");
            foreach (var c in listToPrint)
            {
                sb.AppendLine($"ID: {c.ClientID}");
                sb.AppendLine($"Name: {c.ClientName}");
                sb.AppendLine($"Address: {c.ClientAddress}");
                sb.AppendLine($"Phone: {c.ClientPhone}");
                sb.AppendLine("----------------------");
            }

            // Setup print
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(sb.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
            };

            // Show preview before printing
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 800,
                Height = 600
            };
            preview.ShowDialog();
        }




        // Helper method to clear input fields
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

        
    }
}