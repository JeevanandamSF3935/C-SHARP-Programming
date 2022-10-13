using System;
namespace ThirdProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date and time in the formate of (dd/MM/yyyy hh:mm:ss tt) :");
        DateTime inputDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
        System.Console.WriteLine();
        System.Console.WriteLine($"Year\t\t: {inputDate.Year}");
        System.Console.WriteLine($"Month\t\t: {inputDate.Month}");
        System.Console.WriteLine($"Day\t\t: {inputDate.Day}");
        System.Console.WriteLine($"Hour\t\t: {inputDate.Hour}");
        System.Console.WriteLine($"Minute\t\t: {inputDate.Minute}");
        System.Console.WriteLine($"Second\t\t: {inputDate.Second}");
        System.Console.WriteLine($"Millisecond\t: {inputDate.Millisecond}");
    }
}