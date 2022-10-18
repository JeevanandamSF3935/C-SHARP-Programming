using System;
namespace ForLoop;
class Program
{
    public static void Main(string[] args)
    {
        int number = 0, sumOfNumbers = 0;
        double average = 0;
        System.Console.WriteLine("Enter the 10 number :");
        for(int iterator = 0; iterator < 10; iterator++){
            number = int.Parse(Console.ReadLine());
            sumOfNumbers += number;
        }
        average = (double)sumOfNumbers / 10;
        System.Console.WriteLine($"The Sum of 10 numbers is : {sumOfNumbers}");
        System.Console.WriteLine($"The Average is : {average}");
    }
}