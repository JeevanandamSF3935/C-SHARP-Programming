using System;
namespace TenthProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number :");
        int count = 0;
        int number = int.Parse(Console.ReadLine());
        for(int i=1;i<=number;i++){
            if(number % i == 0){
                count++;
            }
        }
        if(count <= 2){
            System.Console.WriteLine($"{number} is a prime number");
        }
        else{
            System.Console.WriteLine($"{number} is not a prime number");
        }
    }
}