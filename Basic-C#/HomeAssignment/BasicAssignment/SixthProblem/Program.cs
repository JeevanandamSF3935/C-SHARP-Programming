using System;
namespace SixthProblem;

class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the price");
        int price = int.Parse(Console.ReadLine());
        double totalPrice = (double)(price + (price * 0.18));
        Console.WriteLine($"Total = {totalPrice}");
        Console.ReadKey();
    }
}