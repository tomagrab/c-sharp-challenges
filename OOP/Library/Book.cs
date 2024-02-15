namespace c_sharp_practice.OOP.Library
{
    public class Book : LibraryItem
    {
        public string IBSN { get; set; }
        public Book(string title, string author, string ibsn)
        {
            Title = title;
            Author = author;
            IBSN = ibsn;
        }
    }
}