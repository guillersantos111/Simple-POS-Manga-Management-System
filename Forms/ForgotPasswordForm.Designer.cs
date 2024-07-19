namespace PosoManagementSystem.Forms
{
    partial class ForgotPasswordForm
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
            panel4 = new Panel();
            lbl_Exit_ = new Label();
            lbl_Exit = new Label();
            ForgotPassword_ShowPassword = new CheckBox();
            tb_NewPassword = new TextBox();
            tb_username = new TextBox();
            label2 = new Label();
            btn_ResetPassword = new Button();
            tb_ConfirmPassword = new TextBox();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Indigo;
            panel4.Controls.Add(lbl_Exit_);
            panel4.Controls.Add(lbl_Exit);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(470, 48);
            panel4.TabIndex = 17;
            // 
            // lbl_Exit_
            // 
            lbl_Exit_.AutoSize = true;
            lbl_Exit_.BackColor = Color.Indigo;
            lbl_Exit_.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Exit_.ForeColor = Color.Transparent;
            lbl_Exit_.Location = new Point(449, -1);
            lbl_Exit_.Name = "lbl_Exit_";
            lbl_Exit_.Size = new Size(20, 23);
            lbl_Exit_.TabIndex = 54;
            lbl_Exit_.Text = "X";
            lbl_Exit_.Click += lbl_Exit__Click;
            // 
            // lbl_Exit
            // 
            lbl_Exit.AutoSize = true;
            lbl_Exit.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Exit.ForeColor = Color.Black;
            lbl_Exit.Location = new Point(1307, -1);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new Size(31, 27);
            lbl_Exit.TabIndex = 0;
            lbl_Exit.Text = "X";
            // 
            // ForgotPassword_ShowPassword
            // 
            ForgotPassword_ShowPassword.AutoSize = true;
            ForgotPassword_ShowPassword.BackColor = Color.Transparent;
            ForgotPassword_ShowPassword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForgotPassword_ShowPassword.Location = new Point(116, 283);
            ForgotPassword_ShowPassword.Name = "ForgotPassword_ShowPassword";
            ForgotPassword_ShowPassword.Size = new Size(150, 22);
            ForgotPassword_ShowPassword.TabIndex = 48;
            ForgotPassword_ShowPassword.Text = "ShowPassword";
            ForgotPassword_ShowPassword.UseVisualStyleBackColor = false;
            ForgotPassword_ShowPassword.CheckedChanged += ForgotPassword_ShowPassword_CheckedChanged;
            // 
            // tb_NewPassword
            // 
            tb_NewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_NewPassword.BackColor = Color.White;
            tb_NewPassword.Cursor = Cursors.IBeam;
            tb_NewPassword.Font = new Font("Arial", 14.25F);
            tb_NewPassword.ForeColor = SystemColors.ActiveCaptionText;
            tb_NewPassword.Location = new Point(116, 195);
            tb_NewPassword.Multiline = true;
            tb_NewPassword.Name = "tb_NewPassword";
            tb_NewPassword.PasswordChar = '*';
            tb_NewPassword.PlaceholderText = "New Password";
            tb_NewPassword.RightToLeft = RightToLeft.No;
            tb_NewPassword.Size = new Size(236, 38);
            tb_NewPassword.TabIndex = 47;
            tb_NewPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_username
            // 
            tb_username.BackColor = Color.White;
            tb_username.Cursor = Cursors.IBeam;
            tb_username.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_username.ForeColor = SystemColors.ActiveCaptionText;
            tb_username.Location = new Point(116, 151);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.PlaceholderText = "Email";
            tb_username.RightToLeft = RightToLeft.No;
            tb_username.Size = new Size(236, 38);
            tb_username.TabIndex = 46;
            tb_username.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Gadugi", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(148, 60);
            label2.Name = "label2";
            label2.Size = new Size(172, 64);
            label2.TabIndex = 52;
            label2.Text = "    FORGOT\r\n PASSWORD";
            // 
            // btn_ResetPassword
            // 
            btn_ResetPassword.BackColor = Color.Indigo;
            btn_ResetPassword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ResetPassword.ForeColor = SystemColors.ButtonHighlight;
            btn_ResetPassword.Location = new Point(116, 323);
            btn_ResetPassword.Name = "btn_ResetPassword";
            btn_ResetPassword.Size = new Size(236, 38);
            btn_ResetPassword.TabIndex = 53;
            btn_ResetPassword.Text = "Reset";
            btn_ResetPassword.UseVisualStyleBackColor = false;
            btn_ResetPassword.Click += btn_ResetPassword_Click;
            // 
            // tb_ConfirmPassword
            // 
            tb_ConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_ConfirmPassword.BackColor = Color.White;
            tb_ConfirmPassword.Cursor = Cursors.IBeam;
            tb_ConfirmPassword.Font = new Font("Arial", 14.25F);
            tb_ConfirmPassword.ForeColor = SystemColors.ActiveCaptionText;
            tb_ConfirmPassword.Location = new Point(116, 239);
            tb_ConfirmPassword.Multiline = true;
            tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            tb_ConfirmPassword.PasswordChar = '*';
            tb_ConfirmPassword.PlaceholderText = "Confirm Password";
            tb_ConfirmPassword.RightToLeft = RightToLeft.No;
            tb_ConfirmPassword.Size = new Size(236, 38);
            tb_ConfirmPassword.TabIndex = 54;
            tb_ConfirmPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 385);
            Controls.Add(tb_ConfirmPassword);
            Controls.Add(btn_ResetPassword);
            Controls.Add(label2);
            Controls.Add(ForgotPassword_ShowPassword);
            Controls.Add(tb_NewPassword);
            Controls.Add(tb_username);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPasswordForm";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Label lbl_Exit;
        private CheckBox ForgotPassword_ShowPassword;
        private TextBox tb_NewPassword;
        private TextBox tb_username;
        private Label label2;
        private Label lbl_Exit_;
        private Button btn_ResetPassword;
        private TextBox tb_ConfirmPassword;
    }
}