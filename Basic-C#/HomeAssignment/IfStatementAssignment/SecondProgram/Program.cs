using System;

namespace SecondProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter your age :");
        int age = int.Parse(Console.ReadLine());
        if(age > 18){
            System.Console.WriteLine("Congratulations!\nYou are eligible for casting your vote");
        }
        else{
            System.Console.WriteLine("Sorry!\nYou are note eligible for casting your vote");
        }
    }
}