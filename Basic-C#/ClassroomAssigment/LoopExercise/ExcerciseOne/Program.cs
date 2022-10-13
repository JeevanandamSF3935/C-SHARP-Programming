using System;

namespace ExerciseOne;
class Program{
    public static void Main(string[] args)
    {
        for(int i=0;i<25;i=i+2){
            System.Console.WriteLine(i);
        }

        System.Console.WriteLine("Enter the initial number :");
        int initialNumber = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the final number :");
        int finalNumber = int.Parse(Console.ReadLine());
        
        int sum = 0;
        for(int i = initialNumber;i <= finalNumber;i++){
            sum = sum + (i*i);
        }
        System.Console.WriteLine($"Sum of the squares of the numbers between {initialNumber} and {finalNumber} is {sum}");
    }
}