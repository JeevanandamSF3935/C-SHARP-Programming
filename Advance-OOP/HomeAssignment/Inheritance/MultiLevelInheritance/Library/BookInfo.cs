

namespace Exercise2
{
    public class BookInfo : RackInfo
    {
       public string BookID { get; set; } 

       public string BookName { get; set; }

       public string AuthorName { get; set; }

       public double Price { get; set; }

       public BookInfo()
       {

       }

       public BookInfo(string bookid, String bookname, string authorname, double price, int rackno, int colmnno, string deptName, string degree):base(rackno, colmnno, deptName, degree)
       {
        BookID = bookid;
        BookName = bookname;
        AuthorName = authorname;
        Price = price;
       }

       public void DisplayInfo()
       {
            System.Console.WriteLine($"Department Name: {DepartmentName}");
            System.Console.WriteLine($"Degree: {Degree}");
            System.Console.WriteLine($"Rack Number: {RackNumber}");
            System.Console.WriteLine($"Column Number: {ColumnNumber}");
            System.Console.WriteLine($"Book ID: {BookID}");
            System.Console.WriteLine($"Book Name: {BookName}");
            System.Console.WriteLine($"Author Name: {AuthorName}");
            System.Console.WriteLine($"Price: {Price}");
       }
    }
}