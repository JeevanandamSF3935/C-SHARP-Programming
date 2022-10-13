namespace OnlineTheatreBookingApplication;

///<summary>
///ScreeningDetails is a class contains a screen details,properties and constructors
///</summary>
public class ScreeningDetails
{
    ///<summary>
    ///MovieID is a property of class<see cref = "ScreeningDetails"/> which get and set the movieId.
    ///</summary>
    public string MovieID { get; set; }
    ///<summary>
    ///TheatreID is a property of class<see cref = "ScreeningDetails"/> which get and set the theatreId.
    ///</summary>
    public string TheatreID { get; set; }
    ///<summary>
    ///NoOfSeatsAvailable is a property of class<see cref = "ScreeningDetails"/> which get and set the 
    ///no of seats that available in the theatre.
    ///</summary>
    public int NoOfSeatsAvailable { get; set; }
    ///<summary>
    ///TicketPrice is a property of class<see cref = "ScreeningDetails"/> which get and set the price of the single
    ///ticket of the movie. 
    ///</summary>
    public double TicketPrice { get; set; }
    ///<summary>
    ///ScreeningDetails is the Default Constructor of class<see cref = "ScreeningDetails"/>.
    ///</summary>
    public ScreeningDetails(){

    }

    ///<summary>
    ///ScreeningDetails is the parameterized and overloaded Constructor of class<see cref = "ScreeningDetails"/> with four parameters.
    ///</summary>
    ///<param name = "movieID">It is a parameter which carries the movieID of the movies in theatre to the constructor of class<see cref = "ScreeningDetails"/>.</param>
    ///<param name = "theatreID">It is a parameter which carries the theatreID of the theatre to the constructor of class<see cref = "ScreeningDetails"/>.</param>
    ///<param name = "seatCount">It is a parameter which carries the seat count that present in theatre to the constructor of class<see cref = "ScreeningDetails"/>.</param>
    ///<param name = "ticketPrice">It is a parameter which carries the price for the ticket of the movie in theatre to the constructor of class<see cref = "ScreeningDetails"/>.</param>
    public ScreeningDetails(string movieID,string theatreID,int seatCount,double ticketPrice){
        MovieID = movieID;
        TheatreID = theatreID;
        NoOfSeatsAvailable = seatCount;
        TicketPrice = ticketPrice;
    }

    ///<summary>
    ///ScreeningDetails is the parameterized and overloaded Constructor of class<see cref = "ScreeningDetails"/> with one parameter.
    ///</summary>
    ///<param name = "data">It is a parameter which carries the datas as string of the screens of theatres to the constructor of class<see cref = "ScreeningDetails"/> and it should be a four comma seperated string.</param>
    public ScreeningDetails(string data){
        string[] values = data.Split(',');
        MovieID = values[0];
        TheatreID = values[1];
        NoOfSeatsAvailable = int.Parse(values[2]);
        TicketPrice = double.Parse(values[3]);
    }
}