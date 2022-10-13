using System;
namespace FifthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        System.Console.WriteLine("Enter the first year :");
        DateTime firstYear = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        System.Console.WriteLine("Enter the second year :");
        DateTime secondYear = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        while(firstYear <= secondYear){
            TimeSpan days = firstYear.AddYears(1) - firstYear; 
            int daysCount = Convert.ToInt32(days.TotalDays);
            if(daysCount <= 365){
                System.Console.WriteLine($"{firstYear.AddDays(daysCount-1).ToString("dd/MM/yyyy")}: day {daysCount} of {firstYear.Year}");
            }
            else{
                System.Console.WriteLine($"{firstYear.AddDays(daysCount-1).ToString("dd/MM/yyyy")}: day {daysCount} of {firstYear.Year} (Leap Year)");
            }
            firstYear = firstYear.AddYears(1);
        }
    }
}