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

            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();

            // btnBack
            btnBack.Location = new Point(10, 388);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(10, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(65, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Admin";

            // dgvClients
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(10, 287);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(664, 95);
            dgvClients.TabIndex = 4;

            // Textboxes and labels (layout)
            txtClientID.Location = new Point(12, 61);
            txtClientID.Size = new Size(150, 31);

            txtClientName.Location = new Point(12, 117);
            txtClientName.Size = new Size(150, 31);

            txtClientAddress.Location = new Point(12, 175);
            txtClientAddress.Size = new Size(150, 31);

            txtClientPhone.Location = new Point(12, 237);
            txtClientPhone.Size = new Size(150, 31);

            lblClientID.Location = new Point(49, 35);
            lblClientID.Text = "ClientID";

            lblClientName.Location = new Point(49, 95);
            lblClientName.Text = "Client Name";

            lblClientAddress.Location = new Point(49, 151);
            lblClientAddress.Text = "Client Address";

            lblClientPhone.Location = new Point(49, 209);
            lblClientPhone.Text = "Phone Number";

            // btnAddClient
            btnAddClient.Location = new Point(191, 235);
            btnAddClient.Size = new Size(112, 34);
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;

            // AdminForm
            ClientSize = new Size(1023, 431);
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
    }

}