using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIX_LOGIN_REGISTER
{
    public partial class Forgot_Password_1 : Form
    {
        public Forgot_Password_1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.AutoSize = false;

            textBox1.Height = 32;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            label1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            string password = GetSHA256Hash(textBox2.Text);
            string confirm = GetSHA256Hash(textBox3.Text);
            if (password != confirm)
            {
                MessageBox.Show("Your New Password and Confirm Password Is Not Match");
                return;
            }
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=jecation;User Id=postgres;Password=Yus2064.;");
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE akun SET password_akun = (@password) WHERE username_akun = @username AND nama_ibu = @namaibu AND tgl_lahir_ibu = @hbdibu";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new NpgsqlParameter("@username", textBox4.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@namaibu", textBox1.Text));
                string tgl_lahir_ibu = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                cmd.Parameters.Add(new NpgsqlParameter("@hbdibu", NpgsqlTypes.NpgsqlDbType.Date));
                cmd.Parameters["@hbdibu"].Value = DateTime.Parse(tgl_lahir_ibu); 
                cmd.Parameters.Add(new NpgsqlParameter("@password", password));

                int eksekusi = cmd.ExecuteNonQuery();
                if (eksekusi > 0)
                {
                    MessageBox.Show("Password Successfully Changed");
                    new Form1().Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Data User Is Invalid");
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            //if (eksekusi > 0)
            //{
            //    MessageBox.Show("Password Successfully Changed");
            //    Form1 f1 = new Form1();
            //    this.Hide();
            //    f1.Show();
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Data User Is Invalid");
            //    return;
            //}


            static string GetSHA256Hash(string input)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                    return BitConverter.ToString(bytes).Replace("-", "").ToLower();
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox4.Focus();
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            label4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            label2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            label3.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.AutoSize = false;
            textBox4.Height = 32;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.AutoSize = false;
            textBox2.Height = 32;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.AutoSize = false;
            textBox3.Height = 32;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Focus();
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            label4.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox3.Text == "") { label3.Visible = true; } else { label3.Visible = false; }
            label2.Visible = false;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
            if (textBox1.Text == "") { label1.Visible = true; } else { label1.Visible = false; }
            if (textBox4.Text == "") { label4.Visible = true; } else { label4.Visible = false; }
            if (textBox2.Text == "") { label2.Visible = true; } else { label2.Visible = false; }
            label3.Visible = false;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                textBox1.Focus();
                label1.Visible = false;
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
    }
}
