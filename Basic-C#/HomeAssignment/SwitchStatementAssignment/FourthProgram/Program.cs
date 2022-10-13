using System;
namespace FourthProgram;

class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number :");
        int number1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the second number :");
        int number2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the choice :\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
        int choice = int.Parse(Console.ReadLine());
        switch(choice){
            case 1:
            {
                System.Console.WriteLine($"The addition of {number1} and {number2} is {number1+number2}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"The subtraction of {number1} and {number2} is {number1-number2}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"The multiplication of {number1} and {number2} is {number1*number2}");
                break;
            }
            case 4:
            {
                System.Console.WriteLine($"The division of {number1} and {number2} is {number1/number2}");
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Exiting");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}