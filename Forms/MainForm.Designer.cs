
namespace PosoManagementSystem.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            flp_Manga = new FlowLayoutPanel();
            tb_Search = new TextBox();
            btn_Search = new Button();
            panel3 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_SideBarHome = new Button();
            btn_SideBarPurchaseHistory = new Button();
            flowLayoutPanel5 = new FlowLayoutPanel();
            btn_Logout = new Button();
            sidebar = new Panel();
            lv_PurchaseHistory = new ListView();
            Manga_ID = new ColumnHeader();
            Total_Amount = new ColumnHeader();
            Total_Tax = new ColumnHeader();
            Date_Time = new ColumnHeader();
            btn_SideBarAddProduct = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            lbl_TotalTax = new Label();
            label6 = new Label();
            label4 = new Label();
            lbl_TotalAmount = new Label();
            panel4 = new Panel();
            panel8 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pb_ClearCart = new PictureBox();
            label2 = new Label();
            panel7 = new Panel();
            btn_Checkout = new Button();
            btn_AddToCart = new Button();
            txt_Quantity = new TextBox();
            txt_MangaID = new TextBox();
            dgv_Cart = new DataGridView();
            MangaID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            CoverImage = new DataGridViewImageColumn();
            Remove = new DataGridViewImageColumn();
            panel9 = new Panel();
            flp_Genre = new FlowLayoutPanel();
            SideBar_Timer = new System.Windows.Forms.Timer(components);
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel5.SuspendLayout();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_ClearCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Cart).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // flp_Manga
            // 
            flp_Manga.AutoScroll = true;
            flp_Manga.BackColor = Color.FromArgb(224, 224, 224);
            flp_Manga.ForeColor = Color.Black;
            flp_Manga.Location = new Point(105, 146);
            flp_Manga.Margin = new Padding(15);
            flp_Manga.Name = "flp_Manga";
            flp_Manga.Size = new Size(862, 616);
            flp_Manga.TabIndex = 9;
            // 
            // tb_Search
            // 
            tb_Search.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_Search.Location = new Point(255, 15);
            tb_Search.Multiline = true;
            tb_Search.Name = "tb_Search";
            tb_Search.PlaceholderText = "Search Manga.........";
            tb_Search.Size = new Size(345, 36);
            tb_Search.TabIndex = 10;
            tb_Search.TextChanged += tb_Search_TextChanged;
            // 
            // btn_Search
            // 
            btn_Search.Cursor = Cursors.Hand;
            btn_Search.FlatStyle = FlatStyle.Flat;
            btn_Search.ForeColor = Color.White;
            btn_Search.Image = Properties.Resources.icons8_search_folder;
            btn_Search.Location = new Point(602, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(61, 54);
            btn_Search.TabIndex = 11;
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(939, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(24, 607);
            panel3.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label1);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(tb_Search);
            panel6.Controls.Add(btn_Search);
            panel6.Location = new Point(0, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(1338, 70);
            panel6.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 18);
            label1.Name = "label1";
            label1.Size = new Size(160, 29);
            label1.TabIndex = 13;
            label1.Text = "MANGA POS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.animetrix;
            pictureBox1.Location = new Point(6, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btn_SideBarHome
            // 
            btn_SideBarHome.BackColor = Color.White;
            btn_SideBarHome.Cursor = Cursors.Hand;
            btn_SideBarHome.FlatStyle = FlatStyle.Flat;
            btn_SideBarHome.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SideBarHome.ForeColor = Color.Transparent;
            btn_SideBarHome.Image = Properties.Resources.icons8_home_32;
            btn_SideBarHome.ImageAlign = ContentAlignment.TopCenter;
            btn_SideBarHome.Location = new Point(12, 8);
            btn_SideBarHome.Name = "btn_SideBarHome";
            btn_SideBarHome.Size = new Size(63, 59);
            btn_SideBarHome.TabIndex = 3;
            btn_SideBarHome.Text = " Home";
            btn_SideBarHome.TextAlign = ContentAlignment.BottomCenter;
            btn_SideBarHome.UseVisualStyleBackColor = false;
            btn_SideBarHome.Click += btn_SideBarHome_Click;
            // 
            // btn_SideBarPurchaseHistory
            // 
            btn_SideBarPurchaseHistory.BackColor = Color.White;
            btn_SideBarPurchaseHistory.Cursor = Cursors.Hand;
            btn_SideBarPurchaseHistory.FlatStyle = FlatStyle.Flat;
            btn_SideBarPurchaseHistory.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            btn_SideBarPurchaseHistory.ForeColor = Color.Transparent;
            btn_SideBarPurchaseHistory.Image = Properties.Resources.icons8_activity_history_30;
            btn_SideBarPurchaseHistory.ImageAlign = ContentAlignment.TopCenter;
            btn_SideBarPurchaseHistory.Location = new Point(12, 138);
            btn_SideBarPurchaseHistory.Name = "btn_SideBarPurchaseHistory";
            btn_SideBarPurchaseHistory.Size = new Size(63, 59);
            btn_SideBarPurchaseHistory.TabIndex = 3;
            btn_SideBarPurchaseHistory.Text = "History";
            btn_SideBarPurchaseHistory.TextAlign = ContentAlignment.BottomCenter;
            btn_SideBarPurchaseHistory.UseVisualStyleBackColor = false;
            btn_SideBarPurchaseHistory.Click += btn_SideBarPurchaseHistory_Click;
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
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(btn_SideBarPurchaseHistory);
            sidebar.Controls.Add(btn_SideBarHome);
            sidebar.Controls.Add(lv_PurchaseHistory);
            sidebar.Controls.Add(btn_SideBarAddProduct);
            sidebar.Controls.Add(flowLayoutPanel5);
            sidebar.Location = new Point(0, 73);
            sidebar.MaximumSize = new Size(933, 716);
            sidebar.MinimumSize = new Size(88, 716);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(88, 716);
            sidebar.TabIndex = 20;
            // 
            // lv_PurchaseHistory
            // 
            lv_PurchaseHistory.BackColor = Color.White;
            lv_PurchaseHistory.BorderStyle = BorderStyle.None;
            lv_PurchaseHistory.Columns.AddRange(new ColumnHeader[] { Manga_ID, Total_Amount, Total_Tax, Date_Time });
            lv_PurchaseHistory.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lv_PurchaseHistory.Location = new Point(115, 57);
            lv_PurchaseHistory.Name = "lv_PurchaseHistory";
            lv_PurchaseHistory.Size = new Size(787, 592);
            lv_PurchaseHistory.TabIndex = 9;
            lv_PurchaseHistory.UseCompatibleStateImageBehavior = false;
            lv_PurchaseHistory.View = View.Details;
            lv_PurchaseHistory.SelectedIndexChanged += lv_PurchaseHistory_SelectedIndexChanged;
            // 
            // Manga_ID
            // 
            Manga_ID.Text = "MangaID";
            Manga_ID.Width = 100;
            // 
            // Total_Amount
            // 
            Total_Amount.Text = "TotalAmount";
            Total_Amount.TextAlign = HorizontalAlignment.Center;
            Total_Amount.Width = 200;
            // 
            // Total_Tax
            // 
            Total_Tax.Text = "TotalTax";
            Total_Tax.TextAlign = HorizontalAlignment.Center;
            Total_Tax.Width = 200;
            // 
            // Date_Time
            // 
            Date_Time.Text = "DateTime";
            Date_Time.TextAlign = HorizontalAlignment.Center;
            Date_Time.Width = 200;
            // 
            // btn_SideBarAddProduct
            // 
            btn_SideBarAddProduct.BackColor = Color.White;
            btn_SideBarAddProduct.Cursor = Cursors.Hand;
            btn_SideBarAddProduct.FlatStyle = FlatStyle.Flat;
            btn_SideBarAddProduct.Font = new Font("Arial Narrow", 9F, FontStyle.Bold);
            btn_SideBarAddProduct.ForeColor = Color.Transparent;
            btn_SideBarAddProduct.Image = Properties.Resources.icons8_add_new_30;
            btn_SideBarAddProduct.ImageAlign = ContentAlignment.TopCenter;
            btn_SideBarAddProduct.Location = new Point(12, 73);
            btn_SideBarAddProduct.Name = "btn_SideBarAddProduct";
            btn_SideBarAddProduct.Size = new Size(63, 59);
            btn_SideBarAddProduct.TabIndex = 4;
            btn_SideBarAddProduct.Text = "   \r\n\r\n Add Item";
            btn_SideBarAddProduct.TextAlign = ContentAlignment.BottomCenter;
            btn_SideBarAddProduct.UseVisualStyleBackColor = false;
            btn_SideBarAddProduct.Click += btn_AddProduct_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_Checkout);
            panel1.Controls.Add(btn_AddToCart);
            panel1.Controls.Add(txt_Quantity);
            panel1.Controls.Add(txt_MangaID);
            panel1.Controls.Add(dgv_Cart);
            panel1.Location = new Point(939, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 687);
            panel1.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lbl_TotalTax);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(lbl_TotalAmount);
            panel5.Location = new Point(18, 373);
            panel5.Name = "panel5";
            panel5.Size = new Size(294, 250);
            panel5.TabIndex = 28;
            // 
            // lbl_TotalTax
            // 
            lbl_TotalTax.AutoSize = true;
            lbl_TotalTax.BackColor = Color.White;
            lbl_TotalTax.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_TotalTax.ForeColor = Color.DimGray;
            lbl_TotalTax.Location = new Point(200, 187);
            lbl_TotalTax.Name = "lbl_TotalTax";
            lbl_TotalTax.Size = new Size(17, 25);
            lbl_TotalTax.TabIndex = 17;
            lbl_TotalTax.Text = " ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(3, 187);
            label6.Name = "label6";
            label6.Size = new Size(40, 25);
            label6.TabIndex = 16;
            label6.Text = "Tax";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 216);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 15;
            label4.Text = "Total Amout";
            // 
            // lbl_TotalAmount
            // 
            lbl_TotalAmount.AutoSize = true;
            lbl_TotalAmount.BackColor = Color.White;
            lbl_TotalAmount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lbl_TotalAmount.ForeColor = Color.Black;
            lbl_TotalAmount.Location = new Point(200, 216);
            lbl_TotalAmount.Name = "lbl_TotalAmount";
            lbl_TotalAmount.Size = new Size(17, 25);
            lbl_TotalAmount.TabIndex = 6;
            lbl_TotalAmount.Text = " ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel8);
            panel4.Location = new Point(357, 11);
            panel4.Name = "panel4";
            panel4.Size = new Size(18, 272);
            panel4.TabIndex = 27;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(8, 8);
            panel8.Name = "panel8";
            panel8.Size = new Size(18, 272);
            panel8.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pb_ClearCart);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel7);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 85);
            panel2.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_cart_50;
            pictureBox3.Location = new Point(3, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pb_ClearCart
            // 
            pb_ClearCart.Cursor = Cursors.Hand;
            pb_ClearCart.Image = Properties.Resources.icons8_reset_40;
            pb_ClearCart.Location = new Point(295, 17);
            pb_ClearCart.Name = "pb_ClearCart";
            pb_ClearCart.Size = new Size(30, 26);
            pb_ClearCart.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ClearCart.TabIndex = 18;
            pb_ClearCart.TabStop = false;
            pb_ClearCart.Click += pb_ClearCart_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 20);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 14;
            label2.Text = "Cart";
            // 
            // panel7
            // 
            panel7.Location = new Point(340, 1);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 271);
            panel7.TabIndex = 1;
            // 
            // btn_Checkout
            // 
            btn_Checkout.BackColor = Color.LimeGreen;
            btn_Checkout.Cursor = Cursors.Hand;
            btn_Checkout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Checkout.ForeColor = Color.White;
            btn_Checkout.Location = new Point(170, 629);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(140, 44);
            btn_Checkout.TabIndex = 24;
            btn_Checkout.Text = "Checkout";
            btn_Checkout.UseVisualStyleBackColor = false;
            btn_Checkout.Click += btn_Checkout_Click;
            // 
            // btn_AddToCart
            // 
            btn_AddToCart.BackColor = Color.Tomato;
            btn_AddToCart.Cursor = Cursors.Hand;
            btn_AddToCart.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btn_AddToCart.ForeColor = Color.White;
            btn_AddToCart.Location = new Point(21, 629);
            btn_AddToCart.Name = "btn_AddToCart";
            btn_AddToCart.Size = new Size(140, 44);
            btn_AddToCart.TabIndex = 23;
            btn_AddToCart.Text = "Add To Cart";
            btn_AddToCart.UseVisualStyleBackColor = false;
            btn_AddToCart.Click += btn_AddToCart_Click_2;
            // 
            // txt_Quantity
            // 
            txt_Quantity.BackColor = Color.White;
            txt_Quantity.Location = new Point(170, 333);
            txt_Quantity.Multiline = true;
            txt_Quantity.Name = "txt_Quantity";
            txt_Quantity.PlaceholderText = "QUANTITY";
            txt_Quantity.Size = new Size(131, 36);
            txt_Quantity.TabIndex = 22;
            // 
            // txt_MangaID
            // 
            txt_MangaID.BackColor = Color.White;
            txt_MangaID.Location = new Point(18, 333);
            txt_MangaID.Multiline = true;
            txt_MangaID.Name = "txt_MangaID";
            txt_MangaID.PlaceholderText = "MANGA #";
            txt_MangaID.Size = new Size(131, 36);
            txt_MangaID.TabIndex = 21;
            // 
            // dgv_Cart
            // 
            dgv_Cart.AllowUserToAddRows = false;
            dgv_Cart.AllowUserToDeleteRows = false;
            dgv_Cart.BackgroundColor = Color.White;
            dgv_Cart.BorderStyle = BorderStyle.None;
            dgv_Cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cart.Columns.AddRange(new DataGridViewColumn[] { MangaID, Title, Quantity, CoverImage, Remove });
            dgv_Cart.Cursor = Cursors.Hand;
            dgv_Cart.GridColor = Color.White;
            dgv_Cart.Location = new Point(-42, 56);
            dgv_Cart.Name = "dgv_Cart";
            dgv_Cart.ReadOnly = true;
            dgv_Cart.Size = new Size(399, 271);
            dgv_Cart.TabIndex = 20;
            // 
            // MangaID
            // 
            MangaID.Frozen = true;
            MangaID.HeaderText = "ID";
            MangaID.Name = "MangaID";
            MangaID.ReadOnly = true;
            MangaID.Resizable = DataGridViewTriState.False;
            MangaID.Width = 30;
            // 
            // Title
            // 
            Title.Frozen = true;
            Title.HeaderText = "TITLE";
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Resizable = DataGridViewTriState.False;
            Title.Width = 150;
            // 
            // Quantity
            // 
            Quantity.Frozen = true;
            Quantity.HeaderText = "QUANTITY";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Resizable = DataGridViewTriState.False;
            Quantity.Width = 35;
            // 
            // CoverImage
            // 
            CoverImage.HeaderText = "IMG";
            CoverImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            CoverImage.Name = "CoverImage";
            CoverImage.ReadOnly = true;
            CoverImage.Resizable = DataGridViewTriState.False;
            CoverImage.SortMode = DataGridViewColumnSortMode.Automatic;
            CoverImage.Width = 35;
            // 
            // Remove
            // 
            Remove.HeaderText = "RM";
            Remove.Image = Properties.Resources.icons8_circled_x_30;
            Remove.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Remove.Name = "Remove";
            Remove.ReadOnly = true;
            Remove.SortMode = DataGridViewColumnSortMode.Automatic;
            Remove.Width = 35;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(flp_Genre);
            panel9.Location = new Point(120, 88);
            panel9.Name = "panel9";
            panel9.Size = new Size(796, 49);
            panel9.TabIndex = 23;
            // 
            // flp_Genre
            // 
            flp_Genre.AutoScroll = true;
            flp_Genre.Cursor = Cursors.Hand;
            flp_Genre.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flp_Genre.Location = new Point(3, 4);
            flp_Genre.Name = "flp_Genre";
            flp_Genre.Padding = new Padding(5);
            flp_Genre.Size = new Size(790, 42);
            flp_Genre.TabIndex = 0;
            flp_Genre.WrapContents = false;
            // 
            // SideBar_Timer
            // 
            SideBar_Timer.Interval = 1;
            SideBar_Timer.Tick += SidebarTimer_Tick;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Location = new Point(120, 117);
            panel10.Name = "panel10";
            panel10.Size = new Size(796, 20);
            panel10.TabIndex = 13;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(224, 224, 224);
            panel11.Location = new Point(88, 129);
            panel11.Name = "panel11";
            panel11.Size = new Size(847, 20);
            panel11.TabIndex = 14;
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.Location = new Point(120, 75);
            panel12.Name = "panel12";
            panel12.Size = new Size(796, 14);
            panel12.TabIndex = 14;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(224, 224, 224);
            panel13.Location = new Point(935, 129);
            panel13.Name = "panel13";
            panel13.Size = new Size(337, 20);
            panel13.TabIndex = 16;
            // 
            // MainForm
            // 
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1336, 791);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(sidebar);
            Controls.Add(panel6);
            Controls.Add(flp_Manga);
            Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manga POS";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel5.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_ClearCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Cart).EndInit();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private FlowLayoutPanel flp_Manga;
        private TextBox tb_Search;
        private Button btn_Search;
        private Panel panel3;
        private Panel panel6;
        private DataGridViewTextBoxColumn TAX;
        private Button btn_SideBarHome;
        private Button btn_SideBarPurchaseHistory;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button btn_Logout;
        private Panel sidebar;
        private System.Windows.Forms.Timer SideBarTimer;
        private System.Windows.Forms.Timer SideBarTimer_;
        private Panel panel1;
        private Panel panel5;
        private Label lbl_TotalTax;
        private Label label6;
        private Label label4;
        private Label lbl_TotalAmount;
        private Panel panel4;
        private Panel panel8;
        private Panel panel2;
        private Panel panel7;
        private Button btn_Checkout;
        private Button btn_AddToCart;
        private TextBox txt_Quantity;
        private TextBox txt_MangaID;
        private DataGridView dgv_Cart;
        private ListView lv_PurchaseHistory;
        private DataGridViewTextBoxColumn MangaID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewImageColumn CoverImage;
        private DataGridViewImageColumn Remove;
        private Panel panel9;
        private Button btn_SideBarAddProduct;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer SideBar_Timer;
        private FlowLayoutPanel flp_Genre;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Label label1;
        private Label label2;
        private Panel panel13;
        private PictureBox pb_ClearCart;
        private ColumnHeader Manga_ID;
        private ColumnHeader Total_Amount;
        private ColumnHeader Total_Tax;
        private ColumnHeader Date_Time;
        private PictureBox pictureBox3;
    }
    #endregion
}