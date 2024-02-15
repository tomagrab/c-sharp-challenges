namespace c_sharp_practice.OOP.Inventory
{
    public class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityInStock { get; private set; }
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            QuantityInStock = quantity;
        }
        public void UpdateStock(int quantity)
        {
            QuantityInStock += quantity;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product:\n\tName: {Name}\n\tPrice: ${Price}\n\tQuantity: {QuantityInStock}");
        }
    }
}