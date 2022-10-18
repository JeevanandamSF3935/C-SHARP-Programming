using System;
namespace Assignment2;
class Program
{
    public static void Main(string[] args)
    {
        int number1 = 0, number2 = 0, number3 = 0;
        System.Console.Write("Enter the first number : ");
        number1 = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the second number : ");
        number2 = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the third number : ");
        number3 = int.Parse(Console.ReadLine());
        if(number1 > number2 && number1 > number3){
            System.Console.WriteLine($"{number1} is greater");
        }
        else if(number2 > number3){
            System.Console.WriteLine($"{number2} is greater");
        }
        else{
            System.Console.WriteLine($"{number3} is greater");
        }
    }
}