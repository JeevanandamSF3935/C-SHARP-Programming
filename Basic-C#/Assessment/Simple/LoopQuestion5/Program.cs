using System;
namespace LoopQuestion5;
class Program
{
    public static void Main(string[] args)
    {
        int inputNumber = 0,checker = 1,dividingCount = 0;
        System.Console.WriteLine("Enter the number :");
        inputNumber = int.Parse(Console.ReadLine());
        while(checker <= inputNumber){
            if(inputNumber % checker == 0){
                dividingCount++;
            }
            else{
                checker++;
                continue;
            }
            checker++;
        }
        if(dividingCount <= 2){
            System.Console.WriteLine($"{inputNumber} is a prime number");
        }
        else{
            System.Console.WriteLine($"{inputNumber} is not a prime number");
        }
    }
}