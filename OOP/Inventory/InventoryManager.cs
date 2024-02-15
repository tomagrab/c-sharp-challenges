namespace c_sharp_practice.OOP.Inventory
{
    public class InventoryManager : IInventoryManagement
    {
        private List<Product> products = new List<Product>();
        private List<Transaction> transactions = new List<Transaction>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(string productName)
        {
            var product = products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                products.Remove(product);
            }
        }
        public void ProcessSale(string productName, int quantity)
        {
            var product = products.FirstOrDefault(p => p.Name == productName);
            if (product != null && product.QuantityInStock >= quantity)
            {
                product.UpdateStock(-quantity);
                Transaction transaction = new Transaction(product, quantity);
                transactions.Add(transaction);
            }
        }
        public void RestockProduct(string productName, int quantity)
        {
            var product = products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                product.UpdateStock(quantity);
            }
        }
        public List<Transaction> ListTransactions()
        {
            return transactions;
        }
    }
}