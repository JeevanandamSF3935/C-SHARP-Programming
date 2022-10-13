using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int lowerLimit = 0, upperLimit = 0, sum = 0,temp = 0,remainder = 0;
        System.Console.WriteLine("Enter the lower limit :");
        lowerLimit = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the upper limit :");
        upperLimit = int.Parse(Console.ReadLine());
        while(lowerLimit <= upperLimit){
            temp = lowerLimit;
            sum = 0;
            while(temp > 0){
                remainder = temp % 10;
                sum = sum + (remainder * remainder * remainder);
                temp = temp / 10;
            }
            if(sum == lowerLimit){
                System.Console.Write($"{lowerLimit},");
            }
            lowerLimit++;
        }
    }
}