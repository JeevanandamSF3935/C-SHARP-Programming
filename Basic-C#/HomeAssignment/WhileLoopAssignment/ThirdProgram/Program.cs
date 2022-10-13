using System;
namespace ThirdProgram;

class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms to be printed :");
        int count = int.Parse(Console.ReadLine());

        int iterator=0, fibonacci1 = 0,fibonacci2 = 1,temp = 0;
        while (iterator < count)
        {
            System.Console.Write($"{fibonacci1} ");
            temp = fibonacci1 + fibonacci2;
            fibonacci1 = fibonacci2;
            fibonacci2 = temp;
            iterator++;
        }
    }
}