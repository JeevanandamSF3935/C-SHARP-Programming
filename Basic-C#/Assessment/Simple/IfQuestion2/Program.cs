using System;
namespace IfQuestion2;
class Program
{
    public static void Main(string[] args)
    {
        int numberToCheck = 0;
        System.Console.WriteLine("Enter the number to be checked :");
        numberToCheck = int.Parse(Console.ReadLine());
        if(numberToCheck < 100 ){
            System.Console.WriteLine("Less than 100");
        }
        else if(numberToCheck >= 100 && numberToCheck <= 200){
            System.Console.WriteLine("Between 100 and 200");
        }
        else{
            System.Console.WriteLine("More than 200");
        }
    }
}