using System;
namespace WhileLoopAssignment;

class Program{
    public static void Main(string[] args)
    {
        int number = 0;
        while(number < 25){
            if(number % 2 == 0){
                System.Console.Write($"{number} ");
            }
            number++;
        }
        bool temp = false;
        int inputNumber = 0;
        while(temp == false){
            System.Console.WriteLine("\nEnter the number to be validated ");
            temp = int.TryParse(Console.ReadLine(),out inputNumber);
            if(temp == false){
                System.Console.WriteLine("Invalid input format. Please enter the input in number format");
            }
            else{
                break;
            }
        }
        System.Console.WriteLine($"The number entered is {inputNumber}");
    }
}