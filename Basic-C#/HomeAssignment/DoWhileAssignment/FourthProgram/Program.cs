using System;
namespace FourthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int number = 0, flag = 0;
        System.Console.WriteLine("Enter the number (Range is 1-10) :");
        do{
            bool temp = int.TryParse(Console.ReadLine(),out number);
            if(temp == true){
                if(number <= 10 && number >=1){
                    System.Console.WriteLine($"{number} is a valid number");
                    flag = 1;
                }
                else{
                    System.Console.WriteLine($"{number} is not in range, enter again (Range is 1-10)");
                }
            }
            else{
                System.Console.WriteLine("Invalid input, enter again in a number format!(Range is 1-10)");
            }
        }while(flag==0);
    }
}