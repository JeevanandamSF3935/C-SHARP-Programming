using System;
namespace NinthProblem;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the speed in Km/hr :");
        int speed = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the time in seconds :");
        int time = int.Parse(Console.ReadLine());
        
        double distance = (double)speed*time*5/18;

        Console.WriteLine($"Distance = {distance} meters");

        Console.ReadKey();
    }
}