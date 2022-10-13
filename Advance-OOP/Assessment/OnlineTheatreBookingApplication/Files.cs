using System;
using System.IO;

namespace OnlineTheatreBookingApplication;
public class Files
{
    public static void CreateFile(){
        if(!Directory.Exists("OnlineTheatreBooking")){
            System.Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory("OnlineTheatreBooking");
        }
        else{
            System.Console.WriteLine("Folder Already Exists!");
        }



        if(!File.Exists("OnlineTheatreBooking\\UserDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("OnlineTheatreBooking\\UserDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!");
        }


        if(!File.Exists("OnlineTheatreBooking\\ScreeningDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("OnlineTheatreBooking\\ScreeningDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!");
        }


        if(!File.Exists("OnlineTheatreBooking\\TheatreDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("OnlineTheatreBooking\\TheatreDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!");
        }


        if(!File.Exists("OnlineTheatreBooking\\MovieDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("OnlineTheatreBooking\\MovieDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!");
        }


        if(!File.Exists("OnlineTheatreBooking\\BookingDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("OnlineTheatreBooking\\BookingDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!");
        }

    }

    public static void ReadFile(){

        string[] usersData = File.ReadAllLines("OnlineTheatreBooking\\UserDetails.csv");
        foreach(string user1 in usersData){
            UserDetails user = new UserDetails(user1);
            Operations.usersList.Add(user);
        }


        string[] theatresData = File.ReadAllLines("OnlineTheatreBooking\\TheatreDetails.csv");
        foreach(string theatre1 in theatresData){
            TheatreDetails theatre = new TheatreDetails(theatre1);
            Operations.theatresList.Add(theatre);
        }


        string[] moviesData = File.ReadAllLines("OnlineTheatreBooking\\MovieDetails.csv");
        foreach(string movie1 in moviesData){
            MovieDetails movie = new MovieDetails(movie1);
            Operations.moviesList.Add(movie);
        }


        string[] screensData = File.ReadAllLines("OnlineTheatreBooking\\ScreeningDetails.csv");
        foreach(string screen1 in screensData){
            ScreeningDetails screen = new ScreeningDetails(screen1);
            Operations.screeningsList.Add(screen);
        }


        string[] bookingData = File.ReadAllLines("OnlineTheatreBooking\\BookingDetails.csv");
        foreach(string booking1 in bookingData){
            BookingDetails booking = new BookingDetails(booking1);
            Operations.bookingsList.Add(booking);
        }

    }

    public static void WriteFile(){
        
        string[] usersData = new string[Operations.usersList.Count];
        for(int iterator = 0; iterator < Operations.usersList.Count; iterator++){
            usersData[iterator] = Operations.usersList[iterator].UserID+","+Operations.usersList[iterator].Name+","+Operations.usersList[iterator].Age+","+Operations.usersList[iterator].PhoneNumber+","+Operations.usersList[iterator].WalletBalance;
        }
        File.WriteAllLines("OnlineTheatreBooking\\UserDetails.csv",usersData);


        string[] moviesData = new string[Operations.moviesList.Count];
        for(int iterator = 0; iterator < Operations.moviesList.Count; iterator++){
            moviesData[iterator] = Operations.moviesList[iterator].MovieID+","+Operations.moviesList[iterator].MovieName+","+Operations.moviesList[iterator].Language;
        }
        File.WriteAllLines("OnlineTheatreBooking\\MovieDetails.csv",moviesData);


        string[] bookingsData = new String[Operations.bookingsList.Count];
        for(int iterator = 0; iterator < Operations.bookingsList.Count; iterator++){
            bookingsData[iterator] = Operations.bookingsList[iterator].BookingID+","+Operations.bookingsList[iterator].UserID+","+Operations.bookingsList[iterator].MovieID+","+Operations.bookingsList[iterator].TheatreID+","+Operations.bookingsList[iterator].SeatCount+","+Operations.bookingsList[iterator].TotalPrice+","+Operations.bookingsList[iterator].StatusOfBooking;
        }
        File.WriteAllLines("OnlineTheatreBooking\\BookingDetails.csv",bookingsData);


        string[] screensData = new string[Operations.screeningsList.Count];
        for(int iterator = 0; iterator < Operations.screeningsList.Count; iterator++){
            screensData[iterator] = Operations.screeningsList[iterator].MovieID+","+Operations.screeningsList[iterator].TheatreID+","+Operations.screeningsList[iterator].TicketPrice+","+Operations.screeningsList[iterator].NoOfSeatsAvailable;
        }
        File.WriteAllLines("OnlineTheatreBooking\\ScreeningDetails.csv",screensData);


        string[] theatresData = new string[Operations.theatresList.Count];
        for(int iterator = 0; iterator < Operations.theatresList.Count; iterator++){
            theatresData[iterator] = Operations.theatresList[iterator].TheatreID+","+Operations.theatresList[iterator].TheatreName+","+Operations.theatresList[iterator].TheatreLocation;
        }
        File.WriteAllLines("OnlineTheatreBooking\\TheatreDetails.csv",theatresData);

    }

}