using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolApp
{

    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnNavToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
        }

        private void btnSubmitRegister_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Registrasi gagal! Full name, username dan password wajib diisi!");
                return;
            }
            bool validation = Validation.UniqueData("users", "username", txtUserName.Text);
            if (validation)
            {
                MessageBox.Show("Registrasi gagal! Username sudah terdaftar!");
                return;
            }
            string passwordHashed = SecurityHelper.HashingPassword(txtPassword.Text);
            Connection conn = new Connection();
            using (MySqlConnection connection = conn.ConnectionToSql())
            {
                connection.Open();
                string query = "INSERT INTO users (full_name, username, password) VALUES (@full_name, @user, @pass)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@full_name", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@user", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@pass", passwordHashed);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Registrasi berhasil! Silahkan login!");
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
        }
    }
}
