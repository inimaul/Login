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
            if (textBox1.Text == "")
            {
                label13.Text = "Invalid Username";
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
                label4.Text = "Please Enter Password";
            }
            else
            {
                label4.Text = "";
            }
            textBox2.AutoSize = false;
            textBox2.Height = 32;
            textBox2.PasswordChar = '*';
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

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
            Sign_Up signup = new Sign_Up();
            signup.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password_1 forgotpw1 = new Forgot_Password_1();
            forgotpw1.Show();
            this.Hide();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label13.Show();
            }
            if (textBox1.Text == "")
            {
                label4.Show();
            }
        }
    }
}