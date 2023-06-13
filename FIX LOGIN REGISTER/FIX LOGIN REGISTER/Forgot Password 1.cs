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
        private Size formOriginalSize;
        private Rectangle rectb1;
        private Rectangle rectb2;
        private Rectangle rectb3;
        private Rectangle rectb4;
        private Rectangle reclb1;
        private Rectangle reclb2;
        private Rectangle reclb3;
        private Rectangle reclb4;
        private Rectangle recdtp1;
        private Rectangle recgb1;
        private Rectangle recpb1;
        public Forgot_Password_1()
        {
            InitializeComponent();
            this.Resize += Forgot_Password_1_Resize;
            formOriginalSize = this.Size;
            rectb1 = new Rectangle(textBox1.Location, textBox1.Size);
            rectb2 = new Rectangle(textBox2.Location, textBox2.Size);
            rectb1 = new Rectangle(textBox3.Location, textBox3.Size);
            rectb2 = new Rectangle(textBox4.Location, textBox4.Size);
            reclb1 = new Rectangle(label1.Location, label1.Size);
            reclb2 = new Rectangle(label2.Location, label2.Size);
            reclb3 = new Rectangle(label3.Location, label3.Size);
            reclb4 = new Rectangle(label4.Location, label4.Size);
            recdtp1 = new Rectangle(dateTimePicker1.Location, dateTimePicker1.Size);
            recgb1 = new Rectangle(guna2GradientTileButton1.Location, guna2GradientTileButton1.Size);
            recpb1 = new Rectangle(pictureBox1.Location, pictureBox1.Size);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.AutoSize = false;

            //textBox1.Height = 32;
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
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=jecation;User Id=postgres;Password=;");
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
            //textBox4.AutoSize = false;
            //textBox4.Height = 32;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.AutoSize = false;
            //textBox2.Height = 32;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textBox3.AutoSize = false;
            //textBox3.Height = 32;
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

        private void Forgot_Password_1_Resize(object sender, EventArgs e)
        {
            resize_Control(textBox1, rectb1);
            resize_Control(textBox2, rectb2);
            resize_Control(textBox3, rectb3);
            resize_Control(textBox4, rectb4);
            resize_Control(label1, reclb1);
            resize_Control(label2, reclb2);
            resize_Control(label3, reclb3);
            resize_Control(label4, reclb4);
            resize_Control(dateTimePicker1, recdtp1);
            resize_Control(guna2GradientTileButton1, recgb1);
            resize_Control(pictureBox1, recpb1);
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
