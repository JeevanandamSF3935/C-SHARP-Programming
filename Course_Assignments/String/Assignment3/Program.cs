using System;
namespace Assignment3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Input : ");
        string inputString = Console.ReadLine();
        string[] outputString = inputString.Split(',');
        for(int iterator = 0; iterator < outputString.Length; iterator++){
            System.Console.WriteLine($"{iterator+1}.{outputString[iterator]}");
        } 
    }
}