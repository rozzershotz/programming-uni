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

        // Constructor
        public UserForm()
        {
            InitializeComponent();

            cmbCategory.Items.AddRange(new string[] { "Software", "Laptops and Pcs", "Office tools", "Accessories", "Games" });
            cmbCategory.SelectedIndex = 0;

            dgvClients.AutoGenerateColumns = true;
            dgvClients.AllowUserToAddRows = false;
            dgvClients.DataSource = clients;

            dgvClients.CellClick += dgvClients_CellClick;

            LoadClientsFromFile();

            dgvClients.DataSource = clients;
        }
        private Client selectedClient = null;

        // File path to store client data
        private string clientDataFile = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
    "clients.json");






        // Save clients to JSON file
        private void SaveClientsToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(clients);
                File.WriteAllText(clientDataFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving clients: " + ex.Message);
            }
        }

        // Load clients from JSON file
        private void LoadClientsFromFile()
        {
            try
            {
                if (File.Exists(clientDataFile))
                {
                    string json = File.ReadAllText(clientDataFile);
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
        // Filter clients based on search query
        private void FilterClients(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {

                dgvClients.DataSource = clients;
                return;
            }

            query = query.ToLower();


            var filtered = clients.Where(c =>
                (!string.IsNullOrEmpty(c.ClientID) && c.ClientID.ToLower().Contains(query)) ||
                (!string.IsNullOrEmpty(c.ClientName) && c.ClientName.ToLower().Contains(query))

            ).ToList();


            dgvClients.DataSource = new BindingList<Client>(filtered);
        }
        // Creates functionality for Back button to return to main form
        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        // Creates functionality for Add Client button to add new client records
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

            // Create new client object
            Client client = new Client
            {
                ClientID = txtClientID.Text,
                ClientName = txtClientName.Text,
                ClientAddress = txtClientAddress.Text,
                ClientPhone = txtClientPhone.Text,
                ClientCategory = cmbCategory.SelectedItem.ToString()
            };



            clients.Add(client);
            SaveClientsToFile();
            ResetClientForm();
            MessageBox.Show("Client record added successfully!");
        }

        //Saves the clients to file when the form is closed
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveClientsToFile();
        }


        //Functionality for when a cell is clicked in the DataGridView
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= clients.Count)
                return;

            selectedClient = clients[e.RowIndex];

            txtClientID.Text = selectedClient.ClientID;
            txtClientName.Text = selectedClient.ClientName;
            txtClientAddress.Text = selectedClient.ClientAddress;
            txtClientPhone.Text = selectedClient.ClientPhone;
            cmbCategory.SelectedItem = selectedClient.ClientCategory;
        }

        //Functionality for when the text in the search box is changed to filter client records
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterClients(txtSearch.Text);
        }
        //Functionality for when the search button is clicked to filter client records
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterClients(txtSearch.Text);
        }
        //Functionality for Clear Search button to reset the search filter
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dgvClients.DataSource = clients;
        }
        //Functionality for the print button allowing a sheet of client records
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (clients.Count == 0)
            {
                MessageBox.Show("No clients to print.");
                return;
            }


            var listToPrint = chkSortByName.Checked
                ? clients.OrderBy(c => c.ClientName).ToList()
                : clients.ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Client Records");

            foreach (var c in listToPrint)
            {
                sb.AppendLine($"ID: {c.ClientID}");
                sb.AppendLine($"Name: {c.ClientName}");
                sb.AppendLine($"Address: {c.ClientAddress}");
                sb.AppendLine($"Phone: {c.ClientPhone}");
                sb.AppendLine("----------------------");
            }

            // Set up PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(sb.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(100, 100));
            };


            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = pd,
                Width = 800,
                Height = 600
            };
            preview.ShowDialog();
        }

        private void intOnly_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string serializeToTxt(IEnumerable<Client> list) =>
        string.Join(Environment.NewLine,
        list.Select(c => $"{c.ClientID},{c.ClientName},{c.ClientAddress},{c.ClientPhone},{c.ClientCategory}"));

        private BindingList<Client> deserializeFromCsv(string csv) =>
            new BindingList<Client>(
                csv.Split(Environment.NewLine)
                   .Select(l => l.Split(','))
                   .Where(p => p.Length == 5)
                   .Select(p => new Client
                   {
                       ClientID = p[0],
                       ClientName = p[1],
                       ClientAddress = p[2],
                       ClientPhone = p[3],
                       ClientCategory = p[4]
                   }).ToList());

        private string saveToTxt(IEnumerable<Client> list) =>
        string.Join(Environment.NewLine,
        list.Select(c => $"{c.ClientID}|{c.ClientName}|{c.ClientAddress}|{c.ClientPhone}|{c.ClientCategory}"));

        private BindingList<Client> DeserializeFromTxt(string txt) =>
            new BindingList<Client>(
                txt.Split(Environment.NewLine)
                   .Select(line => line.Split('|'))
                   .Where(p => p.Length == 5)
                   .Select(p => new Client
                   {
                       ClientID = p[0],
                       ClientName = p[1],
                       ClientAddress = p[2],
                       ClientPhone = p[3],
                       ClientCategory = p[4]
                   }).ToList());



        private void saveClients()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|TXT Files (*.txt)|*txt",
                Title = "Save Clients"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string extension = Path.GetExtension(saveFileDialog.FileName).ToLower();
            string content = extension switch
            {
                ".csv" => saveToTxt(clients),
                ".txt" => saveToTxt(clients),
                _ => throw new Exception("Unsupported format")
            };


        }

        private void loadClients()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "All Supported|*.json;*.csv;*.txt;*.xml"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            string encrypted = File.ReadAllText(ofd.FileName);
            string decrypted = encryptionClass.DecryptString(encrypted);

            string extension = Path.GetExtension(ofd.FileName).ToLower();

            BindingList<Client> loaded = extension switch
            {

                ".csv" => deserializeFromCsv(decrypted),
                ".txt" => DeserializeFromTxt(decrypted),
                _ => throw new Exception("Unsupported format")
            };

            clients = loaded ?? new BindingList<Client>();
            dgvClients.DataSource = clients;

            MessageBox.Show("File loaded and decrypted successfully.");
        }



        // Clears the textboxes and resets selection
        private void ResetClientForm()
        {
            txtClientID.Clear();
            txtClientName.Clear();
            txtClientAddress.Clear();
            txtClientPhone.Clear();
            dgvClients.ClearSelection();
            selectedClient = null;
            txtClientID.Focus();
            cmbCategory.SelectedIndex = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadClients();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveClients();
        }
    }
}