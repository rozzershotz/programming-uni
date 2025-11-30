using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += button2_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminForm().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UserForm().Show();
            this.Hide();
        }
    }
}
