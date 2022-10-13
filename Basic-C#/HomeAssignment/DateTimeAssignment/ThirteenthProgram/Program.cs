using System;
namespace ThirteenthProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input the day (dd) :");
        int day = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the month (MM) :");
        int month = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the year (yyyy) :");
        int year = int.Parse(Console.ReadLine());

        DateTime inputDate = new DateTime(year,month,day);
        System.Console.WriteLine($"The formatted Date is: {inputDate.ToString("dd/MM/yyyy")}");
        while(inputDate.DayOfWeek.ToString() != "Sunday"){
            inputDate = inputDate.AddDays(1);
        }
        System.Console.WriteLine($"The last day of the week for the above date is : {inputDate.ToString("dd/MM/yyyy")}");
    }
}