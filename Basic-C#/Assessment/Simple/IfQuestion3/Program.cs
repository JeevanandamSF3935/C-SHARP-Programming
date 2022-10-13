using System;
namespace IfQuestion3;
class Program
{
    public static void Main(string[] args)
    {
        double speed = 0;
        System.Console.WriteLine("Enter the speed :");
        bool checkFormate = double.TryParse(Console.ReadLine(),out speed);

        if(speed >0 && speed <= 10){
            System.Console.WriteLine("Slow");
        }
        else if(speed > 10 && speed <= 50){
            System.Console.WriteLine("Average");
        }
        else if(speed > 50 && speed <= 150){
            System.Console.WriteLine("Fast");
        }
        else if(speed > 150 && speed <= 1000){
            System.Console.WriteLine("Ultra fast");
        }
        else if(speed > 1000){
            System.Console.WriteLine("Extremely fast");
        }
        else{
            System.Console.WriteLine("Invalid input");
        }
    }
}