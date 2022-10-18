using System;
namespace While;
class Program
{
    public static void Main(string[] args)
    {
        char continueChoice = 'Y';
        while(continueChoice == 'Y'){
            System.Console.WriteLine("Which city is capital of India?\n1.Chennai\n2.Delhi\n3.Mumbai\n4.Kolkata");
            System.Console.Write("Enter the choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    System.Console.WriteLine("Incorrect!");
                    break;
                }
                case 2:{
                    System.Console.WriteLine("Correct!");
                    break;
                }
                case 3:{
                    System.Console.WriteLine("Incorrect!");
                    break;
                }
                case 4:{
                    System.Console.WriteLine("Incorrect!");
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice");
                    break;
                }
            }
            System.Console.WriteLine("Press Y to continue or N to close..");
            continueChoice = char.Parse(Console.ReadLine().ToUpper());
        }
    }
}