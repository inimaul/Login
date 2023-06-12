using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            label1.Visible = false;
            label1.Visible = false;
            textBox1.Focus();
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

        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox4.Focus();
            label4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            label2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
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
            label4.Visible = false;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            label2.Visible = false;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
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
