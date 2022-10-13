namespace LibraryManagement;
public class BookDetails
{
    public static int s_bookID = 100;
    public string BookID { get; }
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public int BookCount { get; set; }
    public BookDetails(){

    }
    public BookDetails(string bookName,string authorName,int bookCount){
        s_bookID++;
        BookID = "BID" + s_bookID;
        BookName = bookName;
        AuthorName = authorName;
        BookCount = bookCount;
    }

    public static void ShowBooks(){
        System.Console.WriteLine("BookID\tBook Name\tAuthor Name\tNo of Books");
        foreach(BookDetails books in Process.booksList){
            System.Console.WriteLine($"{books.BookID}\t{books.BookName}\t\t{books.AuthorName}\t\t{books.BookCount}");
        }
    }
}
