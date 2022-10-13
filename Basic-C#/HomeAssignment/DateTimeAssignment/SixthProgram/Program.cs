using System;
namespace SixthProgram;
class Program
{
    public static void Main(string[] args)
    {
        DateTime dateOfToday = DateTime.Now;
        System.Console.WriteLine($"Today : {dateOfToday}");
        System.Console.WriteLine($"Day after days from today : {dateOfToday.AddDays(40).DayOfWeek}");
    }
}