using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string userFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json");


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!File.Exists(userFile))
            {
                MessageBox.Show("User file not found. Please create users.json in Documents.");
                return;
            }

            string json = File.ReadAllText(userFile);
            var users = JsonSerializer.Deserialize<List<User>>(json);

            foreach (var user in users)
            {
                if (user.Username == txtUsername.Text && user.Password == txtPassword.Text)
                {
                    // Successful login
                    MessageBox.Show($"Welcome, {user.Username}!");

                    if (user.Role == "Admin")
                        new AdminForm("Admin").Show();
                    else
                        new UserForm().Show();

                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Invalid username or password.");
        }

       
    }
}
