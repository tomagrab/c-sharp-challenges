using c_sharp_practice.OOP.Library;

namespace c_sharp_practice.Challenges
{
    public class LibraryManagement
    {
        public static void LibraryManagementChallenge()
        {
            LibraryManager libraryManager = new LibraryManager();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Magazine");
                Console.WriteLine("3. Register User");
                Console.WriteLine("4. Borrow Book");
                Console.WriteLine("5. Borrow Magazine");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook(libraryManager);
                        break;
                    case 2:
                        AddMagazine(libraryManager);
                        break;
                    case 3:
                        RegisterUser(libraryManager);
                        break;
                    case 4:
                        BorrowBook(libraryManager);
                        break;
                    case 5:
                        BorrowMagazine(libraryManager);
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        public static void AddBook(LibraryManager libraryManager)
        {
            Console.WriteLine("Enter the book title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the book author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the book IBSN: ");
            string ibsn = Console.ReadLine();

            Book book = new Book(title, author, ibsn);
            libraryManager.AddBook(book);

            Console.WriteLine($"'{book.Title}' added successfully!");
        }
        public static void AddMagazine(LibraryManager libraryManager)
        {
            Console.WriteLine("Enter the magazine title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the magazine author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the magazine issue number: ");
            int issueNumber = Convert.ToInt32(Console.ReadLine());

            Magazine magazine = new Magazine(title, author, issueNumber);
            libraryManager.AddMagazine(magazine);

            Console.WriteLine($"'{magazine.Title}' added successfully!");
        }
        public static void RegisterUser(LibraryManager libraryManager)
        {
            Console.WriteLine("Enter the user's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the user's ID: ");
            int userId = Convert.ToInt32(Console.ReadLine());

            User user = new User(name, userId);
            libraryManager.RegisterUser(user);

            Console.WriteLine($"'{user.Name}' registered successfully!");
        }
        public static void BorrowBook(LibraryManager libraryManager)
        {
            Console.WriteLine("Enter the user's ID: ");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the book IBSN: ");
            string ibsn = Console.ReadLine();

            User user = libraryManager.FindByUserId(userId);
            Book book = libraryManager.BorrowBook(user, ibsn);

            if (book != null)
            {
                Console.WriteLine($"'{book.Title}' borrowed successfully by {user.Name}.");
            }
            else
            {
                Console.WriteLine("Book not found or already borrowed.");
            }
        }
        public static void BorrowMagazine(LibraryManager libraryManager)
        {
            Console.WriteLine("Enter the user's ID: ");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the book IBSN: ");
            int issueNumber = Convert.ToInt32(Console.ReadLine());

            User user = libraryManager.FindByUserId(userId);
            Magazine magazine = libraryManager.BorrowMagazine(user, issueNumber);

            if (magazine != null)
            {
                Console.WriteLine($"'{magazine.Title}' borrowed successfully by {user.Name}.");
            }
            else
            {
                Console.WriteLine("Book not found or already borrowed.");
            }
        }
    }
}