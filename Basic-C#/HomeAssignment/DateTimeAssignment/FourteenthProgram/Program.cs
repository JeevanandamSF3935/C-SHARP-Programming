using System;
namespace FourteenthProgram;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month in the formate (MM) :");
        DateTime inputMonth = DateTime.ParseExact(Console.ReadLine(),"MM",null);
        System.Console.WriteLine("Enter number of leaves taken :");
        int leaveCount = int.Parse(Console.ReadLine());

        TimeSpan workingDays = inputMonth.AddMonths(1) - inputMonth;
        int salary = ((int)workingDays.TotalDays -leaveCount) * 500;
        System.Console.WriteLine($"Salary : {salary}");

    }
}