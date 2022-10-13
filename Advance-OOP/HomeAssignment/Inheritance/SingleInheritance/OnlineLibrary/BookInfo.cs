
namespace Exercise4
{
    public class BookInfo:DepartmentDetails
    {
        public string BookID { get; set; }

        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public double Price { get; set; }

        public BookInfo(string bookId, string bookName, string authorName, double price, string deptname, string degree):base(deptname, degree)
        {
            BookID = bookId;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public void ShowDetails()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("< ------------ DETAILS -------------->");
            System.Console.WriteLine();

            System.Console.WriteLine($"Book ID: {BookID}");
            System.Console.WriteLine($"Book Name: {BookName}");
            System.Console.WriteLine($"AuthorName: {AuthorName}");
            System.Console.WriteLine($"Price: {Price}");
            System.Console.WriteLine($"Department Name: {DeptName}");
            System.Console.WriteLine($"Degree: {Degree}");
        }
    }
}