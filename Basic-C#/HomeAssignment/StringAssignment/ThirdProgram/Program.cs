using System;
namespace ThirdProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input string :");
        string inputString = Console.ReadLine();
        for(int i = inputString.Length - 1;i >= 0;i--){
            System.Console.Write($"{inputString[i]} ");
        }
    }
}