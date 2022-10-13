using System;
namespace EleventhProgram;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        DateTime todayDate = DateTime.Now;
        System.Console.WriteLine($"The date of Today : {todayDate.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine("The twelve months are:");
        while(count < 12){
            System.Console.WriteLine(todayDate.ToString("MMMM"));
            todayDate = todayDate.AddMonths(1);
            count++;
        }
    }
}