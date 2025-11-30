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
            components = new System.ComponentModel.Container();
            btnBack = new Button();
            labelTitle = new Label();

            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(10, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "Admin";

            // btnBack
            btnBack.Location = new Point(10, 40);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;

            // AdminForm
            ClientSize = new Size(300, 200);
            Controls.Add(labelTitle);
            Controls.Add(btnBack);
            Name = "AdminForm";
            Text = "Admin";
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