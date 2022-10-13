using System;
namespace SeventhProblem;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number :");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        int number2 = int.Parse(Console.ReadLine());
        int outputNumber = (number1*number1)+(2*number1*number2)+(number2*number2);
        Console.WriteLine($"Output = {outputNumber}");
        Console.ReadKey();
    }
}