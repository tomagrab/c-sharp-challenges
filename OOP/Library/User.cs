namespace c_sharp_practice.OOP.Library
{
    public class User
    {
        private string name;
        private int userId;
        private List<Book> borrowedBooks = new List<Book>();
        private List<Magazine> borrowedMagazines = new List<Magazine>();
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public List<Book> BorrowedBooks
        {
            get { return borrowedBooks; }
        }
        public List<Magazine> BorrowedMagazines
        {
            get { return borrowedMagazines; }
        }
        public User(string name, int userId)
        {
            this.name = name;
            this.userId = userId;
        }
        public void BorrowBook(Book book)
        {
            borrowedBooks.Add(book);
        }
        public void BorrowMagazine(Magazine magazine)
        {
            borrowedMagazines.Add(magazine);
        }
    }
}