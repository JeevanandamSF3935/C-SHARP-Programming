using System;
namespace FifthProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the choice as listed: (India,Pakistan,Bangladesh)");
        string choice = Console.ReadLine();
        
        switch(choice){
            case "India":
            {
                System.Console.WriteLine("1. Gambir\n2. Ashwin\n3. Dhoni\n4. Jadeja");
                break;
            }
            case "Pakistan":
            {
                System.Console.WriteLine("1. Babar Azam\n2. Afridi\n3. Asif ali\n4. Mohammad Hafeez");
                break;
            }
            case "Bangladesh":
            {
                System.Console.WriteLine("1. Shakib Al Hasan\n2. Mahmudullah\n3. Sabbir Rahman\n4. Mustafizur Rahman");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}