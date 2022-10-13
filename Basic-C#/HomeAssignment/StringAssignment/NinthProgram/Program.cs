using System;
namespace NinthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int checker = 0;
        System.Console.WriteLine("Enter the string :");
        string inputString = Console.ReadLine();
        System.Console.WriteLine("Enter the substring to search :");
        string subString = Console.ReadLine();
        string[] seperatedInputString = inputString.Split(' ',',');
        foreach(string input in seperatedInputString){
            if(input.Length == subString.Length){
                if(input == subString) checker = 1;
                break;
            }
            else{
                checker = 0;
            }
        }
        if(checker == 1){
            System.Console.WriteLine("The substring exists in the string");
        }
        else{
            System.Console.WriteLine("The substring not exixts in the string");
        }
    }
}