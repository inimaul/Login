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
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Guna.Charts;

namespace FIX_LOGIN_REGISTER
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle rectb1;
        private Rectangle rectb2;
        private Rectangle reclb1;
        private Rectangle reclb2;
        private Rectangle reclb3;
        private Rectangle reclb4;
        private Rectangle reclb13;
        private Rectangle reclinklbl1;
        private Rectangle reclinklbl2;
        private Rectangle recgb1;
        private Rectangle recpb1;
        private Rectangle recpb2;

        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            rectb1 = new Rectangle(textBox1.Location, textBox1.Size);
            rectb2 = new Rectangle(textBox2.Location, textBox2.Size);
            reclb1 = new Rectangle(label1.Location, label1.Size);
            reclb2 = new Rectangle(label2.Location, label2.Size);
            reclb3 = new Rectangle(label3.Location, label3.Size);
            reclb4 = new Rectangle(label4.Location, label4.Size);
            reclb13 = new Rectangle(label13.Location, label13.Size);
            reclinklbl1 = new Rectangle(linkLabel1.Location, linkLabel1.Size);
            reclinklbl2 = new Rectangle(linkLabel2.Location, linkLabel2.Size);
            recgb1 = new Rectangle(guna2GradientTileButton1.Location, guna2GradientTileButton1.Size);
            recpb1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
            recpb2 = new Rectangle(pictureBox2.Location, pictureBox2.Size);
        }

        public class User
        {
            public int id_user { get; set; }
            public string username { get; set; }
            public string role { get; set; }

        }

        private static RSA GenerateRsaKey(int keySizeInBits)
        {
            var rsa = RSA.Create();
            rsa.KeySize = keySizeInBits;
            return rsa;
        }

        public class TokenManager
        {
            private const string SecretKey = "mysecretkey";

            public static string GenerateToken(User user)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var rsaKey = GenerateRsaKey(2048);

                var rsaParameters = rsaKey.ExportParameters(includePrivateParameters: false);
                var rsaSecurityKey = new RsaSecurityKey(rsaParameters);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                new Claim(ClaimTypes.NameIdentifier, user.id_user.ToString()),
                new Claim(ClaimTypes.Name, user.username),
                new Claim(ClaimTypes.Role, user.role)
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new RsaSecurityKey(rsaKey), SecurityAlgorithms.RsaSha256)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }

            public static User ValidateToken(string token)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var rsaKey = GenerateRsaKey(2048);

                try
                {
                    tokenHandler.ValidateToken(token, new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new RsaSecurityKey(rsaKey),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ClockSkew = TimeSpan.Zero
                    }, out SecurityToken validatedToken);

                    var jwtToken = (JwtSecurityToken)validatedToken;
                    var userId = int.Parse(jwtToken.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value);
                    var username = jwtToken.Claims.First(x => x.Type == ClaimTypes.Name).Value;
                    var role = jwtToken.Claims.First(x => x.Type == ClaimTypes.Role).Value;

                    return new User { id_user = userId, username = username, role = role };
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Height = 32;
            //textBox1.AutoSize = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //    textBox2.Height = 32;
            //    textBox2.AutoSize = false;
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
        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up daftar = new Sign_Up();
            daftar.Show();
            this.Hide();
        }

        public void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {


            using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=;Database=jecation"))
            {

                string username = textBox1.Text;
                string password = textBox2.Text;
                string password_akun = GetSHA256Hash(password);
                bool data = AuthenticateData(username, password_akun);
                bool name = AuthenticateUser(username);
                bool pass = AuthenticatePass(password_akun);

                if (data)
                {
                    connection.Open();
                    string query = "select * from akun where username_akun = @username and password_akun = @password";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password_akun);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Jika login berhasil, buat objek User dan token
                                User user = new User
                                {
                                    id_user = (int)reader["id_akun"],
                                    username = (string)reader["username_akun"],
                                    role = (string)reader["role"]
                                };

                                string token = TokenManager.GenerateToken(user);

                                // Simpan token di session atau tempat penyimpanan yang sesuai
                                MessageBox.Show("Login successfull");
                                if (user.role == "admin")
                                {
                                    // Tampilkan form admin
                                    Form3 adminForm = new Form3(user);
                                    adminForm.Show();
                                }
                                else if (user.role == "user")
                                {
                                    // Tampilkan form user
                                    Form2 userForm = new Form2(user);
                                    userForm.Show();
                                }
                                this.Hide();
                            }
                            else
                            {
                                // Jika login gagal, tampilkan pesan kesalahan
                                MessageBox.Show("Username atau password salah.");
                            }
                        }
                    }
                }
                else
                {
                    if (username == "" || password == "")
                    {
                        if (username == " " && password == "")
                        {
                            label13.Show();
                            label4.Show();
                            MessageBox.Show("Fill Usernsme and password");
                            return;
                        }
                        else if (username == "")
                        {
                            label13.Show();
                            MessageBox.Show("Fill Usernsme");
                            return;
                        }
                        else
                        {
                            label4.Show();
                            MessageBox.Show("Fill Password");
                            return;
                        }

                    }
                    else if (!name && !pass)
                    {
                        MessageBox.Show("Login Failed, Username and Password is wrong");
                        return;
                    }
                    else if (!name)
                    {
                        MessageBox.Show("Login Failed, Username is wrong");
                        return;

                    }
                    else
                    {
                        MessageBox.Show("Login Failed, Password is wrong");
                        return;
                    }
                }

                static bool AuthenticateData(string username_akun, string password_akun)
                {
                    string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=; Database=jecation;";
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
                    string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=; Database=jecation;";
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
                    string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=; Database=jecation;";
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
                static string GetSHA256Hash(string input)
                {
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                        return BitConverter.ToString(bytes).Replace("-", "").ToLower();
                    }


                }

            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resize_Control(textBox1, rectb1);
            resize_Control(textBox2, rectb2);
            resize_Control(label1, reclb1);
            resize_Control(label2, reclb2);
            resize_Control(label3, reclb3);
            resize_Control(label4, reclb4);
            resize_Control(label13, reclb13);
            resize_Control(linkLabel1, reclinklbl1);
            resize_Control(linkLabel2, reclinklbl2);
            resize_Control(guna2GradientTileButton1, recgb1);
            resize_Control(pictureBox1, recpb1);
            resize_Control(pictureBox2, recpb2);
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
    }
}




