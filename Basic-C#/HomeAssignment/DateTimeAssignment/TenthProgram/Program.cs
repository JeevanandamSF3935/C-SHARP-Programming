using System;
namespace TenthProgram;
class Program
{
    public static void Main(string[] args)
    {
        DateTime todayDate = DateTime.Now;
        System.Console.WriteLine($"Yesterday : {todayDate.AddDays(-1).ToString("dd/MM/yyyy")}");
        System.Console.WriteLine();
        System.Console.WriteLine($"Tomorrow : {todayDate.AddDays(1).ToString("dd/MM/yyyy")}");
    }
}