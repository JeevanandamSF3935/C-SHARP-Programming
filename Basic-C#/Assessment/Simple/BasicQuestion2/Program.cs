using System;
namespace BasicQuestion2;
class Program
{
    public static void Main(string[] args)
    {
        double radius = 0, area = 0, perimeter = 0;
        System.Console.WriteLine("Enter the radius of the circle :");
        radius = double.Parse(Console.ReadLine());

        area = 3.14 * radius *radius;

        perimeter = 2 * 3.14 * radius;

        System.Console.WriteLine($"Area : {area}");
        System.Console.WriteLine($"Perimeter : {perimeter}");
    }
}