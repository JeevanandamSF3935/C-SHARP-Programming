using System;
namespace SixthProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number :");
        int number = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"The factorial of {number}! is {Factorial(number)}");
        //factorial function
        int Factorial(int number){
            int factorial = 1;
            while(number > 0)
            {
                factorial = factorial * number;
                number--;
            }
            return factorial;
        }
    }
}