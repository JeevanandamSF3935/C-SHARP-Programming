using System;
namespace OnlineFoodOrder;
public enum BookingStatus
{
    Default,Initiated,Booked,cancelled
}
public class BookingDetails
{
    private static int s_bookingId = 3000;
    public string BookingID { get; }
    public string CustomerID { get; set; }
    public double TotalPrice { get; set; }
    public DateTime DateOfBooking { get; set; }
    public BookingStatus Status { get; set; }

    public BookingDetails(){

    }
    
    public BookingDetails(string customerId,double totalPrice,DateTime date,BookingStatus status){
        s_bookingId++;
        BookingID = "BID" + s_bookingId;
        CustomerID = customerId;
        TotalPrice = totalPrice;
        DateOfBooking = date;
        Status = status;
    }

    public BookingDetails(string data){
        string[] values = data.Split(',');
        s_bookingId = int.Parse(values[0].Remove(0,3));
        BookingID = values[0];
        CustomerID = values[1];
        TotalPrice = double.Parse(values[2]);
        DateOfBooking = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
        Status = Enum.Parse<BookingStatus>(values[4],true);
    }
}