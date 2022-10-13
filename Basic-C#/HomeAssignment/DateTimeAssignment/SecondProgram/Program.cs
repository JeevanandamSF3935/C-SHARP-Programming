using System;
namespace SecondProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date and time in the formate of (dd/MM/yyyy hh:mm:ss tt) :");
        DateTime inputDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null);
        System.Console.WriteLine();
        System.Console.WriteLine($"Complete Date \t\t: {inputDate}");
        System.Console.WriteLine($"Short Date \t\t: {inputDate.ToShortDateString()}");
        System.Console.WriteLine($"Long Date \t\t: {inputDate.ToLongDateString()}");
        System.Console.WriteLine($"12Hr Fomated time \t: {inputDate.ToString("hh:mm:ss tt")}");
        System.Console.WriteLine($"Date \t\t\t: {inputDate.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Time \t\t\t: {inputDate.ToString("hh:mm:ss tt")}");
    }
}