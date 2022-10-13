using System;
namespace SeventhProgram;
class Program
{
    public static void Main(string[] args)
    {
        int vowelCount = 0,consonantCount = 0;
        System.Console.WriteLine("Input the string :");
        string inputString = Console.ReadLine();
        char[] charOfString = inputString.ToCharArray();
        for(int i = 0;i < charOfString.Length;i++){
            int asciiOfChar = (int) charOfString[i];
            if((asciiOfChar >= 65 && asciiOfChar <= 90) || (asciiOfChar >= 97 && asciiOfChar <= 122)){
                if(asciiOfChar == 65 || asciiOfChar == 69 || asciiOfChar == 73 || asciiOfChar == 79 || asciiOfChar == 85){
                    vowelCount++;
                }
                else if(asciiOfChar == 97 || asciiOfChar == 101 || asciiOfChar == 105 || asciiOfChar == 111 || asciiOfChar == 117){
                    vowelCount++;
                }
                else{
                    consonantCount++;
                }
            }
        }
        System.Console.WriteLine($"The total number of vowel in the string : {vowelCount}");
        System.Console.WriteLine($"The total number of consonant in the string : {consonantCount}");
    }
}