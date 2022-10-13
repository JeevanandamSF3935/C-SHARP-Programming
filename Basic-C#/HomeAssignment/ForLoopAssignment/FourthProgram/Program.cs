using System;
namespace FourthProgram;

class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number required for multiplication table :");
        int number = int.Parse(Console.ReadLine());
        for(int i=1;i<=10;i++){
            System.Console.WriteLine($"{number} x {i} = {number*i}");
        }
    }
}