using PosoManagementSystem.Data_Access;
using PosoManagementSystem.Model;

public class PurchaseHistoryHandler
{
    private ListView lv_PurchaseHistory;

    public PurchaseHistoryHandler(ListView listView)
    {
        lv_PurchaseHistory = listView;
    }

    public void LoadPurchaseHistory()
    {
        List<PurchaseModels> purchaseModels = CartPurchaseDBContext.GetPurchaseList();
        lv_PurchaseHistory.Items.Clear();

        foreach (PurchaseModels purchaseModel in purchaseModels)
        {
            ListViewItem item = new ListViewItem(purchaseModel.MangaID.ToString());
            item.SubItems.Add(purchaseModel.TotalAmount.ToString("C"));
            item.SubItems.Add(purchaseModel.Tax.ToString("C"));
            item.SubItems.Add(purchaseModel.PurchaseDate.ToString("yyyy-MM-dd HH:mm:ss"));

            lv_PurchaseHistory.Items.Add(item);
        }
    }
}
