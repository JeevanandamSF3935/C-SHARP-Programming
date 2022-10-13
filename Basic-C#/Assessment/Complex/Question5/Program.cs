using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        string inputString = "",checkingString = "";
        System.Console.WriteLine("Enter the string :");
        inputString = Console.ReadLine();
        for(int i = inputString.Length-1; i >= 0;i--){
            checkingString += inputString[i];
        }
        if(inputString == checkingString){
            System.Console.WriteLine($"{inputString} is a palindrome");
        }
        else{
            System.Console.WriteLine($"{inputString} is not a palindrome");
        }
    }
}