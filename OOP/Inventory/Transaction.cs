namespace c_sharp_practice.OOP.Inventory
{
    public class Transaction
    {
        public Product Product { get; private set; }
        public int QuantitySold { get; private set; }
        public DateTime TransactionDate { get; private set; }

        public Transaction(Product product, int quantitySold)
        {
            Product = product;
            QuantitySold = quantitySold;
            TransactionDate = DateTime.Now;
        }
    }
}