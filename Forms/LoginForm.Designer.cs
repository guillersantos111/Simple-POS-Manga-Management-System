namespace PosoManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            Exit = new Label();
            Login_BTN = new Button();
            Login_ShowPassword = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            tb_username = new TextBox();
            SignUp_BTN = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel4 = new Panel();
            lbl_Exit = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_password = new TextBox();
            lbl_ForgotPassword = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(-2, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 732);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cooper Black", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(307, 56);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 12;
            label3.Text = "STUDIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(147, 31);
            label1.Name = "label1";
            label1.Size = new Size(335, 55);
            label1.TabIndex = 11;
            label1.Text = "ANIMATRIX";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.Anime_Kawaii_Cute_Dance_Animated_Gif_Image_Hot_Super;
            pictureBox3.Location = new Point(148, 163);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(334, 356);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.BackColor = Color.White;
            Exit.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.Black;
            Exit.Location = new Point(927, 13);
            Exit.Name = "Exit";
            Exit.Size = new Size(23, 24);
            Exit.TabIndex = 1;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // Login_BTN
            // 
            Login_BTN.BackColor = Color.MidnightBlue;
            Login_BTN.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_BTN.ForeColor = SystemColors.ButtonHighlight;
            Login_BTN.Location = new Point(883, 476);
            Login_BTN.Name = "Login_BTN";
            Login_BTN.Size = new Size(254, 52);
            Login_BTN.TabIndex = 8;
            Login_BTN.Text = "Login";
            Login_BTN.UseVisualStyleBackColor = false;
            Login_BTN.Click += Login_BTN_Click;
            // 
            // Login_ShowPassword
            // 
            Login_ShowPassword.AutoSize = true;
            Login_ShowPassword.BackColor = Color.White;
            Login_ShowPassword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_ShowPassword.Location = new Point(893, 426);
            Login_ShowPassword.Name = "Login_ShowPassword";
            Login_ShowPassword.Size = new Size(150, 22);
            Login_ShowPassword.TabIndex = 9;
            Login_ShowPassword.Text = "ShowPassword";
            Login_ShowPassword.UseVisualStyleBackColor = false;
            Login_ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_50;
            pictureBox1.Location = new Point(831, 298);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_50;
            pictureBox2.Location = new Point(830, 372);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(865, 148);
            label2.Name = "label2";
            label2.Size = new Size(272, 88);
            label2.TabIndex = 12;
            label2.Text = "ADMIN LOGIN\r\n  ANICCOUNT";
            // 
            // tb_username
            // 
            tb_username.BackColor = Color.White;
            tb_username.Cursor = Cursors.IBeam;
            tb_username.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_username.ForeColor = SystemColors.ActiveCaptionText;
            tb_username.Location = new Point(883, 293);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.RightToLeft = RightToLeft.No;
            tb_username.Size = new Size(254, 52);
            tb_username.TabIndex = 2;
            tb_username.TextAlign = HorizontalAlignment.Center;
            // 
            // SignUp_BTN
            // 
            SignUp_BTN.BackColor = Color.MidnightBlue;
            SignUp_BTN.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUp_BTN.ForeColor = SystemColors.ButtonHighlight;
            SignUp_BTN.Location = new Point(883, 534);
            SignUp_BTN.Name = "SignUp_BTN";
            SignUp_BTN.Size = new Size(254, 52);
            SignUp_BTN.TabIndex = 13;
            SignUp_BTN.Text = "Sign Up";
            SignUp_BTN.UseVisualStyleBackColor = false;
            SignUp_BTN.Click += SignUp_BTN_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(lbl_Exit);
            panel4.Location = new Point(-2, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1339, 71);
            panel4.TabIndex = 16;
            // 
            // lbl_Exit
            // 
            lbl_Exit.AutoSize = true;
            lbl_Exit.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Exit.ForeColor = Color.Transparent;
            lbl_Exit.Location = new Point(1307, -1);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new Size(31, 27);
            lbl_Exit.TabIndex = 0;
            lbl_Exit.Text = "X";
            lbl_Exit.Click += lbl_Exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(842, 734);
            label4.Name = "label4";
            label4.Size = new Size(374, 30);
            label4.TabIndex = 13;
            label4.Text = "Enter your username and password to sign in. Don't have an account?\r\nClick 'Sign Up' to join our community of readers and manga fans.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(892, 282);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 43;
            label5.Text = "EMAIL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(893, 357);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 44;
            label6.Text = "PASSWORD:";
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_password.BackColor = Color.White;
            tb_password.Cursor = Cursors.IBeam;
            tb_password.Font = new Font("Arial", 14.25F);
            tb_password.ForeColor = SystemColors.ActiveCaptionText;
            tb_password.Location = new Point(883, 368);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.RightToLeft = RightToLeft.No;
            tb_password.Size = new Size(254, 52);
            tb_password.TabIndex = 3;
            tb_password.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl_ForgotPassword
            // 
            lbl_ForgotPassword.AutoSize = true;
            lbl_ForgotPassword.BackColor = Color.Transparent;
            lbl_ForgotPassword.Cursor = Cursors.Hand;
            lbl_ForgotPassword.Font = new Font("Gadugi", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ForgotPassword.ForeColor = Color.MidnightBlue;
            lbl_ForgotPassword.Location = new Point(915, 603);
            lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            lbl_ForgotPassword.Size = new Size(196, 21);
            lbl_ForgotPassword.TabIndex = 45;
            lbl_ForgotPassword.Text = "FORGOT PASSWORD";
            lbl_ForgotPassword.Click += lbl_ForgotPassword_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1336, 791);
            Controls.Add(lbl_ForgotPassword);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(SignUp_BTN);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Login_ShowPassword);
            Controls.Add(Login_BTN);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(Exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Exit;
        private Button Login_BTN;
        private CheckBox Login_ShowPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_username;
        private Button SignUp_BTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_password;
        private Label lbl_Exit;
        private Label lbl_ForgotPassword;
    }
}
