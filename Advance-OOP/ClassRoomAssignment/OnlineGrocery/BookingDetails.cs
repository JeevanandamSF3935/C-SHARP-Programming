using System;

namespace OnlineGrocery;
public enum BookingStatus
{
    Default,Initiated,Booked,Cancelled
}
public class BookingDetails
{
    private static int s_bookingId = 3000;
    public string BookingID { get; }
    public string CustomerID { get; set; }
    public double TotalPrice { get; set; }
    public DateTime BookingDate { get; set; }
    public BookingStatus StatusOfBooking { get; set; }
    public BookingDetails(){

    }
    public BookingDetails(string customerId,double totalPrice,DateTime bookingDate,BookingStatus statusOfBooking){
        s_bookingId++;
        BookingID = "BID" + s_bookingId;
        CustomerID = customerId;
        TotalPrice = totalPrice;
        BookingDate = bookingDate;
        StatusOfBooking = statusOfBooking;
    }

    public BookingDetails(string data){
        string[] values = data.Split(',');
        s_bookingId = int.Parse(values[0].Remove(0,3));
        BookingID = values[0];
        CustomerID = values[1];
        TotalPrice = double.Parse(values[2]);
        BookingDate = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
        StatusOfBooking = Enum.Parse<BookingStatus>(values[4],true);
    }

    public void ShowBookings(){
        System.Console.WriteLine($"{BookingID}\t\t{CustomerID}\t\t{TotalPrice}\t\t{BookingDate.ToString("dd/MM/yyyy")}\t\t{StatusOfBooking}");
    }
}