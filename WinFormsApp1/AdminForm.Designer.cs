using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    partial class AdminForm
    {
        string connectionString = "server=localhost;user=root;password=3PYYWCCE;database=xenstathatos_clientDB";
        private void TestConnection()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }
        private System.ComponentModel.IContainer components = null;
        private Button btnBack;
        private Label labelTitle;

        private void InitializeComponent()
        {
            btnBack = new Button();
            labelTitle = new Label();
            dgvClients = new DataGridView();
            ClientID = new DataGridViewTextBoxColumn();
            ClientName = new DataGridViewTextBoxColumn();
            ClientAddress = new DataGridViewTextBoxColumn();
            ClientPhone = new DataGridViewTextBoxColumn();
            txtClientAddress = new TextBox();
            txtClientID = new TextBox();
            txtClientName = new TextBox();
            txtClientPhone = new TextBox();
            lblClientID = new Label();
            lblClientName = new Label();
            lblClientAddress = new Label();
            lblClientPhone = new Label();
            btnAddClient = new Button();
            btnEditClient = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(10, 388);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(10, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(65, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Admin";
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { ClientID, ClientName, ClientAddress, ClientPhone });
            dgvClients.Location = new Point(10, 287);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(664, 95);
            dgvClients.TabIndex = 4;
            dgvClients.CellContentClick += dgvClients_CellClick;
            // 
            // ClientID
            // 
            ClientID.HeaderText = "ClientID";
            ClientID.MinimumWidth = 8;
            ClientID.Name = "ClientID";
            ClientID.Width = 150;
            // 
            // ClientName
            // 
            ClientName.HeaderText = "ClientName";
            ClientName.MinimumWidth = 8;
            ClientName.Name = "ClientName";
            ClientName.Width = 150;
            // 
            // ClientAddress
            // 
            ClientAddress.HeaderText = "ClientAddress";
            ClientAddress.MinimumWidth = 8;
            ClientAddress.Name = "ClientAddress";
            ClientAddress.Width = 150;
            // 
            // ClientPhone
            // 
            ClientPhone.HeaderText = "ClientPhone";
            ClientPhone.MinimumWidth = 8;
            ClientPhone.Name = "ClientPhone";
            ClientPhone.Width = 150;
            // 
            // txtClientAddress
            // 
            txtClientAddress.Location = new Point(12, 175);
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(150, 31);
            txtClientAddress.TabIndex = 5;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(12, 61);
            txtClientID.Name = "txtClientID";
            txtClientID.Size = new Size(150, 31);
            txtClientID.TabIndex = 6;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(12, 117);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(150, 31);
            txtClientName.TabIndex = 7;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(12, 237);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(150, 31);
            txtClientPhone.TabIndex = 8;
            // 
            // lblClientID
            // 
            lblClientID.AutoSize = true;
            lblClientID.Location = new Point(49, 35);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new Size(74, 25);
            lblClientID.TabIndex = 9;
            lblClientID.Text = "ClientID";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(49, 95);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(108, 25);
            lblClientName.TabIndex = 10;
            lblClientName.Text = "Client Name";
            // 
            // lblClientAddress
            // 
            lblClientAddress.AutoSize = true;
            lblClientAddress.Location = new Point(49, 151);
            lblClientAddress.Name = "lblClientAddress";
            lblClientAddress.Size = new Size(126, 25);
            lblClientAddress.TabIndex = 11;
            lblClientAddress.Text = "Client Address";
            // 
            // lblClientPhone
            // 
            lblClientPhone.AutoSize = true;
            lblClientPhone.Location = new Point(49, 209);
            lblClientPhone.Name = "lblClientPhone";
            lblClientPhone.Size = new Size(132, 25);
            lblClientPhone.TabIndex = 12;
            lblClientPhone.Text = "Phone Number";
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(191, 235);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(112, 34);
            btnAddClient.TabIndex = 13;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(319, 234);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(112, 34);
            btnEditClient.TabIndex = 14;
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            ClientSize = new Size(1023, 431);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(lblClientPhone);
            Controls.Add(lblClientAddress);
            Controls.Add(lblClientName);
            Controls.Add(lblClientID);
            Controls.Add(txtClientPhone);
            Controls.Add(txtClientName);
            Controls.Add(txtClientID);
            Controls.Add(txtClientAddress);
            Controls.Add(dgvClients);
            Controls.Add(labelTitle);
            Controls.Add(btnBack);
            Name = "AdminForm";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        List<Client> clients = new List<Client>();


        private DataGridView dgvClients;
        private DataGridViewTextBoxColumn ClientID;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn ClientAddress;
        private DataGridViewTextBoxColumn ClientPhone;
        private TextBox txtClientAddress;
        private TextBox txtClientID;
        private TextBox txtClientName;
        private TextBox txtClientPhone;
        private Label lblClientID;
        private Label lblClientName;
        private Label lblClientAddress;
        private Label lblClientPhone;
        private Button btnAddClient;
        private Button btnEditClient;
    }
}