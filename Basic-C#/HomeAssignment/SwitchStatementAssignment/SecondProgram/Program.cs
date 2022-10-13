using System;
namespace SecondProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the day number (from 1-7) :");
        int choice = int.Parse(Console.ReadLine());

        switch(choice){
            case 1:
            {
                System.Console.WriteLine("Monday");
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Tuesday");
                break;
            }
            case 3:
            {
                System.Console.WriteLine("Wednesday");
                break;
            }
            case 4:
            {
                System.Console.WriteLine("Thursday");
                break;
            }
            case 5:
            {
                System.Console.WriteLine("Friday");
                break;
            }
            case 6:
            {
                System.Console.WriteLine("Saturday");
                break;
            }
            case 7:
            {
                System.Console.WriteLine("Sunday");
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
