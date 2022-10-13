using System;
namespace FourthProblem;

class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Radius :");
        int radius = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double volumeOfCylinder = (double) 3.14*radius*radius*height;
        Console.WriteLine($"Volume = {volumeOfCylinder}");
        Console.ReadKey();
    }
}