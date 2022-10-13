using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int fibonacci1 = 0, fibonacci2 = 1,temp = 0,countOfTerms = 0,checker = 0;
        System.Console.WriteLine("Input number of terms to be displayed :");
        countOfTerms = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Here is fibonacci series upto {countOfTerms} terms :");
        while(checker < countOfTerms){
            System.Console.Write($"{fibonacci1} ");
            temp = fibonacci1 + fibonacci2;
            fibonacci1 = fibonacci2;
            fibonacci2 = temp;
            checker++;
        }
    }
}