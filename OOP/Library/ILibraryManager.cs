namespace c_sharp_practice.OOP.Library
{
    public interface ILibraryManager
    {
        void AddBook(Book book);
        void RemoveBook(Book book);
        void AddMagazine(Magazine magazine);
        void RemoveMagazine(Magazine magazine);
        Book BorrowBook(User user, string ibsn);
        Magazine BorrowMagazine(User user, int issueNumber);
        void RegisterUser(User user);
    }
}