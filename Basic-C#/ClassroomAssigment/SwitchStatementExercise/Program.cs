using System;

namespace SwitchStatement;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number :");
        int number1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the second number");
        int number2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the choice (+,-,*,/,%) :");
        char choice = char.Parse(Console.ReadLine());

        switch(choice){
            case '+':
            {
                System.Console.WriteLine($"Result is {number1+number2}");
                break;
            }
            case '-':
            {
                System.Console.WriteLine($"Result is {number1-number2}");
                break;
            }
            case '*':
            {
                System.Console.WriteLine($"Result is {number1*number2}");
                break;
            }
            case '/':
            {
                System.Console.WriteLine($"Result is {number1/number2}");
                break;
            }
            case '%':
            {
                System.Console.WriteLine($"Result is {number1%number2}");
                break;
            }
            default :
            {
                System.Console.WriteLine("Operation Invalid");
                break;
            }
        }
    }
}