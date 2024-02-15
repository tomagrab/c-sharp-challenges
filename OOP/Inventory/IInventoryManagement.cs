namespace c_sharp_practice.OOP.Inventory
{
    public interface IInventoryManagement
    {
        void AddProduct(Product product);
        void RemoveProduct(string productName);
        void ProcessSale(string productName, int quantity);
        void RestockProduct(string productName, int quantity);
    }
}