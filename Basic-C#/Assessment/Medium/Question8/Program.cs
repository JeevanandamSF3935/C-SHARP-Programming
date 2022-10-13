using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        string inputString = "",numberString = "";
        int number = 0;
        System.Console.WriteLine("Enter the string");
        inputString = Console.ReadLine();
        char[] stringToChar = inputString.ToCharArray();
        for(int i = 0;i < stringToChar.Length;i++){
            if(Char.IsNumber(stringToChar[i])){
                numberString = numberString + stringToChar[i];
            }
        }
        number = int.Parse(numberString);
        if(number % 2 == 0){
            System.Console.WriteLine($"{number} is a even number");
        }
        else{
            System.Console.WriteLine($"{number} is a odd number");
        }
    }
}