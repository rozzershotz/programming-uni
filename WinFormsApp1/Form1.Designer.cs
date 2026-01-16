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

        private Label lblRegister;
        private Label lblRegUsername;
        private Label lblRegPassword;
        private Label lblRole;
        private TextBox txtRegUsername;
        private TextBox txtRegPassword;
        private ComboBox cmbRole;
        private Button btnRegister;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();

            lblRegister = new Label();
            lblRegUsername = new Label();
            lblRegPassword = new Label();
            lblRole = new Label();
            txtRegUsername = new TextBox();
            txtRegPassword = new TextBox();
            cmbRole = new ComboBox();
            btnRegister = new Button();

            SuspendLayout();

            // login existing staff
            lblTitle.Text = "CRS Login";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(320, 20);
            lblTitle.AutoSize = true;

            lblUsername.Text = "Username";
            lblUsername.Location = new System.Drawing.Point(200, 80);

            txtUsername.Location = new System.Drawing.Point(300, 80);
            txtUsername.Size = new System.Drawing.Size(150, 31);

            lblPassword.Text = "Password";
            lblPassword.Location = new System.Drawing.Point(200, 120);

            txtPassword.Location = new System.Drawing.Point(300, 120);
            txtPassword.Size = new System.Drawing.Size(150, 31);
            txtPassword.PasswordChar = '*';

            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(300, 160);
            btnLogin.Size = new System.Drawing.Size(150, 35);
            btnLogin.Click += btnLogin_Click;

            // register new staff
            lblRegister.Text = "Register New Staff";
            lblRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblRegister.Location = new System.Drawing.Point(300, 220);
            lblRegister.AutoSize = true;

            lblRegUsername.Text = "Username";
            lblRegUsername.Location = new System.Drawing.Point(200, 260);

            txtRegUsername.Location = new System.Drawing.Point(300, 260);
            txtRegUsername.Size = new System.Drawing.Size(150, 31);

            lblRegPassword.Text = "Password";
            lblRegPassword.Location = new System.Drawing.Point(200, 300);

            txtRegPassword.Location = new System.Drawing.Point(300, 300);
            txtRegPassword.Size = new System.Drawing.Size(150, 31);
            txtRegPassword.PasswordChar = '*';

            lblRole.Text = "Role";
            lblRole.Location = new System.Drawing.Point(200, 340);

            cmbRole.Location = new System.Drawing.Point(300, 340);
            cmbRole.Size = new System.Drawing.Size(150, 31);
            cmbRole.Items.AddRange(new object[] { "Admin", "Staff" });

            btnRegister.Text = "Register";
            btnRegister.Location = new System.Drawing.Point(300, 380);
            btnRegister.Size = new System.Drawing.Size(150, 35);
            btnRegister.Click += btnRegister_Click;

            // ---- ADD CONTROLS ----
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);

            Controls.Add(lblRegister);
            Controls.Add(lblRegUsername);
            Controls.Add(txtRegUsername);
            Controls.Add(lblRegPassword);
            Controls.Add(txtRegPassword);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(btnRegister);

            ClientSize = new System.Drawing.Size(800, 460);
            Text = "CRS Login and Registration";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
