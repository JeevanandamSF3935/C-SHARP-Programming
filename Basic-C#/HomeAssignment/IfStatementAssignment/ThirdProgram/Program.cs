using System;
namespace ThirdProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the year :");
        int year = int.Parse(Console.ReadLine());
        if(year % 4 == 0 && year % 100 != 0){
            System.Console.WriteLine($"{year} is a leap year");
        }
        else if(year % 100 == 0 && year % 400 == 0){
            System.Console.WriteLine($"{year} is a leap year");
        }
        else{
            System.Console.WriteLine($"{year} is not a leap year");
        }
    }
}