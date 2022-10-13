using System;
namespace FirstProgram;

class Program
{
    public static void Main(string[] args)
    {
        string choice = "";
        do
        {
            int number = 0;
            System.Console.WriteLine("Enter the number :");
            bool temp = int.TryParse(Console.ReadLine(),out number);
            if(temp == true){
                if(number % 2 == 0){
                    System.Console.WriteLine($"Given number {number} is Even");
                }
                else{
                    System.Console.WriteLine($"Given number {number} is Odd");
                }
                System.Console.WriteLine("Do you want check again? (Yes or No)");
                choice = Console.ReadLine().ToUpper();
            }
            else{
                System.Console.WriteLine("Invalid input,enter the valid input");
            }
        } while (choice != "NO");
    }
}