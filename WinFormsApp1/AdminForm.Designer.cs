using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnBack;
        private Label labelTitle;

        private void InitializeComponent()
        {
            btnBack = new Button();
            labelTitle = new Label();
            lblClientNumber = new Label();
            lblclientName = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 267);
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
            // lblClientNumber
            // 
            lblClientNumber.AutoSize = true;
            lblClientNumber.Location = new Point(12, 106);
            lblClientNumber.Name = "lblClientNumber";
            lblClientNumber.Size = new Size(108, 25);
            lblClientNumber.TabIndex = 2;
            lblClientNumber.Text = "Client Name";
            // 
            // lblclientName
            // 
            lblclientName.AutoSize = true;
            lblclientName.Location = new Point(12, 35);
            lblclientName.Name = "lblclientName";
            lblclientName.Size = new Size(108, 25);
            lblclientName.TabIndex = 3;
            lblclientName.Text = "Client Name";
            // 
            // AdminForm
            // 
            ClientSize = new Size(535, 310);
            Controls.Add(lblclientName);
            Controls.Add(lblClientNumber);
            Controls.Add(labelTitle);
            Controls.Add(btnBack);
            Name = "AdminForm";
            Text = "Admin";
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
        private Label lblClientNumber;
        private Label lblclientName;
    }
}