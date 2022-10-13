using System;
namespace BasicQuestion5;
class Program
{
    public static void Main(string[] args)
    {
        int basicSalary = 0,daPercent = 10,hraPercent = 10, payableTax = 5;
        double netSalary = 0, annualIncome = 0;
        System.Console.WriteLine("Enter the basic salary :");
        basicSalary = int.Parse(Console.ReadLine());
        netSalary = basicSalary + (basicSalary * daPercent/100) + (basicSalary * hraPercent/100) - (basicSalary * payableTax/100);
        annualIncome = netSalary * 12;
        System.Console.WriteLine($"The annual income of the employee of basic pay Rs.{basicSalary} is Rs.{annualIncome}"); 
    }
}