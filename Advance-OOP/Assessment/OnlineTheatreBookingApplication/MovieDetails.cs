namespace OnlineTheatreBookingApplication;
///<summary>
///MovieDetails is a class contains a movies details, properties and constructors
///</summary>
public class MovieDetails
{
    ///<summary>
    ///s_movieID is a static private field which is used to auto increase for movieID generation in class<see cref = "MovieDetails"/>
    ///</summary>
    private static int s_movieID = 500;
    ///<summary>
    ///MovieID is a property of class<see cref = "BookingDetails"/> which get the MovieID.
    ///</summary>
    public string MovieID { get; }
    ///<summary>
    ///MovieName is a property of class<see cref = "BookingDetails"/> which get and set the movie name.
    ///</summary>
    public string MovieName { get; set; }
    ///<summary>
    ///Language is a property of class<see cref = "BookingDetails"/> which get and set the language of movie.
    ///</summary>
    public string Language { get; set; }

    ///<summary>
    ///MovieDetails is the Default Constructor of class<see cref = "MovieDetails"/>.
    ///</summary>
    public MovieDetails(){

    }

    ///<summary>
    ///MovieDetails is the parameterized and overloaded Constructor of class<see cref = "MovieDetails"/>with two parameters.
    ///</summary>
    ///<param name = "movieName">It is a parameter which carries the movie name of the movies in theatres to the constructor of class<see cref = "MovieDetails"/>.</param>
    ///<param name = "language">It is a parameter which carries the language of tha movies in th theatres to the constructor of class<see cref = "MovieDetails"/>.</param>
    public MovieDetails(string movieName,string language){
        s_movieID++;
        MovieID = "MID" + s_movieID;
        MovieName = movieName;
        Language = language;
    }

    ///<summary>
    ///MovieDetails is the parameterized and overloaded Constructor of class<see cref = "MovieDetails"/>with one parameter.
    ///</summary>
    ///<param name = "">It is a parameter which carries the datas as string of the theatres to the constructor of class<see cref = "MovieDetails"/> and it should be a three comma seperated string.</param>
    public MovieDetails(string data){
        string[] values = data.Split(',');
        s_movieID = int.Parse(values[0].Remove(0,3));
        MovieID = values[0];
        MovieName = values[1];
        Language = values[2];
    }
}