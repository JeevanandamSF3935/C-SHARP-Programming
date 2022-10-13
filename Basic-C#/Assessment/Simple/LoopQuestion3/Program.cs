using System;
namespace LoopQuestion3;
class Program
{
    public static void Main(string[] args)
    {
        int number = 0;
        System.Console.WriteLine("Enter the number for multiple table required :");
        number = int.Parse(Console.ReadLine());
        for(int i = 1;i <= 20;i++){
            System.Console.WriteLine($"{number} x {i} = {number*i}");
        }
    }
}