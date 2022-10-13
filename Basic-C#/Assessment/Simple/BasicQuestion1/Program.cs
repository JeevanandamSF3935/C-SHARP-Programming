using System;
namespace BasicQuestion1;
class Program
{
    public static void Main(string[] args)
    {
        double centiMeter = 0, inches = 0;
        System.Console.WriteLine("Enter the length in Centimeter :");
        centiMeter = double.Parse(Console.ReadLine());
        inches = centiMeter * 2.54;
        System.Console.WriteLine($"{centiMeter} cm is equal to {inches} inches");
    }
}