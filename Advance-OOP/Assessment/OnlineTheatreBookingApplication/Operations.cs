using System;

namespace OnlineTheatreBookingApplication;

public class Operations
{
    public static UserDetails currentLoggedInUser;

    public static List<UserDetails> usersList = new List<UserDetails>();
    public static List<TheatreDetails> theatresList = new List<TheatreDetails>();
    public static List<BookingDetails> bookingsList = new List<BookingDetails>();
    public static List<MovieDetails> moviesList = new List<MovieDetails>();
    public static List<ScreeningDetails> screeningsList = new List<ScreeningDetails>();

    public static void MainMenu(){
        bool check = true;
        try
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("\n\t\t*-*ONLINE MOVIE TICKET BOOKING*-*");
                System.Console.WriteLine("\t\t\t*****MAIN MENU*****");
                System.Console.WriteLine("1.User Registration\n2.Login\n3.Exit");
                int userChoice = int.Parse(Console.ReadLine());
                switch(userChoice){
                    case 1:{
                        UserRegistration();
                        break;
                    }
                    case 2:{
                        UserLogin();
                        break;
                    }
                    case 3:{
                        choice = "no";
                        break;
                    }
                }
            } while (choice == "yes");
            check = true;
        }
        catch (Exception e)
        {
            check = false;
            System.Console.WriteLine(e.Message);
        }
        finally{
            if(!check){
                MainMenu();
            }
        }
    }


    public static void SubMenu(){
        bool check = true;
        try
        {
            string choice = "yes";
            do
            {
                System.Console.WriteLine("\n\t\t*-*ONLINE MOVIE TICKET BOOKING*-*");
                System.Console.WriteLine("\t\t\t***SUB MENU***");
                System.Console.WriteLine("1.Ticket Booking\n2.Ticket Cancellation\n3.Booking History\n4.Wallet Recharge\n5.Log Out");
                int userChoice = int.Parse(Console.ReadLine());
                switch(userChoice){
                    case 1:{
                        TicketBooking();
                        break;
                    }
                    case 2:{
                        TicketCancellation();
                        break;
                    }
                    case 3:{
                        BookingHistory();
                        break;
                    }
                    case 4:{
                        WalletRecharge();
                        break;
                    }
                    case 5:{
                        System.Console.WriteLine("Going to Main Menu.....");
                        choice = "no";
                        break;
                    }
                }
            } while (choice == "yes");
            check = true;
        }
        catch (Exception e)
        {
            check = false;
            System.Console.WriteLine(e.Message);
        }
        finally{
            if(!check){
                SubMenu();
            }
        }
    }

    public static void UserRegistration(){
        bool check = true;
        try{
            System.Console.WriteLine("\n\t\t*-*ONLINE MOVIE TICKET BOOKING*-*");
            System.Console.WriteLine("\t\t\t**USER REGISTRATION**\n");
            System.Console.Write("Enter your name : ");
            string userName = Console.ReadLine();
            System.Console.Write("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            System.Console.Write("Enter your phone Number : ");
            long phoneNumber = long.Parse(Console.ReadLine());
            UserDetails user = new UserDetails(userName,age,phoneNumber);
            usersList.Add(user);
            System.Console.Write("Do you Want to recharge your wallet (YES or NO)?");
            string rechargeChoice = Console.ReadLine().ToLower();
            if(rechargeChoice.Equals("yes")){
                System.Console.Write("Enter the amount to be recharged in your wallet : ");
                double amount = double.Parse(Console.ReadLine());
                user.WalletRecharge(amount);
                System.Console.WriteLine($"Recharged Successfully!\nWallet Balance : {user.WalletBalance}");
            }
            System.Console.WriteLine($"Registered Successfully!\nYour User ID is {user.UserID}");
            check = true;
        }
        catch(Exception e){
            System.Console.WriteLine(e.Message);
            check = false;
        }
        finally{
            if(!check){
                System.Console.WriteLine("Enter a key to return to MainMenu");
                Console.ReadKey();
                System.Console.WriteLine("Returning to Mainmenu...");
            }
        }
    }

    public static void UserLogin(){
        bool loginCheck = true;
        System.Console.WriteLine("\n\t\t*-*ONLINE MOVIE TICKET BOOKING*-*");
            System.Console.WriteLine("\t\t\t***USER LOGIN***\n");
        System.Console.Write("Enter your User ID to login : ");
        string userID = Console.ReadLine().ToUpper();
        foreach(UserDetails user in usersList){
            if(user.UserID.Equals(userID)){
                System.Console.WriteLine("\nLOGIN SUCCESSFULL!");
                currentLoggedInUser = user;
                SubMenu();
                loginCheck = true;
                break;
            }
            else{
                loginCheck = false;
            }
        }
        if(!loginCheck){
            System.Console.WriteLine("Invalid UserID!!!\nLogin Unsuccessfull!");
        }
        System.Console.WriteLine("Enter a key to return to MainMenu");
        Console.ReadKey();
        System.Console.WriteLine("Returning to Mainmenu...");
    }

    public static void TicketBooking(){
        bool theatreCheck = true, seatCheck = true,screenCheck = true, check = true;
        double totalAmount = 0;
        System.Console.WriteLine("\n\t\t*-*-*TICKET BOOKING*-*-*");
        System.Console.WriteLine("\t\t\t**Theatres List**\n");
        System.Console.WriteLine("TheatreID\tTheatre Name\t\tTheatre Location");
        System.Console.WriteLine("----------------------------------------------------------");
        foreach(TheatreDetails theatre in theatresList){
            System.Console.WriteLine($"{theatre.TheatreID}\t\t{theatre.TheatreName}    \t\t{theatre.TheatreLocation}");
        }
        System.Console.Write("Select the theatre by entering the above showed TheatreId : ");
        string theatreID = Console.ReadLine().ToUpper();
        System.Console.WriteLine("\n\t\t*-*-*TICKET BOOKING*-*-*");
        System.Console.WriteLine("\t\t\t**Movies List**\n");
        System.Console.WriteLine("MovieID\t\tMovie Name\t\t\tLanguage");
        System.Console.WriteLine("----------------------------------------------------------------");
        foreach(TheatreDetails theatre in theatresList){
            if(theatre.TheatreID.Equals(theatreID)){
                foreach(ScreeningDetails screen in screeningsList){
                    if(screen.TheatreID.Equals(theatreID)){
                        foreach(MovieDetails movie in moviesList){
                            if(screen.MovieID.Equals(movie.MovieID)){
                                System.Console.WriteLine($"{movie.MovieID}\t\t{movie.MovieName}    \t\t{movie.Language}");
                            }
                        }
                    }
                }
                System.Console.Write("Select the movie by entering the movieID listed above : ");
                string movieID = Console.ReadLine().ToUpper();
                foreach(ScreeningDetails screen in screeningsList){
                    if(screen.MovieID.Equals(movieID) && (screen.TheatreID.Equals(theatreID))){
                        System.Console.Write("Enter the no of seats you want to book : ");
                        try{
                            int seatCount = int.Parse(Console.ReadLine());
                            if(seatCount <= screen.NoOfSeatsAvailable){
                                totalAmount = screen.TicketPrice * seatCount;
                                totalAmount += (0.18 * totalAmount);
                                if(totalAmount > currentLoggedInUser.WalletBalance){
                                    while(totalAmount > currentLoggedInUser.WalletBalance){
                                        System.Console.WriteLine($"Insufficient Wallet!\nRecharge your wallet.\nRequired Amount : {totalAmount - currentLoggedInUser.WalletBalance}\nYou are Redirecting to recharge section.....");
                                        WalletRecharge();
                                    }
                                }
                                currentLoggedInUser.WalletBalance -= totalAmount;
                                screen.NoOfSeatsAvailable -= seatCount;
                                BookingDetails booking = new BookingDetails(currentLoggedInUser.UserID,movieID,theatreID,seatCount,totalAmount,BookingStatus.Booked);
                                bookingsList.Add(booking);
                                System.Console.WriteLine($"Your Ticekt booked successfully\nBooking ID : {booking.BookingID}\n\nEnjoy your Movie!");
                                seatCheck = true;
                            }
                            else{
                                seatCheck = false;
                            }
                            check = true;
                        }catch(Exception e){
                            System.Console.WriteLine(e.Message);
                            System.Console.WriteLine("You are redirecting to Sub Menu");
                            check = false;
                        }
                        finally{
                            if(!check){
                                SubMenu();
                            }
                        }
                        screenCheck = true;
                        break;
                    }
                    else{
                        screenCheck = false;
                    }
                }
                if(!screenCheck){System.Console.WriteLine("\nInvalid screen selection!!!\nTry Again\n");}
                if(!seatCheck){System.Console.WriteLine("\nRequired seats not available!\n*_*Sorry for your Inconvenience");}
                theatreCheck = true;
                break;
            }
            else{
                theatreCheck = false;
            }
        }
        if(!theatreCheck){System.Console.WriteLine("\n\t\tInvalid TheatreID\n");}
        System.Console.WriteLine("Enter a key to return to SubMenu");
        Console.ReadKey();
        System.Console.WriteLine("Returning to submenu...");
    }

    public static void TicketCancellation(){
        bool bookingCheck = false;
        System.Console.WriteLine("\n\t\t\t*-*-*TICKET CANCELLATION*-*-*\n");
        System.Console.WriteLine("\t\t\t***Booking history for cancellation***\n");
        System.Console.WriteLine("BookingID\tUserID\tMovieID\tTheatreID\tSeat Count\tTotal Price\tBooking Status");
        System.Console.WriteLine("---------------------------------------------------------------------------------------------------");
        foreach(BookingDetails booking in bookingsList){
            if((booking.UserID.Equals(currentLoggedInUser.UserID)) && (booking.StatusOfBooking.Equals(BookingStatus.Booked))){
                System.Console.WriteLine($"{booking.BookingID}\t\t{booking.UserID}\t{booking.MovieID}\t{booking.TheatreID}\t\t{booking.SeatCount}\t\t{booking.TotalPrice}\t\t{booking.StatusOfBooking}");
            }
        }
        System.Console.Write("Enter the booking Id that you want to cancel : ");
        string bookingID = Console.ReadLine().ToUpper();
        foreach(BookingDetails booking in bookingsList){
            if(booking.BookingID.Equals(bookingID)){
                foreach(ScreeningDetails screen in screeningsList){
                    if((screen.TheatreID.Equals(booking.TheatreID)) && (screen.MovieID.Equals(booking.MovieID))){
                        screen.NoOfSeatsAvailable += booking.SeatCount;
                        currentLoggedInUser.WalletBalance += (booking.TotalPrice - 20);
                        booking.StatusOfBooking = BookingStatus.Cancelled;
                        System.Console.WriteLine($"Cancellation Successfull!\nRs.{booking.TotalPrice-20} has added to your wallet balance.");
                    }
                    break;
                }
                bookingCheck = true;
                break;
            }
            else{
                bookingCheck = false;
            }
        }
        if(!bookingCheck){System.Console.WriteLine("\nInvalid Booking ID!\nTicket Cancellation Unsuccessfull!\n");}
        System.Console.WriteLine("Enter a key to return to SubMenu");
        Console.ReadKey();
        System.Console.WriteLine("Returning to submenu...");
    }

    public static void BookingHistory(){
        int bookingCount = 0;
        System.Console.WriteLine("\n\t\t\t\t******BOOKING HISTORY******");
        System.Console.WriteLine($"BookingID\tUserID\tMovieID\tTheatreID\tSeat Count\tTotal Price\tBooking Status");
        System.Console.WriteLine("---------------------------------------------------------------------------------------------------");
        foreach(BookingDetails booking in bookingsList){
            if(currentLoggedInUser.UserID.Equals(booking.UserID)){
                System.Console.WriteLine($"{booking.BookingID}\t\t{booking.UserID}\t{booking.MovieID}\t{booking.TheatreID}\t\t{booking.SeatCount}\t\t{booking.TotalPrice}\t\t{booking.StatusOfBooking}");
                bookingCount++;
            }
        }
        if(bookingCount == 0){
            System.Console.WriteLine("\n\t\t\t\t*_*NOT YET BOOKED ANY TICKET*_*");
        }
        System.Console.WriteLine("Enter a key to return to SubMenu");
        Console.ReadKey();
        System.Console.WriteLine("Returning to submenu...");
    }

    public static void WalletRecharge(){
         System.Console.Write("Enter the amount to be recharged in your wallet : ");
        double amount = double.Parse(Console.ReadLine());
        currentLoggedInUser.WalletRecharge(amount);
        System.Console.WriteLine($"Recharged Successfully!\nWallet Balance : {currentLoggedInUser.WalletBalance}");
        System.Console.WriteLine("Enter a key to return to SubMenu");
        Console.ReadKey();
        System.Console.WriteLine("Returning to submenu...");
    }
 
 
}