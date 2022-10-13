using System;
namespace FirstProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string :");
        int count = 0;
        string str = Console.ReadLine();
        foreach (char charOfStr in str)
        {
            count++;
        }
        System.Console.WriteLine($"Length of the string : {count}");
    }
}