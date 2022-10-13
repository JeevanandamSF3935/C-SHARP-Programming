using System;
namespace SecondProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string :");
        string inputString = Console.ReadLine();
        
        System.Console.WriteLine("The characters of the string :");
        for(int i = 0;i < inputString.Length;i++){
            System.Console.Write($"{inputString[i]} ");
        }
    }
}