namespace OnlineTheatreBookingApplication;

///<summary>
///TheatreDetails is a class contains a theatres details, properties and constructors
///</summary>
public class TheatreDetails
{
    ///<summary>
    ///s_theatreID is a static private field which is used to auto increase for theatreID generation in class<see cref = "TheatreDetails"/>
    ///</summary>
    private static int s_theatreID = 300;
    ///<summary>
    ///TheatreID is a property of class<see cref = "TheatreDetails"/> which get the theatreId.
    ///</summary>
    public string TheatreID { get;}
    ///<summary>
    ///TheatreName is a property of class<see cref = "TheatreDetails"/> which get and set the theatre name.
    ///</summary>
    public string TheatreName { get; set; }
    ///<summary>
    ///TheatreLocation is a property of class<see cref = "TheatreDetails"/> which get and set the theatre location.
    ///</summary>
    public string TheatreLocation { get; set; }

    ///<summary>
    ///TheatreDetails is the Default Constructor of class<see cref = "TheatreDetails"/>.
    ///</summary>
    public TheatreDetails(){

    }

    ///<summary>
    ///TheatreDetails is the parameterized and overloaded Constructor of class<see cref = "TheatreDetails"/>with two parameters.
    ///</summary>
    ///<param name = "theatreName">It is a parameter which carries the theatre name of the theatre to the constructor of class<see cref = "TheatreDetails"/>.</param>
    ///<param name = "theatreLocation">It is a parameter which carries the theatre location of the theatre to the constructor of class<see cref = "TheatreDetails"/>.</param>
    public TheatreDetails(string theatreName,string theatreLocation){
        s_theatreID++;
        TheatreID = "TID" + s_theatreID;
        TheatreName = theatreName;
        TheatreLocation = theatreLocation;
    }

    ///<summary>
    ///TheatreDetails is the parameterized and overloaded Constructor of class<see cref = "TheatreDetails"/>with one parameter.
    ///</summary>
    ///<param name = "data">It is a parameter which carries the datas as string of the theatres to the constructor of class<see cref = "TheatreDetails"/> and it should be a three comma seperated string.</param>
    public TheatreDetails(string data){
        string[] values = data.Split(',');
        s_theatreID = int.Parse(values[0].Remove(0,3));
        TheatreID = values[0];
        TheatreName = values[1];
        TheatreLocation = values[2];
    }
}