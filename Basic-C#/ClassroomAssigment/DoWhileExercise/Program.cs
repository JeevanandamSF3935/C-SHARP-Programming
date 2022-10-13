using System;
namespace DoWhileAssignment;
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
            if(temp == false){
                System.Console.WriteLine("Input is wrong, Enter the valid number!");
            }
            else{
                if(number % 2 == 0){
                    System.Console.WriteLine($"The given number {number} is Even");
                }
                else{
                    System.Console.WriteLine($"The given number {number} is Odd");
                }
                System.Console.WriteLine("Do you want to check again? (Yes or No)\nFirst letter should be in Upper Case");
                choice = Console.ReadLine();
            }
        } while (choice != "No");
    }
}