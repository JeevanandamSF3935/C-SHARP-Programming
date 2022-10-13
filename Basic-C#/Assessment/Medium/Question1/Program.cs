using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int basicSalary = 0;
        double insurance = 0.01,annualGrossSalary = 0,tax= 0.06, annualTakeHomeSalary = 0;
        System.Console.WriteLine("Enter the basic salary :");
        basicSalary = int.Parse(Console.ReadLine());
        if(basicSalary <= 10000){
            annualGrossSalary = basicSalary + (basicSalary * 0.2) + (basicSalary * 0.8);
            annualGrossSalary = annualGrossSalary * 12;
        }
        else if(basicSalary <= 20000 && basicSalary >10000){
            annualGrossSalary = basicSalary + (basicSalary * 0.25) + (basicSalary * 0.9);
            annualGrossSalary = annualGrossSalary * 12;
        }
        else if(basicSalary > 20000){
            annualGrossSalary = basicSalary + (basicSalary * 0.3) + (basicSalary * 0.95);
            annualGrossSalary = annualGrossSalary * 12;
        }
        annualTakeHomeSalary = annualGrossSalary - (annualGrossSalary * tax) -(annualGrossSalary * insurance);
        System.Console.WriteLine($"The annual Take Home salary is : {annualTakeHomeSalary}");
    }
}