using System;
namespace EigthProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the sugar level :");
        int sugarLevel = int.Parse(Console.ReadLine());

        if(sugarLevel < 90){
            System.Console.WriteLine("Low sugar");
        }
        else if(sugarLevel >= 90 && sugarLevel < 130){
            System.Console.WriteLine("Normal");
        }
        else if(sugarLevel >= 130 && sugarLevel < 140){
            System.Console.WriteLine("Medium");
        }
        else if(sugarLevel >= 140 && sugarLevel <= 170){
            System.Console.WriteLine("High sugar");
        }
        else if(sugarLevel > 170){
            System.Console.WriteLine("You are very high sugar patient");
        }
    }
}