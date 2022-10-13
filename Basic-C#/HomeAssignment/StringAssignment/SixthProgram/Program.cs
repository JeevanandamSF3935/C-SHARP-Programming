using System;
namespace SixthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int alphabetCount = 0,digitCount = 0, specialCharacCount = 0;
        System.Console.WriteLine("Input the string :");
        string inputString = Console.ReadLine();
        char[] givenString = inputString.ToCharArray();
        for(int i = 0;i < givenString.Length;i++){
            int asciiOfChar =(int)givenString[i];
            if((asciiOfChar <= 90 && asciiOfChar >= 65) || (asciiOfChar <=122 && asciiOfChar >=97)){
                alphabetCount++;
            }
            else if((asciiOfChar <= 47 && asciiOfChar >=32) || (asciiOfChar <= 64 && asciiOfChar >=58) || (asciiOfChar <= 96 && asciiOfChar >=91) || (asciiOfChar <= 126 && asciiOfChar >=123)){
                specialCharacCount++;
            }
            else{
                digitCount++;
            }
        }
        System.Console.WriteLine($"Number of Alphabets in the string \t\t: {alphabetCount}");
        System.Console.WriteLine($"Number of Digits in the string \t\t\t: {digitCount}");
        System.Console.WriteLine($"Number of Special characters in the string \t: {specialCharacCount}");
    }
}