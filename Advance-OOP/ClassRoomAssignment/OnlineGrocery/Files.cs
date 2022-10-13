using System;
using System.IO;

namespace OnlineGrocery;
public class Files
{
    /*
        Check and create folder OnlineBooking
        Check and create files for CustomerDetails,ProductDetails,BookingDetails,OrderDetails
        Read data from file to local list
        Write data to the file from local list
        */
    public static void CreateFile(){
        //Directory creation
        if(!Directory.Exists("OnlineBooking")){
            System.Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory("OnlineBooking");
        }
        else{
            System.Console.WriteLine("Folder Already Exists!!!");
        }

        //CustomerDetails file creation
        if(!File.Exists("OnlineBooking\\CustomerDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("OnlineBooking\\CustomerDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists");
        }

        //ProductDetails file creation
        if(!File.Exists("OnlineBooking\\ProductDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("OnlineBooking\\ProductDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists");
        }

        //BookingDetails file creation
        if(!File.Exists("OnlineBooking\\BookingDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("OnlineBooking\\BookingDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists");
        }

        //OrderDetails file creation
        if(!File.Exists("OnlineBooking\\OrderDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("OnlineBooking\\OrderDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists");
        }
    }

    //Read data from file to local list
    public static void ReadFile(){

        //From CustomerDetails file
        string[] customersDetail = File.ReadAllLines("OnlineBooking\\CustomerDetails.csv");
        foreach(string customer in customersDetail){
            CustomerRegistration customer1 = new CustomerRegistration(customer);
            Operations.customersList.Add(customer1);
        }

        //From ProductDetails file
        string[] productsDetail = File.ReadAllLines("OnlineBooking\\ProductDetails.csv");
        foreach(string product in productsDetail){
            ProductDetails product1 = new ProductDetails(product);
            Operations.productsList.Add(product1);
        }

        //From BookingDetails file
        string[] bookingsDetail = File.ReadAllLines("OnlineBooking\\BookingDetails.csv");
        foreach(string booking in bookingsDetail){
            BookingDetails booking1 = new BookingDetails(booking);
            Operations.bookingsList.Add(booking1);
        }

        //From Orderdetails file
        string[] ordersDetail = File.ReadAllLines("OnlineBooking\\OrderDetails.csv");
        foreach(string order in ordersDetail){
            OrderDetails order1 = new OrderDetails(order);
            Operations.ordersList.Add(order1);
        }
    }


    //Write data to file from local list
    public static void WriteFile(){
        
        //To CustomerDetails file
        string[] customersData = new string[Operations.customersList.Count];
        for(int i = 0; i < Operations.customersList.Count;i++){
            customersData[i] = Operations.customersList[i].CustomerID+","+Operations.customersList[i].WalletBalance+","+Operations.customersList[i].Name+","+Operations.customersList[i].FatherName+","+Operations.customersList[i].UserGender+","+Operations.customersList[i].MobileNumber+","+Operations.customersList[i].DateOfBirth.ToString("dd/MM/yyyy")+","+Operations.customersList[i].MailID;
        }
        File.WriteAllLines("OnlineBooking\\CustomerDetails.csv",customersData);
    
        //To CustomerDetails file
        string[] productsData = new string[Operations.productsList.Count];
        for(int i = 0; i < Operations.productsList.Count;i++){
            productsData[i] = Operations.productsList[i].ProductID+","+Operations.productsList[i].ProductName+","+Operations.productsList[i].QuantityAvailable+","+Operations.productsList[i].PricePerQuantity;
        }
        File.WriteAllLines("OnlineBooking\\ProductDetails.csv",productsData);

        //To OrderDetails file
        string[] ordersData = new string[Operations.ordersList.Count];
        for(int i = 0; i < Operations.ordersList.Count;i++){
            ordersData[i] = Operations.ordersList[i].OrderID+","+Operations.ordersList[i].BookingID+","+Operations.ordersList[i].ProductID+","+Operations.ordersList[i].PurchaseCount+","+Operations.ordersList[i].PriceOfOrder;
        }
        File.WriteAllLines("OnlineBooking\\OrderDetails.csv",ordersData);

        //To BookingDetails file
        string[] bookingsData = new string[Operations.bookingsList.Count];
        for(int i = 0; i < Operations.bookingsList.Count;i++){
            bookingsData[i] = Operations.bookingsList[i].BookingID+","+Operations.bookingsList[i].CustomerID+","+Operations.bookingsList[i].TotalPrice+","+Operations.bookingsList[i].BookingDate.ToString("dd/MM/yyyy")+","+Operations.bookingsList[i].StatusOfBooking;
        }
        File.WriteAllLines("OnlineBooking\\BookingDetails.csv",bookingsData);

    }
}