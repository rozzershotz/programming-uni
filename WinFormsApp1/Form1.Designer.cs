namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(300, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CRS Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(200, 100);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(200, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(300, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(300, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 4;
            
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(300, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "CRS Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
