using System;
namespace FirstProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your choice-(E,V,G,A,F)");
        char choice = char.Parse(Console.ReadLine());

        switch(choice){
            case 'E':
            {
                System.Console.WriteLine("Excellent");
                break;
            }
            case 'V':
            {
                System.Console.WriteLine("Very Good");
                break;
            }
            case 'G':
            {
                System.Console.WriteLine("Good");
                break;
            }
            case 'B':
            {
                System.Console.WriteLine("Bad");
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