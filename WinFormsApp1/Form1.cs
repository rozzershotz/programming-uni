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

        // login existing user
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!File.Exists(userFile))
            {
                MessageBox.Show("users.json not found.");
                return;
            }

            var users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(userFile));

            if (users == null)
            {
                MessageBox.Show("No users found.");
                return;
            }

            foreach (var user in users)
            {
                if (user.Username == txtUsername.Text &&
                    user.Password == txtPassword.Text)
                {
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

        // register new user
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!File.Exists(userFile))
            {
                File.WriteAllText(userFile, "[]");
            }

            var users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(userFile))
                        ?? new List<User>();

            if (string.IsNullOrWhiteSpace(txtRegUsername.Text) ||
                string.IsNullOrWhiteSpace(txtRegPassword.Text) ||
                cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all registration fields.");
                return;
            }

            foreach (var u in users)
            {
                if (u.Username == txtRegUsername.Text)
                {
                    MessageBox.Show("User already exists.");
                    return;
                }
            }

            users.Add(new User
            {
                Username = txtRegUsername.Text,
                Password = txtRegPassword.Text,
                Role = cmbRole.SelectedItem.ToString()
            });

            File.WriteAllText(userFile, JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true }));

            MessageBox.Show("User registered successfully!");

            txtRegUsername.Clear();
            txtRegPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }
    }
}
