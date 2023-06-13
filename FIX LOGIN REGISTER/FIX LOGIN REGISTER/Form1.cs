using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Security.Cryptography;
using Npgsql;

namespace FIX_LOGIN_REGISTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }


        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }

            textBox2.Focus();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox2.Focus();
                label2.Visible = false;
            }
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password_1 forgotpw1 = new Forgot_Password_1();
            forgotpw1.Show();
            this.Hide();
        }

        public void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

            try
            {
                string username_akun = textBox1.Text;
                string password = textBox2.Text;
                string password_akun = GetSHA256Hash(password);
                bool data = AuthenticateData(username_akun, password_akun);
                bool name = AuthenticateUser(username_akun);
                bool pass = AuthenticatePass(password_akun);

                if (data)
                {
                    MessageBox.Show("Login Succesfull");

                }
                else
                {
                    if (username_akun == "" || password == "")
                    {
                        label13.Show();
                        MessageBox.Show("Fill Usernsme or password");
                    }
                    else if (!name)
                    {
                        MessageBox.Show("Login Failed, Username is wrong");
                    }
                    else if (!pass)
                    {
                        MessageBox.Show("Login Failed, Password is wrong");

                    }
                }

                static string GetSHA256Hash(string input)
                {
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                        return BitConverter.ToString(bytes).Replace("-", "").ToLower();
                    }
                }

                static bool AuthenticateData(string username_akun, string password_akun)
                {
                    string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=Yus2064.; Database=jecation;";
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        string dataQuery = "SELECT COUNT(*) FROM akun WHERE username_akun = @username_akun AND password_akun = @password_akun";
                        using (NpgsqlCommand command = new NpgsqlCommand(dataQuery, connection))
                        {
                            command.Parameters.AddWithValue("username_akun", username_akun);
                            command.Parameters.AddWithValue("password_akun", password_akun);
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            return count > 0;
                        }

                    }
                }

                static bool AuthenticateUser(string username_akun)
                {
                    string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=Yus2064.; Database=jecation;";
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        string dataQuery = "SELECT COUNT(*) FROM akun WHERE username_akun = @username_akun";
                        using (NpgsqlCommand command = new NpgsqlCommand(dataQuery, connection))
                        {
                            command.Parameters.AddWithValue("username_akun", username_akun);
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            return count > 0;
                        }

                    }
                }

                static bool AuthenticatePass(string password_akun)
                {
                    string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=Yus2064.; Database=jecation;";
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();

                        string dataQuery = "SELECT COUNT(*) FROM akun WHERE password_akun = @password_akun";
                        using (NpgsqlCommand command = new NpgsqlCommand(dataQuery, connection))
                        {
                            command.Parameters.AddWithValue("password_akun", password_akun);
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            return count > 0;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up daftar = new Sign_Up();
            daftar.Show();
            this.Hide();
        }
    }
}