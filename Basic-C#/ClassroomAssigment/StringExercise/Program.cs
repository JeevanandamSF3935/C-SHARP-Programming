using System;
namespace StringAssignment;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the main string :");
        string mainString = Console.ReadLine();
        System.Console.WriteLine("Enter the string to be searched :");
        string subString = Console.ReadLine();
        string[] stringsArray = mainString.Split(subString);
        System.Console.WriteLine($"String Searched count is {stringsArray.Length-1}");
    }
}