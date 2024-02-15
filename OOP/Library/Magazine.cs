namespace c_sharp_practice.OOP.Library
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public Magazine(string title, string author, int issueNumber)
        {
            Title = title;
            Author = author;
            IssueNumber = issueNumber;
        }
    }
}