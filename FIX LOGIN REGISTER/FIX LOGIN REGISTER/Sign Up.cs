using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace FIX_LOGIN_REGISTER
{
    public partial class Sign_Up : Form
    {

        private NpgsqlConnection connection;
        private string connectionString = "Server=localhost; Port =5432; user id=postgres; Password=Yus2064.; Database=jecation;";

        public Sign_Up()
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);
            FillProvinces();

        }
        private void FillProvinces()
        {
            try
            {
                string query = "SELECT * FROM reg_province";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                DataTable provinceTable = new DataTable();
                adapter.Fill(provinceTable);
                comboBox3.DisplayMember = "name";
                comboBox3.ValueMember = "id_province";
                comboBox3.DataSource = provinceTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengisi data provinsi: " + ex.Message);
            }
        }
        private void FillKab(int provinceid)
        {
            try
            {
                string query = "SELECT * FROM reg_kabupaten WHERE id_province = @id_province";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id_province", provinceid);
                DataTable cityTable = new DataTable();
                adapter.Fill(cityTable);
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id_kab";
                comboBox2.DataSource = cityTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengisi data kota/kabupaten: " + ex.Message);
            }
        }
        private void FillKec(int kabId)
        {
            try
            {
                string query = "SELECT * FROM reg_kecamatan WHERE id_kab = @id_kab";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id_kab", kabId);
                DataTable districtTable = new DataTable();
                adapter.Fill(districtTable);
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id_kec";
                comboBox1.DataSource = districtTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengisi data kecamatan: " + ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox2.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox3.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox4.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox5.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label13.Text = "Please enter firsth name";
            }
            else
            {
                label13.Text = "";
            }
            label1.Visible = false;
            textBox1.AutoSize = false;
            textBox1.Height = 32;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label14.Text = "Please enter last name";
            }
            else
            {
                label14.Text = "";
            }
            label2.Visible = false;
            textBox2.AutoSize = false;
            textBox2.Height = 32;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                label10.Text = "Please enter username";
            }
            else
            {
                label10.Text = "";
            }
            label3.Visible = false;
            textBox3.AutoSize = false;
            textBox3.Height = 32;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                label11.Text = "Please enter password";
            }
            else
            {
                label11.Text = "";
            }
            label4.Visible = false;
            textBox4.AutoSize = false;
            textBox4.Height = 32;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                label12.Text = "Please enter confirm password";
            }
            else
            {
                label12.Text = "";
            }
            label5.Visible = false;
            textBox5.AutoSize = false;
            textBox5.Height = 32;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label5.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox3.Focus();
                label3.Visible = false;
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox4.Focus();
                label4.Visible = false;
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox5.Focus();
                label5.Visible = false;
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox6.Focus();
                label15.Visible = false;
            }
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void label9_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string nik = textBox7.Text;
                    string nama_ibu = textBox6.Text;
                    string firstname = textBox1.Text;
                    string lastname = textBox2.Text;
                    string username_akun = textBox3.Text;
                    string password = textBox4.Text;
                    string confirm = textBox5.Text;
                    string provinsi = comboBox3.Text;
                    string kabupaten = comboBox2.Text;
                    string kecamatan = comboBox1.Text;
                    string password_akun = GetSHA256Hash(password);
                    string confhash = GetSHA256Hash(confirm);



                    if (password_akun != confhash)
                    {
                        MessageBox.Show("Password dan Confirm Passsword do not match");

                        return;

                    }



                    string checkUsernameQuery = "SELECT COUNT(*) FROM akun WHERE username_akun = @username_akun";

                    using (NpgsqlCommand checkUsernameCommand = new NpgsqlCommand(checkUsernameQuery, connection))
                    {
                        checkUsernameCommand.Parameters.AddWithValue("username_akun", username_akun);

                        int usernameCount = Convert.ToInt32(checkUsernameCommand.ExecuteScalar());

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username sudah digunakan.");
                            username_akun = "";
                            return;
                        }
                    }




                    string insertDataQuery = "insert into akun(firstname, lastname, username_akun, password_akun, nik, nama_ibu, tgl_lahir_ibu, provinsi,kabupaten,kecamatan) values (@firstname, @lastname, @username_akun, @password_akun, @nik, @nama_ibu, @tgl_lahir_ibu, @provinsi, @kecamatan, @kabupaten)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertDataQuery, connection))
                    {
                        if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(username_akun) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm) || string.IsNullOrEmpty(nik) || string.IsNullOrEmpty(nama_ibu))
                        {
                            MessageBox.Show("Please fill in your personal data before register");
                            if (textBox1.Text == "")
                            {
                                label13.Show();
                            }
                            else
                            {
                                label13.Hide();
                            }
                            if (textBox2.Text == "")
                            {
                                label14.Show();
                            }
                            else { label14.Hide(); }
                            if (textBox3.Text == "")
                            {
                                label10.Show();
                            }
                            else
                            {
                                label10.Hide();
                            }
                            if (textBox4.Text == "")
                            {
                                label11.Show();
                            }
                            else
                            {
                                label11.Hide();
                            }
                            if (textBox5.Text == "")
                            {
                                label12.Show();
                            }
                            else
                            {
                                label12.Hide();
                            }
                            if (textBox7.Text == "")
                            {
                                label18.Show();
                            }
                            else
                            {
                                label18.Hide();
                            }
                            return;
                        }
                        else if (nik.Length != 16)
                        {
                            MessageBox.Show("NIK length must be 16 digits");
                            label18.Text = "NIK must 16 digits";
                            return;
                        }
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@username_akun", username_akun);
                        cmd.Parameters.AddWithValue("@password_akun", password_akun);
                        cmd.Parameters.AddWithValue("@nik", nik);
                        cmd.Parameters.AddWithValue("@nama_ibu", nama_ibu);
                        cmd.Parameters.AddWithValue("@tgl_lahir_ibu", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@kecamatan", kecamatan);
                        cmd.Parameters.AddWithValue("@kabupaten", kabupaten);
                        cmd.Parameters.AddWithValue("@provinsi", provinsi);

                        int eksekusi = cmd.ExecuteNonQuery();

                        if (eksekusi > 0)
                        {
                            MessageBox.Show("Sign up succesfull");
                            new Form1().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to Sign Up");
                        }
                        connection.Close();
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }




        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            label17.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label15.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            textBox7.Focus();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                label18.Text = "Please enter NIK";
            }
            else
            {
                label18.Text = "";
            }
            label17.Visible = false;
            textBox7.AutoSize = false;
            textBox7.Height = 32;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            label17.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox6.Text == "") { label15.Visible = true; } else { label5.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }

        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label15.Visible = false;
            textBox6.AutoSize = false;
            textBox6.Height = 32;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox5.Text == "") { label5.Visible = true; } else { label5.Visible = false; }
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox7.Text == "") { label17.Visible = true; } else { label17.Visible = false; }
            textBox6.Focus();
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox1.Focus();
                label1.Visible = false;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue != null)
            {
                int SelectedProvinceId = Convert.ToInt32(comboBox3.SelectedValue);
                FillKab(SelectedProvinceId);

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null)
            {
                int selectedCity = Convert.ToInt32(comboBox2.SelectedValue);
                FillKec(selectedCity);


            }
        }

    }
}
