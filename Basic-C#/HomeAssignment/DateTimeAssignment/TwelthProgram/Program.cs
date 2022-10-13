
using System;
namespace TwelthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int day = 1;
        System.Console.WriteLine("Input the month no :");
        int monthNo = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Input the year :");
        int yearNo = Convert.ToInt32(Console.ReadLine());
        DateTime inputDate = new DateTime(yearNo,monthNo,day);
        TimeSpan daysCount = inputDate.AddMonths(1) - inputDate;
        System.Console.WriteLine($"The number of days in the month of {inputDate.ToString("MMMM")} is : {daysCount.TotalDays}");
    }
}