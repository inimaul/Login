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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FIX_LOGIN_REGISTER
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle recBut1;
        private Rectangle recTxt1;
        private Rectangle recPnl1;
        //private Rectangle recRdo1;
        private Rectangle reclbl1;
        private Rectangle reclbl2;
        private Rectangle recTxt2;
        private Rectangle reclbl13;
        private Rectangle reclbl3;
        private Rectangle reclbl4;
        private Rectangle reclink1;
        private Rectangle reclink2;

        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recBut1 = new Rectangle(guna2GradientTileButton1.Location, guna2GradientTileButton1.Size);
            recTxt1 = new Rectangle(textBox1.Location, textBox1.Size);
            recTxt2 = new Rectangle(textBox2.Location, textBox2.Size);
            reclbl1 = new Rectangle(label1.Location, label1.Size);
            reclbl2 = new Rectangle(label2.Location, label2.Size);
            reclbl13 = new Rectangle(label13.Location, label13.Size);
            reclbl4 = new Rectangle(label4.Location, label4.Size);
            reclbl3 = new Rectangle(label3.Location, label3.Size);
            reclink1 = new Rectangle(linkLabel1.Location, linkLabel1.Size);
            reclink2 = new Rectangle(linkLabel2.Location, linkLabel2.Size);

            //recRdo1 = new Rectangle(radioButton1.Location, textBox1.Size);
            textBox1.Multiline = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Height = 32;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Height = 32;
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
                    string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=Vario.125; Database=jecation;";
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
                    string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=Vario.125; Database=jecation;";
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
                    string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=Vario.125; Database=jecation;";
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

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(guna2GradientTileButton1, recBut1);
            resize_Control(textBox1, recTxt1);
            resize_Control(textBox2, recTxt2);
            resize_Control(label1, reclbl1);
            resize_Control(label2, reclbl2);
            resize_Control(label13, reclbl13);
            resize_Control(label3, reclbl3);
            resize_Control(linkLabel1, reclink1);
            resize_Control(linkLabel2, reclink2);


        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            float fontSize2 = (float)(Width + Height) / 170; // Sesuaikan rumus ini sesuai kebutuhan Anda

            float fontSize = (float)(Width + Height) / 100; // Sesuaikan rumus ini sesuai kebutuhan Anda

            // Atur ukuran font pada kontrol yang diinginkan
            label1.Font = new Font(label1.Font.FontFamily, fontSize2, label1.Font.Style);
            textBox1.Font = new Font(textBox1.Font.FontFamily, fontSize2, textBox1.Font.Style);

            guna2GradientTileButton1.Font = new Font(guna2GradientTileButton1.Font.FontFamily, fontSize, guna2GradientTileButton1.Font.Style);
        }
    }
}