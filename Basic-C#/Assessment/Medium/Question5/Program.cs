using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        int year = 1,yearsCount = 0;
        System.Console.WriteLine("Print leap years between 1 to N");
        System.Console.WriteLine("Enter the value of N");
        yearsCount = int.Parse(Console.ReadLine());
        while(year <= yearsCount){
            if(year % 4 ==0){
                if(year % 100 == 0){
                    if(year % 400 == 0){
                        System.Console.Write($"{year}\t");
                    }
                }
                else{
                    System.Console.Write($"{year}\t");
                }
            }
            year++;
        }
    }
}