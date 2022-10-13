using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        double vegetableQuantity = 0,vegetablePrice = 0, fruitQuantity = 0, fruitPrice = 0, earnings = 0;
        System.Console.Write("Enter the price of vegetable : ");
        vegetablePrice = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the price of fruit : ");
        fruitPrice = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the quantity of vegetable : ");
        vegetableQuantity = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the quantity of fruit : ");
        fruitQuantity = double.Parse(Console.ReadLine());

        vegetablePrice *= vegetableQuantity;
        fruitPrice *= fruitQuantity;

        earnings = vegetablePrice + fruitPrice;

        earnings /= 1.94;
        System.Console.WriteLine($"The total earnings in Euro is : {earnings}");
    }
}