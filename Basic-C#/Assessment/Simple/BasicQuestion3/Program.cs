using System;
namespace BasicQuestion3;
class Program
{
    public static void Main(string[] args)
    {
        double celcius = 0, fahrenheit = 0;
        System.Console.WriteLine("Enter the degree in celcius :");
        celcius = double.Parse(Console.ReadLine());

        fahrenheit = (celcius * 9/5) + 32;
        System.Console.WriteLine($"{celcius} C is equal to {fahrenheit} F");
    }
}