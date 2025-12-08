using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void LoadGrid()
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = clients;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Client client = new Client()
            {
                ClientID = txtClientID.Text,
                ClientName = txtClientName.Text,
                ClientAddress = txtClientAddress.Text,
                ClientPhone = txtClientPhone.Text,


            };

            clients.Add(client);
            LoadGrid();

            MessageBox.Show("Client record added successfully!");

        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtClientID.Text = dgvClients.Rows[e.RowIndex].Cells["ClientID"].Value.ToString();
                txtClientName.Text = dgvClients.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtClientAddress.Text = dgvClients.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtClientPhone.Text = dgvClients.Rows[e.RowIndex].Cells["Phone"].Value.ToString();

            }
        }
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvClients.SelectedRows[0].Index;
                clients[selectedIndex].ClientID = txtClientID.Text;
                clients[selectedIndex].ClientName = txtClientName.Text;
                clients[selectedIndex].ClientAddress = txtClientAddress.Text;
                clients[selectedIndex].ClientPhone = txtClientPhone.Text;
                LoadGrid();
                MessageBox.Show("Client record updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a client record to edit.");
            }
        }
    }
}

