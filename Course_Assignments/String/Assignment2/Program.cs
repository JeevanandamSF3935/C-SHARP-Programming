using System;
namespace Assignment2;
class Program
{
    public static void Main(string[] args)
    {
        string inputString1 = "", inputString2 = "",outputString = "";
        System.Console.Write("Enter the first string : ");
        inputString1 = Console.ReadLine();
        System.Console.Write("Enter the second string : ");
        inputString2 = Console.ReadLine();
        for(int iterator = 0; iterator < 4; iterator++){
            outputString += inputString1[iterator];
        }
        for(int iterator = inputString2.Length-3;iterator < inputString2.Length;iterator++){
            outputString += inputString2[iterator];
        }
        System.Console.WriteLine($"Output : {outputString}");
    }
}