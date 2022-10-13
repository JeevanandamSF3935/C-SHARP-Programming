using System;
namespace FifthProgram;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number :");
        int number = int.Parse(Console.ReadLine());

        int sum = 0,reminder, temp = number;
        while(temp > 0){
            reminder = temp % 10;
            sum = sum + reminder;
            temp = temp / 10;
        }
        System.Console.WriteLine($"Sum of digits of {number} is {sum}");
    }
}