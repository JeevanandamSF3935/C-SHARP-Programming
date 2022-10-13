using System;
namespace LoopQuestion1;
class Program
{
    public static void Main(string[] args)
    {
        int number = 0, power = 0, poweredValue = 1, iterator = 0;
        System.Console.WriteLine("Enter the number :");
        number = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the power :");
        power = int.Parse(Console.ReadLine());

        while(iterator < power){
            poweredValue = poweredValue * number;
            iterator++;
        }

        System.Console.WriteLine($"{number}^{power} value is {poweredValue}");
    }
}