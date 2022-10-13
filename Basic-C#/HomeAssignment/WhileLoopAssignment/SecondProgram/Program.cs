using System;
namespace SecondProgram;

class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the count :");
        int count = int.Parse(Console.ReadLine());
        int iterator = 1,sumOfSquares = 0;
        while(iterator <= count){
            sumOfSquares = sumOfSquares + (iterator*iterator);
            iterator++;
        }
        System.Console.WriteLine($"Output : {sumOfSquares}");
    }
}