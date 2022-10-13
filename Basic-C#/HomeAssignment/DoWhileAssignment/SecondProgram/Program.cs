using System;
namespace SecondProgram;
class Program
{
    public static void Main(string[] args)
    {
        int number = 0, sum = 0;
        do
        {
            System.Console.WriteLine("Enter the number :");
            number = int.Parse(Console.ReadLine());
            sum = sum + number;
        } while (number >= 0);
        number = number + (-2 * number);
        sum = sum + number;
        System.Console.WriteLine($"The sum is {sum}");
    }
}