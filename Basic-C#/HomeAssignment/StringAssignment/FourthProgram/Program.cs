using System;
namespace FourthProgram;

class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        System.Console.WriteLine("Enter the string :");
        string inputString = Console.ReadLine();
        string[] seperatedString = inputString.Split(' ',',');
        foreach(string output in seperatedString){
            count++;
        }
        System.Console.WriteLine($"Total number of words in the string is : {count}");
    }
}