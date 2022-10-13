using System;
namespace FourthProgram;

class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number to be validated :");
        int inputNumber = 1;
        bool temp = false;
        while(temp == false){
            temp = int.TryParse(Console.ReadLine(),out inputNumber);
            if(temp == false){
                System.Console.WriteLine("Invalid input enter again1");
            }
            else{
                if(inputNumber <= 5 && inputNumber >=1){
                    System.Console.WriteLine("Valid Input");
                }
                else{
                    System.Console.WriteLine("Invalid input enter again");
                    temp = false;
                }
            }
        }
    }
}