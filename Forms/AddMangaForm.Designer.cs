namespace PosoManagementSystem.Forms
{
    partial class AddMangaForm
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
            panel9 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            pb_CoverImage = new PictureBox();
            pb_Clear = new PictureBox();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_AddManga = new Button();
            btn_Browse = new Button();
            txt_Tax = new TextBox();
            txt_Price = new TextBox();
            txt_Genre = new TextBox();
            txt_Author = new TextBox();
            txt_Title = new TextBox();
            sidebar = new Panel();
            btn_Home = new Button();
            lv_PurchaseHistory = new ListView();
            ID = new ColumnHeader();
            TotalAmount = new ColumnHeader();
            _TotalTax = new ColumnHeader();
            _PurchaseDate = new ColumnHeader();
            btn_AddProduct = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btn_Logout = new Button();
            panel7 = new Panel();
            flp_AddManga = new FlowLayoutPanel();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_CoverImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Clear).BeginInit();
            sidebar.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackColor = Color.WhiteSmoke;
            panel9.Controls.Add(panel3);
            panel9.Location = new Point(0, -1);
            panel9.Name = "panel9";
            panel9.Size = new Size(1338, 70);
            panel9.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(0, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1338, 64);
            panel3.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.animetrix;
            pictureBox1.Location = new Point(6, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(89, 18);
            label6.Name = "label6";
            label6.Size = new Size(160, 29);
            label6.TabIndex = 31;
            label6.Text = "MANGA POS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(120, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(1156, 49);
            panel2.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(245, 24);
            label1.TabIndex = 33;
            label1.Text = "ADD MANGA PRODUCT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pb_Clear);
            panel1.Controls.Add(btn_Delete);
            panel1.Controls.Add(btn_Update);
            panel1.Controls.Add(btn_AddManga);
            panel1.Controls.Add(btn_Browse);
            panel1.Controls.Add(txt_Tax);
            panel1.Controls.Add(txt_Price);
            panel1.Controls.Add(txt_Genre);
            panel1.Controls.Add(txt_Author);
            panel1.Controls.Add(txt_Title);
            panel1.Location = new Point(105, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 625);
            panel1.TabIndex = 37;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(pb_CoverImage);
            panel4.Location = new Point(303, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 289);
            panel4.TabIndex = 34;
            // 
            // pb_CoverImage
            // 
            pb_CoverImage.Cursor = Cursors.Hand;
            pb_CoverImage.Image = Properties.Resources.animetrix;
            pb_CoverImage.Location = new Point(7, 5);
            pb_CoverImage.Name = "pb_CoverImage";
            pb_CoverImage.Size = new Size(235, 279);
            pb_CoverImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_CoverImage.TabIndex = 6;
            pb_CoverImage.TabStop = false;
            // 
            // pb_Clear
            // 
            pb_Clear.BackColor = Color.White;
            pb_Clear.Cursor = Cursors.Hand;
            pb_Clear.Image = Properties.Resources.icons8_reset_40;
            pb_Clear.Location = new Point(519, 42);
            pb_Clear.Name = "pb_Clear";
            pb_Clear.Size = new Size(32, 30);
            pb_Clear.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Clear.TabIndex = 33;
            pb_Clear.TabStop = false;
            pb_Clear.Click += pb_Clear_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.IndianRed;
            btn_Delete.Cursor = Cursors.Hand;
            btn_Delete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Delete.Location = new Point(303, 423);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(248, 41);
            btn_Delete.TabIndex = 32;
            btn_Delete.Text = "DELETE";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click_1;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.LimeGreen;
            btn_Update.Cursor = Cursors.Hand;
            btn_Update.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_Update.ForeColor = Color.White;
            btn_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Update.Location = new Point(32, 423);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(248, 41);
            btn_Update.TabIndex = 31;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click_1;
            // 
            // btn_AddManga
            // 
            btn_AddManga.BackColor = Color.CornflowerBlue;
            btn_AddManga.Cursor = Cursors.Hand;
            btn_AddManga.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_AddManga.ForeColor = Color.White;
            btn_AddManga.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddManga.Location = new Point(32, 376);
            btn_AddManga.Name = "btn_AddManga";
            btn_AddManga.Size = new Size(248, 41);
            btn_AddManga.TabIndex = 7;
            btn_AddManga.Text = "ADD";
            btn_AddManga.UseVisualStyleBackColor = false;
            btn_AddManga.Click += btn_AddManga_Click_1;
            // 
            // btn_Browse
            // 
            btn_Browse.BackColor = Color.Olive;
            btn_Browse.Cursor = Cursors.Hand;
            btn_Browse.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Browse.ForeColor = Color.White;
            btn_Browse.Location = new Point(303, 376);
            btn_Browse.Name = "btn_Browse";
            btn_Browse.Size = new Size(248, 41);
            btn_Browse.TabIndex = 5;
            btn_Browse.Text = "BROWSE";
            btn_Browse.UseVisualStyleBackColor = false;
            btn_Browse.Click += btn_Browse_Click_1;
            // 
            // txt_Tax
            // 
            txt_Tax.BackColor = Color.WhiteSmoke;
            txt_Tax.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Tax.ForeColor = SystemColors.WindowFrame;
            txt_Tax.Location = new Point(32, 314);
            txt_Tax.Multiline = true;
            txt_Tax.Name = "txt_Tax";
            txt_Tax.PlaceholderText = "$ TAX";
            txt_Tax.Size = new Size(248, 41);
            txt_Tax.TabIndex = 4;
            // 
            // txt_Price
            // 
            txt_Price.BackColor = Color.WhiteSmoke;
            txt_Price.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Price.ForeColor = SystemColors.WindowFrame;
            txt_Price.Location = new Point(32, 257);
            txt_Price.Multiline = true;
            txt_Price.Name = "txt_Price";
            txt_Price.PlaceholderText = "$ PRICE";
            txt_Price.Size = new Size(248, 41);
            txt_Price.TabIndex = 3;
            // 
            // txt_Genre
            // 
            txt_Genre.BackColor = Color.WhiteSmoke;
            txt_Genre.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Genre.ForeColor = SystemColors.WindowFrame;
            txt_Genre.Location = new Point(32, 199);
            txt_Genre.Multiline = true;
            txt_Genre.Name = "txt_Genre";
            txt_Genre.PlaceholderText = "GENRE";
            txt_Genre.Size = new Size(248, 41);
            txt_Genre.TabIndex = 2;
            // 
            // txt_Author
            // 
            txt_Author.BackColor = Color.WhiteSmoke;
            txt_Author.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Author.ForeColor = SystemColors.WindowFrame;
            txt_Author.Location = new Point(32, 140);
            txt_Author.Multiline = true;
            txt_Author.Name = "txt_Author";
            txt_Author.PlaceholderText = "AUTHOR";
            txt_Author.Size = new Size(248, 41);
            txt_Author.TabIndex = 1;
            // 
            // txt_Title
            // 
            txt_Title.BackColor = Color.WhiteSmoke;
            txt_Title.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Title.ForeColor = SystemColors.WindowFrame;
            txt_Title.Location = new Point(32, 81);
            txt_Title.Multiline = true;
            txt_Title.Name = "txt_Title";
            txt_Title.PlaceholderText = "TITLE";
            txt_Title.Size = new Size(248, 41);
            txt_Title.TabIndex = 0;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(btn_Home);
            sidebar.Controls.Add(lv_PurchaseHistory);
            sidebar.Controls.Add(btn_AddProduct);
            sidebar.Controls.Add(flowLayoutPanel5);
            sidebar.Location = new Point(0, 73);
            sidebar.MaximumSize = new Size(933, 716);
            sidebar.MinimumSize = new Size(88, 716);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(88, 716);
            sidebar.TabIndex = 40;
            // 
            // btn_Home
            // 
            btn_Home.BackColor = Color.White;
            btn_Home.Cursor = Cursors.Hand;
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Home.ForeColor = Color.Transparent;
            btn_Home.Image = Properties.Resources.icons8_home_32;
            btn_Home.ImageAlign = ContentAlignment.TopCenter;
            btn_Home.Location = new Point(12, 8);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(63, 59);
            btn_Home.TabIndex = 3;
            btn_Home.Text = " Home";
            btn_Home.TextAlign = ContentAlignment.BottomCenter;
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += btn_Home_Click;
            // 
            // lv_PurchaseHistory
            // 
            lv_PurchaseHistory.BackColor = Color.White;
            lv_PurchaseHistory.BorderStyle = BorderStyle.None;
            lv_PurchaseHistory.Columns.AddRange(new ColumnHeader[] { ID, TotalAmount, _TotalTax, _PurchaseDate });
            lv_PurchaseHistory.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lv_PurchaseHistory.Location = new Point(115, 57);
            lv_PurchaseHistory.Name = "lv_PurchaseHistory";
            lv_PurchaseHistory.Size = new Size(787, 592);
            lv_PurchaseHistory.TabIndex = 9;
            lv_PurchaseHistory.UseCompatibleStateImageBehavior = false;
            lv_PurchaseHistory.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 30;
            // 
            // TotalAmount
            // 
            TotalAmount.Text = "Total Amount";
            TotalAmount.TextAlign = HorizontalAlignment.Center;
            TotalAmount.Width = 200;
            // 
            // _TotalTax
            // 
            _TotalTax.Text = "Total Tax";
            _TotalTax.TextAlign = HorizontalAlignment.Center;
            _TotalTax.Width = 170;
            // 
            // _PurchaseDate
            // 
            _PurchaseDate.Text = "Date-Time";
            _PurchaseDate.TextAlign = HorizontalAlignment.Center;
            _PurchaseDate.Width = 190;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.BackColor = Color.White;
            btn_AddProduct.Cursor = Cursors.Hand;
            btn_AddProduct.FlatStyle = FlatStyle.Flat;
            btn_AddProduct.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            btn_AddProduct.ForeColor = Color.Transparent;
            btn_AddProduct.Image = Properties.Resources.icons8_add_new_30;
            btn_AddProduct.ImageAlign = ContentAlignment.TopCenter;
            btn_AddProduct.Location = new Point(12, 73);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(63, 59);
            btn_AddProduct.TabIndex = 4;
            btn_AddProduct.Text = "   \r\n\r\n Add Item";
            btn_AddProduct.TextAlign = ContentAlignment.BottomCenter;
            btn_AddProduct.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.BackColor = Color.White;
            flowLayoutPanel5.Controls.Add(btn_Logout);
            flowLayoutPanel5.Location = new Point(9, 635);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(69, 65);
            flowLayoutPanel5.TabIndex = 8;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.White;
            btn_Logout.Cursor = Cursors.Hand;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            btn_Logout.ForeColor = Color.Transparent;
            btn_Logout.Image = Properties.Resources.icons8_logout__1_;
            btn_Logout.ImageAlign = ContentAlignment.TopCenter;
            btn_Logout.Location = new Point(3, 3);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(63, 62);
            btn_Logout.TabIndex = 3;
            btn_Logout.TextAlign = ContentAlignment.BottomCenter;
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(224, 224, 224);
            panel7.Location = new Point(1264, 149);
            panel7.Name = "panel7";
            panel7.Size = new Size(25, 624);
            panel7.TabIndex = 34;
            // 
            // flp_AddManga
            // 
            flp_AddManga.AutoScroll = true;
            flp_AddManga.BackColor = Color.WhiteSmoke;
            flp_AddManga.Location = new Point(720, 149);
            flp_AddManga.Name = "flp_AddManga";
            flp_AddManga.Size = new Size(569, 624);
            flp_AddManga.TabIndex = 33;
            // 
            // AddMangaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1334, 789);
            Controls.Add(panel7);
            Controls.Add(flp_AddManga);
            Controls.Add(sidebar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel9);
            Name = "AddMangaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMangaForm";
            panel9.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_CoverImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Clear).EndInit();
            sidebar.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private Label label6;
        private Panel panel2;
        private Panel panel1;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_AddManga;
        private PictureBox pb_CoverImage;
        private Button btn_Browse;
        private TextBox txt_Tax;
        private TextBox txt_Price;
        private TextBox txt_Genre;
        private TextBox txt_Author;
        private TextBox txt_Title;
        private Panel sidebar;
        private Button btn_Home;
        private ListView lv_PurchaseHistory;
        private ColumnHeader ID;
        private ColumnHeader TotalAmount;
        private ColumnHeader _TotalTax;
        private ColumnHeader _PurchaseDate;
        private Button btn_AddProduct;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btn_Logout;
        private Panel panel7;
        private FlowLayoutPanel flp_AddManga;
        private PictureBox pb_Clear;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel4;
    }
}