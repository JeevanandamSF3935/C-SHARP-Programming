using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int workingDays = 0;
        float dailyEarnings = 0, exchangeRate = 0, usdToEUR = 0,usd = 0, bonus = 0,tax = 0, annumEarnings = 0, dayWiseIncome = 0;
        System.Console.WriteLine("Enter the number of days worked :");
        workingDays = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the daily earnings :");
        dailyEarnings = float.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the exchange rate :");
        exchangeRate = float.Parse(Console.ReadLine());

        usd = workingDays * dailyEarnings;
        bonus = usd * 2.5f ;
        annumEarnings = (usd * 12) + bonus;
        tax = annumEarnings * 0.25f;
        annumEarnings -= tax;
        usdToEUR = exchangeRate * annumEarnings;

        dayWiseIncome = usdToEUR / 365;
        System.Console.WriteLine($"The daily earnings in EUR : {dayWiseIncome}");
    }
}