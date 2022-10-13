using System;

namespace OnlineTheatreBookingApplication;
///<summary>
///Booking status is a Enum contains two choices Booked and Cancelled for the namespace <see cref = "OnlineTheatreBookingApplication"/>.
///</summary>
public enum BookingStatus
{
    Default,Booked,Cancelled
}

///<summary>
///BookingDetails is a class contains a theatre movie ticket booked details, properties and constructors
///</summary>
public class BookingDetails
{
    ///<summary>
    ///s_bookingID is a static private field which is used to auto increase for bookingID generation in class<see cref = "BookingDetails"/>
    ///</summary>
    private static int s_bookingID = 7000;
    ///<summary>
    ///BookingID is a property of class<see cref = "BookingDetails"/> which get the bookingID.
    ///</summary>
    public string BookingID { get; }
    ///<summary>
    ///UserID is a property of class<see cref = "BookingDetails"/> which get and set the UserID.
    ///</summary>
    public string UserID { get; set; }
    ///<summary>
    ///MovieID is a property of class<see cref = "BookingDetails"/> which get and set the movieID.
    ///</summary>
    public string MovieID { get; set; }
    ///<summary>
    ///TheatreID is a property of class<see cref = "BookingDetails"/> which get and set the theatreId.
    ///</summary>
    public string TheatreID { get; set; }
    ///<summary>
    ///SeatCount is a property of class<see cref = "BookingDetails"/> which get and set the count of the seats.
    ///</summary>
    public int SeatCount { get; set; }
    ///<summary>
    ///TotalPrice is a property of class<see cref = "BookingDetails"/> which get and set the calculated price of tickets.
    ///</summary>
    public double TotalPrice { get; set; }
    ///<summary>
    ///StatusOfBooking is a property of class<see cref = "BookingDetails"/> which get and set the booking status.
    ///</summary>
    public BookingStatus StatusOfBooking { get; set; }

    ///<summary>
    ///BookingDetails is the Default Constructor of class<see cref = "BookingDetails"/>.
    ///</summary>
    public BookingDetails(){

    }

    ///<summary>
    ///BookingDetails is the parameterized and overloaded Constructor of class<see cref = "BookingDetails"/>with six parameters.
    ///</summary>
    ///<param name = "userID">It is a parameter which carries the userID of the user to the constructor of class<see cref = "BookingDetails"/>.</param>
    ///<param name = "movieID">It is a parameter which carries the movieId of the movie in theatre to the constructor of class<see cref = "BookingDetails"/>.
    ///<param name = "theatreId">It is a parameter which carries the theatreId of the theatres to the constructor of class<see cref = "BookingDetails"/>.</param>
    ///<param name = "seatCount">It is a parameter which carries the count of booked seats to the constructor of class<see cref = "BookingDetails"/>.</param>
    ///<param name = "totalPrice">It is a parameter which carries the total price of booked ticket to the constructor of class<see cref = "BookingDetails"/>.</param>
    ///<param name = "statusOfBooking">It is a parameter which carries the status of the booked ticket to the constructor of class<see cref = "BookingDetails"/>.</param>
    public BookingDetails(string userID,string movieID,string theatreID,int seatCount,double totalPrice,BookingStatus statusOfBooking){
        s_bookingID++;
        BookingID = "BID" + s_bookingID;
        UserID = userID;
        MovieID = movieID;
        TheatreID = theatreID;
        SeatCount = seatCount;
        TotalPrice = totalPrice;
        StatusOfBooking = statusOfBooking;
    }

    ///<summary>
    ///BookingDetails is the parameterized and overloaded Constructor of class<see cref = "BookingDetails"/>with one parameters.
    ///</summary>
    ///<param name = "data">It is a parameter which carries the datas as string of the theatres to the constructor of class<see cref = "BookingDetails"/> and it should be a seven comma seperated string.</param>
    public BookingDetails(string data){
        string[] values = data.Split(',');
        s_bookingID = int.Parse(values[0].Remove(0,3));
        BookingID = values[0];
        UserID = values[1];
        MovieID = values[2];
        TheatreID = values[3];
        SeatCount = int.Parse(values[4]);
        TotalPrice = double.Parse(values[5]);
        StatusOfBooking = Enum.Parse<BookingStatus>(values[6],true);
    }
}