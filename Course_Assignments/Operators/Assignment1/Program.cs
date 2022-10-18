using System;
namespace Assignment1;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the first number : ");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the second number : ");
        int number2 = int.Parse(Console.ReadLine());
        int add = number1 + number2;
        System.Console.WriteLine($"Addition : {add}");
        int subtraction = number1 - number2;
        System.Console.WriteLine($"Subtraction : {subtraction}");
        int multiply = number1 * number2;
        System.Console.WriteLine($"Multiplication : {multiply}");
        int division = number1 / number2;
        System.Console.WriteLine($"Divison : {division}");
        int modulus = number1 % number2;
        System.Console.WriteLine($"Modulus : {modulus}");
    }
}