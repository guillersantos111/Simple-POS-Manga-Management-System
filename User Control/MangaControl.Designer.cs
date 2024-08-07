namespace PosoManagementSystem.User_Control
{
    partial class MangaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pb_CoverImage = new PictureBox();
            lbl_Price = new Label();
            panel = new Panel();
            lbl_ID = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_CoverImage).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pb_CoverImage
            // 
            pb_CoverImage.Cursor = Cursors.Hand;
            pb_CoverImage.Location = new Point(15, 12);
            pb_CoverImage.Margin = new Padding(4, 3, 4, 3);
            pb_CoverImage.Name = "pb_CoverImage";
            pb_CoverImage.Size = new Size(216, 245);
            pb_CoverImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_CoverImage.TabIndex = 0;
            pb_CoverImage.TabStop = false;
            pb_CoverImage.Click += pb_CoverImage_Click_1;
            // 
            // lbl_Price
            // 
            lbl_Price.AutoSize = true;
            lbl_Price.Cursor = Cursors.Hand;
            lbl_Price.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Price.Location = new Point(88, 5);
            lbl_Price.Margin = new Padding(4, 0, 4, 0);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(13, 19);
            lbl_Price.TabIndex = 3;
            lbl_Price.Text = " ";
            lbl_Price.Click += lbl_Price_Click;
            // 
            // panel
            // 
            panel.Controls.Add(lbl_Price);
            panel.Location = new Point(11, 257);
            panel.Name = "panel";
            panel.Size = new Size(224, 28);
            panel.TabIndex = 4;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.BackColor = Color.Transparent;
            lbl_ID.Cursor = Cursors.Hand;
            lbl_ID.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ID.Location = new Point(3, 3);
            lbl_ID.Margin = new Padding(4, 0, 4, 0);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(15, 23);
            lbl_ID.TabIndex = 4;
            lbl_ID.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.animetrix;
            pictureBox1.Location = new Point(197, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MangaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbl_ID);
            Controls.Add(pictureBox1);
            Controls.Add(panel);
            Controls.Add(pb_CoverImage);
            Margin = new Padding(15);
            Name = "MangaControl";
            Size = new Size(245, 298);
            ((System.ComponentModel.ISupportInitialize)pb_CoverImage).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pb_CoverImage;
        private PictureBox pictureBox1;
        private Label lbl_ID;
    }
}
