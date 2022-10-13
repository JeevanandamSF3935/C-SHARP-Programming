using System;
namespace SeventhProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the customer ID :");
        int customerId = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the customer name :");
        String customerName = Console.ReadLine();
        
        System.Console.WriteLine("Enter the consumed units :");
        int usedElectricity = int.Parse(Console.ReadLine());


        double charge =0,surchargeAmount = 0,finalAmount = 0,amount = 0;
        if(usedElectricity > 0 && usedElectricity < 200){
            charge = 1.20;
            amount = (double)usedElectricity * 1.20;
        }
        else if(usedElectricity >= 200 && usedElectricity < 400){
            charge = 1.50;
            amount = (double)usedElectricity * 1.50;
        }
        else if(usedElectricity >=400 && usedElectricity < 600){
            charge = 1.80;
            amount = (double)usedElectricity * 1.80;
        }
        else if(usedElectricity>=600){
            charge = 2.0;
            amount = (double)usedElectricity * 2;
        }

        if(amount < 100){
            finalAmount = 100;
        }
        else if(amount > 400){
            surchargeAmount = amount * 0.15;
            finalAmount = amount + surchargeAmount;
        }
        else{
            finalAmount = amount;
        }
        System.Console.WriteLine($"Customer Id \t\t\t: {customerId}\nCustomer name \t\t\t: {customerName}\nUnit Consumed \t\t\t: {usedElectricity}\nAmount charges@Rs.{charge} per unit \t: {amount}\nSurcharge Amount \t\t: {surchargeAmount}\nNet amount paid by the customer : {finalAmount}");
    }
}