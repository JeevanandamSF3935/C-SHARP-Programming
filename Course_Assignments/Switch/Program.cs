using System;
namespace Switch;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the first number : ");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the second number : ");
        int number2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Choice :\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
        int choice = int.Parse(Console.ReadLine());
        switch(choice){
            case 1:{
                int add = number1 + number2;
                System.Console.WriteLine($"Addition : {add}");
                break;
            }
            case 2:{
                int subtraction = number1 - number2;
                System.Console.WriteLine($"Subtraction : {subtraction}");
                break;
            }
            case 3:{
                int multiply = number1 * number2;
                System.Console.WriteLine($"Multiplication : {multiply}");
                break;
            }
            case 4:{
                int division = number1 / number2;
                System.Console.WriteLine($"Divison : {division}");
                break;
            }
            default:{
                System.Console.WriteLine("Invalid choice ");
                break;
            }
        }
    }
}