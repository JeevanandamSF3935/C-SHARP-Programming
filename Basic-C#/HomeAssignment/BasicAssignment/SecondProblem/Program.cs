using System;

namespace SecondProgram;

class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number :");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number :");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{number1} + {number2} = {number1+number2}");
        Console.WriteLine($"{number1} - {number2} = {number1-number2}");
        Console.WriteLine($"{number1} x {number2} = {number1*number2}");
        Console.WriteLine($"{number1} / {number2} = {number1/number2}");
        Console.WriteLine($"{number1} % {number2} = {number1%number2}");
        Console.ReadKey();
    }
}