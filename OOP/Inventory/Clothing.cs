namespace c_sharp_practice.OOP.Inventory
{
    public class Clothing : Product
    {
        public string Size { get; private set; }
        public Clothing(string name, decimal price, int quantity, string size) : base(name, price, quantity)
        {
            Size = size;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"\n\tSize: {Size}");
        }
    }
}