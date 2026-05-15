using StaffUniformTracker.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffUniformTracker.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            _ok.Click += OnOk;
        }
        private void OnOk(object? sender, EventArgs e)
        {
            if (!UniformTrackingApp.Instance.Login(_user.Text, _pass.Text))
            { _err.Text = "Invalid credentials. Use admin / admin."; return; }
            DialogResult = DialogResult.OK; Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
