using System;
namespace SixthProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the radius :");
        double radius = double.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Enter the choice:\n1. Area\n2. Perimeter\n3. Diameter");
        int choice = int.Parse(Console.ReadLine());
        
        switch(choice){
            case 1:
            {
                System.Console.WriteLine($"The area is {3.14*radius*radius}");
                break;
            }
            case 2:
            {
                System.Console.WriteLine($"The Perimeter is {2*3.14*radius}");
                break;
            }
            case 3:
            {
                System.Console.WriteLine($"The diameter is {2*radius}");
                break;
            }
            default:
            {
                System.Console.WriteLine("Invalid Choice");
                break;
            }
        }
    }
}