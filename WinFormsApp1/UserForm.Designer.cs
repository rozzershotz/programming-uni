using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class UserForm
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnPrint = new Button();
            chkSortByName = new CheckBox();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            ((ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 604);
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
            labelTitle.Size = new Size(48, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Staff";
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(10, 362);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(1108, 236);
            dgvClients.TabIndex = 4;
            // 
            // txtClientAddress
            // 
            txtClientAddress.Location = new Point(12, 256);
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.Size = new Size(150, 31);
            txtClientAddress.TabIndex = 8;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(10, 136);
            txtClientID.Name = "txtClientID";
            txtClientID.Size = new Size(150, 31);
            txtClientID.TabIndex = 7;
            txtClientID.KeyPress += intOnly_KeyPress;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(10, 196);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(150, 31);
            txtClientName.TabIndex = 6;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(10, 316);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(150, 31);
            txtClientPhone.TabIndex = 5;
            txtClientPhone.KeyPress += intOnly_KeyPress;
            // 
            // lblClientID
            // 
            lblClientID.Location = new Point(20, 110);
            lblClientID.Name = "lblClientID";
            lblClientID.Size = new Size(100, 23);
            lblClientID.TabIndex = 4;
            lblClientID.Text = "ClientID";
            // 
            // lblClientName
            // 
            lblClientName.Location = new Point(20, 170);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(130, 23);
            lblClientName.TabIndex = 3;
            lblClientName.Text = "Client Name";
            // 
            // lblClientAddress
            // 
            lblClientAddress.Location = new Point(20, 230);
            lblClientAddress.Name = "lblClientAddress";
            lblClientAddress.Size = new Size(130, 23);
            lblClientAddress.TabIndex = 2;
            lblClientAddress.Text = "Client Address";
            // 
            // lblClientPhone
            // 
            lblClientPhone.Location = new Point(20, 290);
            lblClientPhone.Name = "lblClientPhone";
            lblClientPhone.Size = new Size(142, 23);
            lblClientPhone.TabIndex = 1;
            lblClientPhone.Text = "Phone Number";
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(195, 313);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(112, 34);
            btnAddClient.TabIndex = 0;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(507, 315);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(389, 313);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(1136, 564);
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
            chkSortByName.Location = new Point(1254, 569);
            chkSortByName.Name = "chkSortByName";
            chkSortByName.Size = new Size(145, 29);
            chkSortByName.TabIndex = 12;
            chkSortByName.Text = "Sort by name";
            chkSortByName.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(10, 74);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 33);
            cmbCategory.TabIndex = 13;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 46);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(133, 25);
            lblCategory.TabIndex = 14;
            lblCategory.Text = "Client Category";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(706, 312);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(834, 312);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // UserForm
            // 
            ClientSize = new Size(1607, 647);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(chkSortByName);
            Controls.Add(btnPrint);
            Controls.Add(btnAddClient);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
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
            Name = "UserForm";
            Text = "Save";
            ((ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnSave;
        private Button btnLoad;
    }
}