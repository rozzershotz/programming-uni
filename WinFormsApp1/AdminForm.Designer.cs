using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnPrint = new Button();
            chkSortByName = new CheckBox();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            ((ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 578);
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
            labelTitle.Location = new Point(10, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(65, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Admin";
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(10, 344);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(1078, 216);
            dgvClients.TabIndex = 4;
            // 
            // txtClientAddress
            // 
            txtClientAddress.Location = new Point(12, 238);
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(150, 31);
            txtClientAddress.TabIndex = 8;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(12, 117);
            txtClientID.Name = "txtClientID";
            txtClientID.Size = new Size(150, 31);
            txtClientID.TabIndex = 7;
            txtClientID.KeyPress += intOnly_KeyPress;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(12, 177);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(150, 31);
            txtClientName.TabIndex = 6;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(12, 299);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(150, 31);
            txtClientPhone.TabIndex = 5;
            txtClientPhone.KeyPress += intOnly_KeyPress;
            // 
            // lblClientID
            // 
            lblClientID.Location = new Point(12, 91);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new Size(100, 23);
            lblClientID.TabIndex = 4;
            lblClientID.Text = "ClientID";
            // 
            // lblClientName
            // 
            lblClientName.Location = new Point(7, 151);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(130, 23);
            lblClientName.TabIndex = 3;
            lblClientName.Text = "Client Name";
            // 
            // lblClientAddress
            // 
            lblClientAddress.Location = new Point(7, 211);
            lblClientAddress.Name = "lblClientAddress";
            lblClientAddress.Size = new Size(130, 23);
            lblClientAddress.TabIndex = 2;
            lblClientAddress.Text = "Client Address";
            // 
            // lblClientPhone
            // 
            lblClientPhone.Location = new Point(7, 272);
            lblClientPhone.Name = "lblClientPhone";
            lblClientPhone.Size = new Size(142, 23);
            lblClientPhone.TabIndex = 1;
            lblClientPhone.Text = "Phone Number";
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(200, 296);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(112, 34);
            btnAddClient.TabIndex = 0;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(318, 296);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(112, 34);
            btnEditClient.TabIndex = 0;
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Location = new Point(436, 296);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(150, 34);
            btnDeleteClient.TabIndex = 1;
            btnDeleteClient.Text = "Delete Client";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(672, 296);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 31);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(878, 293);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1114, 526);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(112, 34);
            btnPrint.TabIndex = 11;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // chkSortByName
            // 
            chkSortByName.AutoSize = true;
            chkSortByName.Location = new Point(1245, 526);
            chkSortByName.Name = "chkSortByName";
            chkSortByName.Size = new Size(148, 29);
            chkSortByName.TabIndex = 12;
            chkSortByName.Text = "Sort by Name";
            chkSortByName.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(12, 55);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 33);
            cmbCategory.TabIndex = 13;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(200, 58);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(133, 25);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Client Category";
            // 
            // AdminForm
            // 
            ClientSize = new Size(1540, 621);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(chkSortByName);
            Controls.Add(btnPrint);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
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
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnPrint;
        private CheckBox chkSortByName;
        private ComboBox cmbCategory;
        private Label lblCategory;
    }

}