using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int inputNumber = 0, sum = 0, remainder = 0,checker = 0;
        System.Console.WriteLine("Enter the number :");
        inputNumber = int.Parse(Console.ReadLine());
        checker = inputNumber;
        while(checker > 0){
            remainder = checker % 10;
            sum = sum * 10 + remainder;
            checker = checker / 10;
        }
        if(inputNumber == sum){
            System.Console.WriteLine($"The given number {inputNumber} is a palindrome");
        }
        else{
            System.Console.WriteLine($"The given number {inputNumber} is not a palindrome");
        }
    }
}