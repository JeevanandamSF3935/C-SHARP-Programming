using System;
namespace SeventhProgram;
class Program
{
    public static void Main(string[] args)
    {
        int checker = 0;
        System.Console.WriteLine("Enter the word :");
        string word = Console.ReadLine();
        bool result = PalindromeChecker(word,checker);
        if(result == true){
            System.Console.WriteLine($"The given string '{word}' is palindrome");
        }
        else{
            System.Console.WriteLine($"The given string '{word}' is not a palindrome");
        }

        //check palindrome or not function
        bool PalindromeChecker(string word ,int checker){
            if(checker > word.Length / 2 ){
                return true;
            }
            return word[checker] == word[word.Length - checker - 1] && PalindromeChecker(word,checker + 1);
        }
    }
}