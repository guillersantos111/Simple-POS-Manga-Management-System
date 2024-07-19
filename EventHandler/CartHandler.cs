using PosoManagementSystem.Data_Access;
using PosoManagementSystem.Forms;
using PosoManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PosoManagementSystem.EventHandler
{
    public class CartHandler
    {
        private CartModels cartModels;
        private DataGridView dgv_Cart;
        private ListView lv_PurchaseHistoty;
        private Label lbl_TotalTax;
        private Label lbl_TotalAmount;

        public CartHandler(CartModels CartModels, DataGridView Dgv_Cart, Label Lbl_TotalTax, Label Lbl_TotalAmount)
        {
            this.cartModels = CartModels;
            this.dgv_Cart = Dgv_Cart;
            this.lbl_TotalTax = Lbl_TotalTax;
            this.lbl_TotalAmount = Lbl_TotalAmount;
        }

        public void AddToCart(MangaModels mangaModels, int quantity)
        {
            CartPurchaseDBContext.AddToCart(mangaModels, quantity);
            cartModels.AddItem(mangaModels, quantity);
            UpdateCartUI();
        }

        public void UpdateCartUI()
        {
            dgv_Cart.Rows.Clear();

            foreach (var item in cartModels.Items)
            {
                int rowIndex = dgv_Cart.Rows.Add(
                    item.MangaID, 
                    item.Title, 
                    item.Quantity, 
                    item.CoverImage, 
                    item.Tax, item.Price, 
                    item.Quantity * item.Price, item.Quantity * item.Tax);
                    dgv_Cart.Rows[rowIndex].Cells["Remove"].Value = Properties.Resources.icons8_circled_x_30;
            }
            lbl_TotalTax.Text = $"{cartModels.Tax:C}";
            lbl_TotalAmount.Text = $"{cartModels.TotalAmount:C}";
        }

        public void Checkout()
        {
            if (cartModels.Items.Count == 0)
            {
                MessageBox.Show("Your Cart Is Empty. Please Add Items Before Checking Out.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                MessageBox.Show("Purchase Completed Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CartPurchaseDBContext.Checkout(cartModels);
                cartModels.ClearItems();
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                mainForm.purchaseHistoryHandler.LoadPurchaseHistory();

                UpdateCartUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearCart()
        {
            cartModels.ClearItems();
            UpdateCartUI();
        }

        public void RemoveItemFromCart(int mangaID)
        {
            cartModels.RemoveItem(mangaID);
            UpdateCartUI();
        }
    }
}
