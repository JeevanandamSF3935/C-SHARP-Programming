using System;
namespace Assignment1;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        System.Console.Write("Enter the string : ");
        string inputString = Console.ReadLine();
        char[] stringToChar = inputString.ToCharArray();
        System.Console.WriteLine("\nOdd number of characters in string :");
        for(int iterator = 0; iterator < inputString.Length; iterator++){
            if(iterator % 2 != 0){
                System.Console.Write($"{stringToChar[iterator]}");
            }
        }

        System.Console.WriteLine("\n\nResult of replaced value in the string :");
        char[] temp = stringToChar;
        for(int iterator = 0; iterator < inputString.Length; iterator++){
            if(temp[iterator] == 'n'){
                temp[iterator] = 'N';
            }
            System.Console.Write($"{temp[iterator]}");
        }

        stringToChar = inputString.ToCharArray();
        System.Console.WriteLine("\n\nReversed string :");
        for(int iterator = inputString.Length-1; iterator >=0; iterator--){
            System.Console.Write($"{stringToChar[iterator]}");
        }

        foreach(char charInString in stringToChar){
            count++;
        }
        System.Console.WriteLine($"\n\nThe length of the string is : {count}");
    }
}