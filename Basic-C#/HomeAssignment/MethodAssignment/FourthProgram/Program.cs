using System;
namespace FourthProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input number for fibonacci series count :");
        int count = int.Parse(Console.ReadLine());

        //function call
        Fibonacci(count);

        //Fibonacci series
        void Fibonacci(int count){
            int fibonacci1 = 0, fibonacci2 = 1,temp = 0;
            System.Console.WriteLine($"The fibonacci series of {count} numbers is : ");
            for(int i = 0;i < count;i++){
                System.Console.Write($"{fibonacci1} ");
                temp = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = temp;
            }
        }
    }
}