using c_sharp_practice.OOP.Inventory;

namespace c_sharp_practice.Challenges
{
    public class InventoryManagement
    {
        public static void InventoryManagementChallenge()
        {
            InventoryManager inventoryManager = new InventoryManager();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. Process Sale");
                Console.WriteLine("4. Restock Product");
                Console.WriteLine("5. Check Product Stock");
                Console.WriteLine("6: Check Transaction");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        public static void AddProduct(InventoryManager inventoryManager) { }
        public static void RemoveProduct(InventoryManager inventoryManager) { }
        public static void ProcessSale(InventoryManager inventoryManager) { }
        public static void RestockProduct(InventoryManager inventoryManager) { }
        public static void CheckProductStock(InventoryManager inventoryManager) { }
        public static void CheckTransactions(InventoryManager inventoryManager) { }
    }
}