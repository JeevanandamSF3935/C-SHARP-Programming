using System;
namespace ThirdProblem;

class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the celcius value :");
        double celcius = double.Parse(Console.ReadLine());
        double kelvin = celcius + 273.5;
        double farenheit = (celcius * 9/5) + 32;
        Console.WriteLine($"Kelvin = {kelvin}\nFarenheit = {farenheit}");
        Console.ReadKey();
    }
}