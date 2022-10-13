using System;
namespace ThirdProgram;
class Program
{
    public static void Main(string[] args)
    {
        int number = 0,iterator = 1,fibonacci1 = 0, fibonacci2 = 1,temp = 0;
        System.Console.WriteLine("Enter the number of terms in fibonacci required :");
        number = int.Parse(Console.ReadLine());
        do
        {
            System.Console.Write($"{fibonacci1} ");
            temp = fibonacci1 + fibonacci2;
            fibonacci1 = fibonacci2;
            fibonacci2 = temp;
            iterator++;
        } while (iterator <= number);
    }
}