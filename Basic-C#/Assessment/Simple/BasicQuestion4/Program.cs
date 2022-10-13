using System;
namespace BasicQuestion4;

class Program
{
    public static void Main(string[] args)
    {
        double rate = 0, usd = 0, eur = 0, cny = 0;
        System.Console.WriteLine("Enter the currency in rate :");
        rate  = double.Parse(Console.ReadLine());
        usd = rate * 1.22 / 100;
        eur = rate * 1.27 / 100;
        cny = rate * 8.79 / 100;

        usd = Math.Round(usd,3);
        eur = Math.Round(eur,3);
        cny = Math.Round(cny,3);

        System.Console.WriteLine($"The rate is {rate}");
        System.Console.WriteLine($"The USD of {rate} is {usd}");
        System.Console.WriteLine($"The EUR of {rate} is {eur}");
        System.Console.WriteLine($"The CNY of {rate} is {cny}");
    }
}