namespace FIX_LOGIN_REGISTER
{
    partial class Forgot_Password_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password_1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(762, 476);
            label1.Name = "label1";
            label1.Size = new Size(329, 33);
            label1.TabIndex = 7;
            label1.Text = "Enter your mother's name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(762, 475);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(396, 29);
            textBox1.TabIndex = 6;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(755, 544);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(269, 36);
            dateTimePicker1.TabIndex = 22;
            // 
            // guna2GradientTileButton1
            // 
            guna2GradientTileButton1.BorderRadius = 14;
            guna2GradientTileButton1.CustomizableEdges = customizableEdges1;
            guna2GradientTileButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientTileButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientTileButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientTileButton1.FillColor = Color.FromArgb(8, 102, 255);
            guna2GradientTileButton1.FillColor2 = Color.FromArgb(8, 186, 255);
            guna2GradientTileButton1.Font = new Font("Montserrat SemiBold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            guna2GradientTileButton1.ForeColor = Color.White;
            guna2GradientTileButton1.Location = new Point(757, 784);
            guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            guna2GradientTileButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientTileButton1.Size = new Size(408, 58);
            guna2GradientTileButton1.TabIndex = 23;
            guna2GradientTileButton1.Text = "Reset Password";
            guna2GradientTileButton1.Click += guna2GradientTileButton1_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(762, 682);
            label3.Name = "label3";
            label3.Size = new Size(235, 33);
            label3.TabIndex = 29;
            label3.Text = "Confirm Password";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.FromArgb(64, 64, 64);
            textBox3.Location = new Point(762, 681);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(376, 29);
            textBox3.TabIndex = 28;
            textBox3.Click += textBox3_Click;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(762, 616);
            label2.Name = "label2";
            label2.Size = new Size(193, 33);
            label2.TabIndex = 27;
            label2.Text = "New Password";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(762, 616);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(376, 29);
            textBox2.TabIndex = 26;
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(762, 411);
            label4.Name = "label4";
            label4.Size = new Size(139, 33);
            label4.TabIndex = 25;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Montserrat", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.FromArgb(64, 64, 64);
            textBox4.Location = new Point(762, 411);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(376, 29);
            textBox4.TabIndex = 24;
            textBox4.Click += textBox4_Click;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox4.KeyDown += textBox4_KeyDown;
            // 
            // Forgot_Password_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(guna2GradientTileButton1);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Forgot_Password_1";
            Text = "Forgot_Password_1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
    }
}