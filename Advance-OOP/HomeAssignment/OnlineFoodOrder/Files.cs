using System;
using System.IO;

namespace OnlineFoodOrder;
public class Files
{
    public static void CreateFile(){
        if(!Directory.Exists("FoodDelivery")){
            System.Console.WriteLine("Creating Folder");
            Directory.CreateDirectory("FoodDelivery");
        }
        else{
            System.Console.WriteLine("Folder Already Exists!!!");
        }
        if(!File.Exists("FoodDelivery\\CustomerDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("FoodDelivery\\CustomerDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }
        if(!File.Exists("FoodDelivery\\FoodDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("FoodDelivery\\FoodDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }

        if(!File.Exists("FoodDelivery\\OrderDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("FoodDelivery\\OrderDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }

        if(!File.Exists("FoodDelivery\\BookingDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("FoodDelivery\\BookingDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }

    }

    public static void ReadFile(){
        
        string[] userData = File.ReadAllLines("FoodDelivery\\CustomerDetails.csv");
        foreach(string user in userData){
            CustomerRegistration customer = new CustomerRegistration(user);
            Process.customersList.Add(customer);
        }

        string[] foodData = File.ReadAllLines("FoodDelivery\\FoodDetails.csv");
        foreach(string food in foodData){
            FoodDetails food1 = new FoodDetails(food);
            Process.foodsList.Add(food1);
        }

        string[] orderData = File.ReadAllLines("FoodDelivery\\OrderDetails.csv");
        foreach(string order in orderData){
            OrderDetails order1 = new OrderDetails(order);
            Process.globalOrdersList.Add(order1);
        }

        string[] bookingData = File.ReadAllLines("FoodDelivery\\BookingDetails.csv");
        foreach(string booking in bookingData){
            BookingDetails booking1 = new BookingDetails(booking);
            Process.bookingsList.Add(booking1);
        }
    }

    public static void WriteFile(){
        
        string[] userData = new string[Process.customersList.Count];
        for(int i = 0;i < Process.customersList.Count;i++){
            userData[i] = Process.customersList[i].CustomerId+","+Process.customersList[i].WalletBalance+","+Process.customersList[i].Name+","+Process.customersList[i].FatherName+","+Process.customersList[i].UserGender+","+Process.customersList[i].MobileNumber+","+Process.customersList[i].DOB.ToString("dd/MM/yyyy")+","+Process.customersList[i].MailId+","+Process.customersList[i].Location;
        }
        File.WriteAllLines("FoodDelivery\\CustomerDetails.csv",userData);

        string[] orderData = new string[Process.globalOrdersList.Count];
        for(int i = 0;i < Process.globalOrdersList.Count;i++){
            orderData[i] = Process.globalOrdersList[i].OrderID+","+Process.globalOrdersList[i].BookingID+","+Process.globalOrdersList[i].FoodID+","+Process.globalOrdersList[i].PurchaseCount+","+Process.globalOrdersList[i].PriceOfOrder;
        }
        File.WriteAllLines("FoodDelivery\\OrderDetails.csv",orderData);

        string[] bookingData = new string[Process.bookingsList.Count];
        for(int i = 0;i < Process.bookingsList.Count;i++){
            bookingData[i] = Process.bookingsList[i].BookingID+","+Process.bookingsList[i].CustomerID+","+Process.bookingsList[i].TotalPrice+","+Process.bookingsList[i].DateOfBooking.ToString("dd/MM/yyyy")+","+Process.bookingsList[i].Status;
        }
        File.WriteAllLines("FoodDelivery\\BookingDetails.csv",bookingData);

    }

}