using System;
namespace FourthProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number :");
        int number1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the second number :");
        int number2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the third number :");
        int number3 = int.Parse(Console.ReadLine());

        if(number1 > number2 && number1 > number3){
            System.Console.WriteLine("The 1st number is the greatest among three");
        }
        else if(number2 > number1 && number2 > number3){
            System.Console.WriteLine("The 2nd number is the greatest among three");
        }
        else{
            System.Console.WriteLine("The 3rd number is the greatest among three");
        }
    }
}