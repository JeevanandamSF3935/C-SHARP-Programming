using System;
namespace DateTime1;
class Program
{
    public static void Main(string[] args)
    {
        DateTime todayDate = DateTime.Now;
        System.Console.WriteLine($"Current Month : {todayDate.Month}");
        System.Console.WriteLine($"Previous of 3 Days : {todayDate.AddDays(-3)}");
        System.Console.WriteLine($"12 Hrs formate time : {todayDate.ToString("hh:mm:ss tt")}");
    }
}