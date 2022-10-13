using System;
namespace LoopQueation2;
class Program
{
    public static void Main(string[] args)
    {
        int sumOfSquaresOfOdd = 0;
        for(int iterator = 1;iterator < 100;iterator++){
            if(iterator % 2 != 0){
                sumOfSquaresOfOdd = sumOfSquaresOfOdd + (iterator * iterator);
            }
        }
        System.Console.WriteLine($"Sum of the square of Odd numbers between 1-99 is {sumOfSquaresOfOdd}");
    }
}