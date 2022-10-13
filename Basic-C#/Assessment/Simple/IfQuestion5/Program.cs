using System;
namespace IfQuestion5;
class Program
{
    public static void Main(string[] args)
    {
        char inputCharacter;
        System.Console.WriteLine("Enter the character :");
        inputCharacter = char.Parse(Console.ReadLine());
        string charToString = inputCharacter.ToString().ToLower();
        
        switch(charToString){
            case "a":{
                System.Console.WriteLine("It is a vowel");
                break;
            }
            case "e":{
                System.Console.WriteLine("It is a vowel");
                break;
            }
            case "i":{
                System.Console.WriteLine("It is a vowel");
                break;
            }
            case "o":{
                System.Console.WriteLine("It is a vowel");
                break;
            }
            case "u":{
                System.Console.WriteLine("It is a vowel");
                break;
            }
            default:{
                System.Console.WriteLine("It is not a vowel");
                break;
            }
        }
    }
}