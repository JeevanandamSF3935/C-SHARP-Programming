using System;
namespace NinthProgram;
class Program{
    public static void Main(string[] args)
    {
        int sum = 0;
        System.Console.WriteLine("Enter the number :");
        int number = int.Parse(Console.ReadLine());
        for(int i=number; i > 0; i=i/10){
            int rem = i % 10;
            sum = sum + (rem*rem*rem);
        }
        if(number == sum){
            System.Console.WriteLine($"{number} is an Armstrong number.");
        }
        else{
            System.Console.WriteLine($"{number} is not an Armstrong number.");
        }
    }
}