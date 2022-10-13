namespace LibraryManagement;
public enum BookStatus
{
    Default,Issued,Returned
}
public class BorrowDetails
{
    public static int s_borrowID = 300;
    public string BorrowID { get; }
    public string BookID{ get; set; }
    public string RegisterID { get; set; }
    public DateTime BorrowedDate { get; set; }
    public BookStatus Status { get; set; }
    public DateTime DueDate{ get; set; }
    public BorrowDetails(){

    }
    public BorrowDetails(string bookID,string registerID,DateTime borrowedDate,DateTime dueDate,BookStatus status){
        s_borrowID++;
        BorrowID = "LB" + s_borrowID;
        BookID = bookID;
        RegisterID = registerID;
        BorrowedDate = borrowedDate;
        DueDate = dueDate;
        Status = status;
    }
}