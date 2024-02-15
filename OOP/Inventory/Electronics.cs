namespace c_sharp_practice.OOP.Inventory
{
    public class Electronics : Product
    {
        public string Model { get; private set; }
        public Electronics(string name, decimal price, int quantity, string model) : base(name, price, quantity)
        {
            Model = model;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"\n\tModel: {Model}");
        }
    }
}