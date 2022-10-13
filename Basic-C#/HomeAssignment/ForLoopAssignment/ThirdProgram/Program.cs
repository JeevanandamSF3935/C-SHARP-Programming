using System;
namespace ThirdProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number of cube values to be printed :");
        int number = int.Parse(Console.ReadLine());

        for(int i = 1; i <= number;i++){
            System.Console.WriteLine($"Number : {i} and cube of the {i} is :{i*i*i}");
        }
    }
}