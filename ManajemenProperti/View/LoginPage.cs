using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ManajemenProperti.Controller;

namespace ManajemenProperti.View
{
    public partial class LoginPage : Form
    {
        private readonly UsersController usersController;

        public LoginPage()
        {
            InitializeComponent();
            usersController = new UsersController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username atau Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usersController.Login(username, password))
            {
                MessageBox.Show("Login Berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormPenyewa formPenyewa = new FormPenyewa();
                formPenyewa.Show();
                this.Hide();

                tbUsername.Clear();
                tbPassword.Clear();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username atau Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usersController.Register(username, password))
            {
                MessageBox.Show("Pendaftaran berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsername.Clear();
                tbPassword.Clear();
            }
            else
            {
                MessageBox.Show("Pendaftaran gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}