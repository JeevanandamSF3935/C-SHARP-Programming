using System;
namespace FourthProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the date in the formate of (dd/MM/yyyy) :");
        DateTime inputDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        string day = inputDate.DayOfWeek.ToString();
        System.Console.WriteLine($"The day of the week for {inputDate.ToString("dd/MM/yyyy")} is {day}");
    }
}