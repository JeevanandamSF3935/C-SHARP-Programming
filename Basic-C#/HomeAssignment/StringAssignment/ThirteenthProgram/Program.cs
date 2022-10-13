using System;
namespace ThirteenthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        System.Console.WriteLine("Enter the string with numbers :");
        string inputString = Console.ReadLine();
        foreach(char output in inputString){
            if((int)output >= 48 && (int)output <=57){
                sum = sum + output-'0';
            }
        }
        System.Console.WriteLine($"The sum of numbers in the string is {sum}");
    }
}