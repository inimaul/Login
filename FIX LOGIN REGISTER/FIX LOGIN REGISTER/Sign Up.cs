using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIX_LOGIN_REGISTER
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            textBox3.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            textBox4.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
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
            textBox5.AutoSize = false;
            textBox5.Height = 32;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
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

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {

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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            textBox8.Focus();
        }

        private void textBox8_Click(object sender, EventArgs e)
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
            if (textBox3.Text == "")
            {
                label10.Show();
            }
            if (textBox1.Text == "")
            {
                label13.Show();
            }
            if (textBox2.Text == "")
            {
                label14.Show();
            }
            if (textBox4.Text == "")
            {
                label11.Show();
            }
            if (textBox5.Text == "")
            {
                label12.Show();
            }
            if (textBox4.Text == "")
            {
                label11.Show();
            }
            if (textBox7.Text == "")
            {
                label18.Show();
            }

            else
            {

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
            textBox7.AutoSize = false;
            textBox7.Height = 32;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                label15.Text = "Please enter your mother's name";
            }
            else
            {
                label15.Text = "";
            }
            textBox6.AutoSize = false;
            textBox6.Height = 32;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            label15.Visible = false;
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
    }
}
