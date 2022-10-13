using System;
namespace NinthProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first year in the formate (yyyy):");
        DateTime firstYear = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        System.Console.WriteLine("Enter the second year in the formate (yyyy):");
        DateTime secondYear = DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
        while(firstYear <= secondYear){
            int first = Convert.ToInt32(firstYear.Year);
            if(DateTime.IsLeapYear(first)){
                System.Console.WriteLine($"{firstYear.Year} is a leap year.");
                System.Console.WriteLine($" One year from 2/29/{firstYear.Year} is 2/28/{firstYear.AddYears(1).Year}");
            }
            firstYear = firstYear.AddYears(1);
        }
    }
}