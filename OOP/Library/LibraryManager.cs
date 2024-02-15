namespace c_sharp_practice.OOP.Library
{
    public class LibraryManager : ILibraryManager
    {
        private List<Book> books = new List<Book>();
        private List<Magazine> magazines = new List<Magazine>();
        private List<User> users = new List<User>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void AddMagazine(Magazine magazine)
        {
            magazines.Add(magazine);
        }
        public void RemoveMagazine(Magazine magazine)
        {
            magazines.Remove(magazine);
        }
        public Book BorrowBook(User user, string ibsn)
        {
            var book = books.FirstOrDefault(b => b.IBSN == ibsn);
            if (book != null)
            {
                user.BorrowBook(book);
                return book;
            }
            return null;
        }
        public Magazine BorrowMagazine(User user, int issueNumber)
        {
            var magazine = magazines.FirstOrDefault(m => m.IssueNumber == issueNumber);
            if (magazine != null)
            {
                user.BorrowMagazine(magazine);
                return magazine;
            }
            return null;
        }
        public void RegisterUser(User user)
        {
            users.Add(user);
        }
        public User FindByUserId(int userId)
        {
            return users.FirstOrDefault(u => u.UserId == userId);
        }
    }
}