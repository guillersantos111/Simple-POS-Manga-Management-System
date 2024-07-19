namespace PosoManagementSystem.Controller_Design
{
    partial class SignupForm
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
            Exit = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            Signup_ShowPassword = new CheckBox();
            Signup_BTN = new Button();
            tb_password = new TextBox();
            tb_username = new TextBox();
            tb_lastname = new TextBox();
            tb_firstname = new TextBox();
            Login_BTN2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel4 = new Panel();
            lbl_Exit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(784, -51);
            Exit.Name = "Exit";
            Exit.Size = new Size(23, 24);
            Exit.TabIndex = 15;
            Exit.Text = "X";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(647, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 794);
            panel1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(332, 136);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 14;
            label3.Text = "STUDIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(173, 114);
            label1.Name = "label1";
            label1.Size = new Size(335, 55);
            label1.TabIndex = 13;
            label1.Text = "ANIMATRIX";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.tumblr_static_filename_640_v2;
            pictureBox3.Location = new Point(174, 233);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(334, 356);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(173, 102);
            label2.Name = "label2";
            label2.Size = new Size(248, 88);
            label2.TabIndex = 26;
            label2.Text = "   REGISTER\r\n ANICCOUNT";
            // 
            // Signup_ShowPassword
            // 
            Signup_ShowPassword.AutoSize = true;
            Signup_ShowPassword.BackColor = Color.White;
            Signup_ShowPassword.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Signup_ShowPassword.Location = new Point(182, 519);
            Signup_ShowPassword.Name = "Signup_ShowPassword";
            Signup_ShowPassword.Size = new Size(126, 19);
            Signup_ShowPassword.TabIndex = 24;
            Signup_ShowPassword.Text = "ShowPassword";
            Signup_ShowPassword.UseVisualStyleBackColor = false;
            Signup_ShowPassword.CheckedChanged += Signup_ShowPassword_CheckedChanged;
            // 
            // Signup_BTN
            // 
            Signup_BTN.BackColor = Color.RoyalBlue;
            Signup_BTN.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Signup_BTN.ForeColor = SystemColors.ButtonHighlight;
            Signup_BTN.Location = new Point(172, 568);
            Signup_BTN.Name = "Signup_BTN";
            Signup_BTN.Size = new Size(254, 52);
            Signup_BTN.TabIndex = 23;
            Signup_BTN.Text = "Sign in";
            Signup_BTN.UseVisualStyleBackColor = false;
            Signup_BTN.Click += Signup_BTN_Click;
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_password.BackColor = Color.White;
            tb_password.Cursor = Cursors.IBeam;
            tb_password.Font = new Font("Arial", 14.25F);
            tb_password.ForeColor = SystemColors.ActiveCaptionText;
            tb_password.Location = new Point(171, 461);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.RightToLeft = RightToLeft.No;
            tb_password.Size = new Size(254, 52);
            tb_password.TabIndex = 18;
            tb_password.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_username
            // 
            tb_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_username.BackColor = Color.White;
            tb_username.Cursor = Cursors.IBeam;
            tb_username.Font = new Font("Arial", 14.25F);
            tb_username.ForeColor = SystemColors.ActiveCaptionText;
            tb_username.Location = new Point(171, 389);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.RightToLeft = RightToLeft.No;
            tb_username.Size = new Size(254, 52);
            tb_username.TabIndex = 17;
            tb_username.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_lastname
            // 
            tb_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_lastname.BackColor = Color.White;
            tb_lastname.Cursor = Cursors.IBeam;
            tb_lastname.Font = new Font("Arial", 14.25F);
            tb_lastname.ForeColor = SystemColors.ActiveCaptionText;
            tb_lastname.Location = new Point(172, 318);
            tb_lastname.Multiline = true;
            tb_lastname.Name = "tb_lastname";
            tb_lastname.RightToLeft = RightToLeft.No;
            tb_lastname.Size = new Size(254, 52);
            tb_lastname.TabIndex = 27;
            tb_lastname.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_firstname
            // 
            tb_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_firstname.BackColor = Color.White;
            tb_firstname.Cursor = Cursors.IBeam;
            tb_firstname.Font = new Font("Arial", 14.25F);
            tb_firstname.ForeColor = SystemColors.ActiveCaptionText;
            tb_firstname.Location = new Point(171, 248);
            tb_firstname.Multiline = true;
            tb_firstname.Name = "tb_firstname";
            tb_firstname.RightToLeft = RightToLeft.No;
            tb_firstname.Size = new Size(254, 52);
            tb_firstname.TabIndex = 28;
            tb_firstname.TextAlign = HorizontalAlignment.Center;
            // 
            // Login_BTN2
            // 
            Login_BTN2.BackColor = Color.RoyalBlue;
            Login_BTN2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_BTN2.ForeColor = SystemColors.ButtonHighlight;
            Login_BTN2.Location = new Point(172, 636);
            Login_BTN2.Name = "Login_BTN2";
            Login_BTN2.Size = new Size(254, 52);
            Login_BTN2.TabIndex = 33;
            Login_BTN2.Text = "Login";
            Login_BTN2.UseVisualStyleBackColor = false;
            Login_BTN2.Click += Login_BTN2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_50;
            pictureBox1.Location = new Point(123, 393);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_50;
            pictureBox2.Location = new Point(123, 467);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_add_user_male_64;
            pictureBox4.Location = new Point(123, 252);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(47, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_add_user_male_64;
            pictureBox5.Location = new Point(124, 323);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 40;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(111, 737);
            label4.Name = "label4";
            label4.Size = new Size(390, 30);
            label4.TabIndex = 41;
            label4.Text = "Welcome to Animatrix! Please fill in the fields to create your account and\r\njoin our vibrant community of readers and manga enthusiasts.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(181, 238);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 42;
            label5.Text = "FIRST NAME:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(181, 308);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 43;
            label6.Text = "LAST NAME:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(181, 379);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 44;
            label7.Text = "EMAIL:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(181, 451);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 45;
            label8.Text = "PASSWORD:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(lbl_Exit);
            panel4.Location = new Point(-2, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1339, 71);
            panel4.TabIndex = 46;
            // 
            // lbl_Exit
            // 
            lbl_Exit.AutoSize = true;
            lbl_Exit.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Exit.ForeColor = Color.Transparent;
            lbl_Exit.Location = new Point(1308, -1);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new Size(31, 27);
            lbl_Exit.TabIndex = 1;
            lbl_Exit.Text = "X";
            lbl_Exit.Click += lbl_Exit_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1336, 791);
            Controls.Add(panel4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Login_BTN2);
            Controls.Add(tb_firstname);
            Controls.Add(tb_lastname);
            Controls.Add(label2);
            Controls.Add(Signup_ShowPassword);
            Controls.Add(Signup_BTN);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(Exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Exit;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label2;
        private CheckBox Signup_ShowPassword;
        private Button Signup_BTN;
        private TextBox tb_password;
        private TextBox tb_username;
        private TextBox tb_lastname;
        private TextBox tb_firstname;
        private Button Login_BTN2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label1;
        private Label label3;
        private Panel panel4;
        private Label lbl_Exit;
    }
}