using System;
namespace EigthProgram;
class Program
{
    public static void Main(string[] args)
    {
        DateTime todayDate = DateTime.Now;
        System.Console.WriteLine($"-1 : {todayDate.ToString("dd/MM/yyyy")} is later than {todayDate.AddYears(-1).ToString("dd/MM/yyyy")}");
        System.Console.WriteLine();
        System.Console.WriteLine($"1 : {todayDate.ToString("dd/MM/yyyy")} is earlier than {todayDate.AddYears(1).ToString("dd/MM/yyyy")}");
    }
}