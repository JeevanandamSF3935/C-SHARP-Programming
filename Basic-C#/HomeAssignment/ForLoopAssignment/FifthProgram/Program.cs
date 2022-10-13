using System;
namespace FifthProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms : ");
        int numberOfTerms = int.Parse(Console.ReadLine());
        int count = 1,sum=0;
        System.Console.Write("The odd numbers are:");
        for(int i=1;count<=numberOfTerms;i=i+2){
            System.Console.Write($"{i} ");
            sum = sum + i;
            count++;
        }
        System.Console.WriteLine($"\nThe Sum of odd Natural Number upto 10 terms: {sum}");
    }
}