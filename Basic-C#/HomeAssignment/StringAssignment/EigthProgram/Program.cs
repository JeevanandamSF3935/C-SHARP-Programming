using System;
namespace EigthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int startIndex = 0,lengthOfSubString = 0, count = 0;
        System.Console.WriteLine("Enter the input string :");
        string inputString = Console.ReadLine();
        System.Console.WriteLine("Enter position to start the extraction :");
        startIndex = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the length of substring :");
        lengthOfSubString = int.Parse(Console.ReadLine());
        char[] charsOfString = inputString.ToCharArray();
        char[] charsOfSubString = new char[lengthOfSubString];
        for(int i = startIndex;count < lengthOfSubString;i++){
            charsOfSubString[count] = charsOfString[i];
            count++;
        }
        for(int i = 0;i < lengthOfSubString;i++){
            System.Console.Write(charsOfSubString[i]);
        }
    }
}