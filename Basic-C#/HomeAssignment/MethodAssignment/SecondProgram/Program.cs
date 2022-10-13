using System;
namespace SecondProgram;

class Program
{
    public static void Main(string[] args)
    {
        DisplayMessage();
        GreetingMessage();

        void DisplayMessage(){
            System.Console.WriteLine("Welcome Friens!");
        }

        void GreetingMessage(){
            System.Console.WriteLine("Have a nice day!");
        }
    }
}