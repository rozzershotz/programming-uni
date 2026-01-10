using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBack;
        private Label labelTitle;
        private DataGridView dgvClients;
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
        private Button btnDeleteClient;

        private void InitializeComponent()
        {
            btnBack = new Button();
            labelTitle = new Label();
            dgvClients = new DataGridView();
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
            btnDeleteClient = new Button();
            ((ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(0, 403);
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
            dgvClients.Location = new Point(10, 287);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(761, 110);
            dgvClients.TabIndex = 4;
            // 
            // txtClientAddress
            // 
            txtClientAddress.Location = new Point(12, 175);
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(150, 31);
            txtClientAddress.TabIndex = 8;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(12, 61);
            txtClientID.Name = "txtClientID";
            txtClientID.Size = new Size(150, 31);
            txtClientID.TabIndex = 7;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(12, 117);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(150, 31);
            txtClientName.TabIndex = 6;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(12, 237);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(150, 31);
            txtClientPhone.TabIndex = 5;
            // 
            // lblClientID
            // 
            lblClientID.Location = new Point(49, 35);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new Size(100, 23);
            lblClientID.TabIndex = 4;
            lblClientID.Text = "ClientID";
            // 
            // lblClientName
            // 
            lblClientName.Location = new Point(49, 95);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(130, 23);
            lblClientName.TabIndex = 3;
            lblClientName.Text = "Client Name";
            // 
            // lblClientAddress
            // 
            lblClientAddress.Location = new Point(49, 151);
            lblClientAddress.Name = "lblClientAddress";
            lblClientAddress.Size = new Size(130, 23);
            lblClientAddress.TabIndex = 2;
            lblClientAddress.Text = "Client Address";
            // 
            // lblClientPhone
            // 
            lblClientPhone.Location = new Point(49, 209);
            lblClientPhone.Name = "lblClientPhone";
            lblClientPhone.Size = new Size(142, 23);
            lblClientPhone.TabIndex = 1;
            lblClientPhone.Text = "Phone Number";
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(191, 235);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(112, 34);
            btnAddClient.TabIndex = 0;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient = new Button();
            btnEditClient.Location = new System.Drawing.Point(320, 235);
            btnEditClient.Size = new System.Drawing.Size(112, 34);
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            Controls.Add(btnEditClient);

            // 
            // btnDeleteClient
            // 
            btnDeleteClient = new Button();
            btnDeleteClient.Location = new System.Drawing.Point(450, 235);
            btnDeleteClient.Size = new System.Drawing.Size(112, 34);
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            Controls.Add(btnDeleteClient);
            // 
            // AdminForm
            // 
            ClientSize = new Size(1023, 431);
            Controls.Add(btnDeleteClient);
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
            ((ISupportInitialize)dgvClients).EndInit();
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
        
    }

}