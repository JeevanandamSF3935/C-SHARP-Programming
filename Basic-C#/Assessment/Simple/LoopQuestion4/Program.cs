using System;
namespace LoopQuestion4;
class Program
{
    public static void Main(string[] args)
    {
        int number = 0;
        System.Console.WriteLine("Enter the number :");
        number = int.Parse(Console.ReadLine());
        System.Console.WriteLine("The output be like :");
        for(int i = 1;i <= number;i++){
            for(int j = 1;j <= i;j++){
                System.Console.Write(i);
            }
            System.Console.WriteLine();
        }
    }
}