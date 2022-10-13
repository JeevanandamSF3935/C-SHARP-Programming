using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        int startingNumber = 0, numOfElements = 0, difference = 0, sum = 0;
        System.Console.Write("Enter the starting element :");
        startingNumber = int.Parse(Console.ReadLine());
        
        System.Console.Write("\nEnter the no of elements to be printed :");
        numOfElements = int.Parse(Console.ReadLine());
        
        System.Console.Write("\nEnter the difference :");
        difference = int.Parse(Console.ReadLine());

        System.Console.Write("Output series : ");
        for(int i = 0;i < numOfElements;i++){
            System.Console.Write($"{startingNumber} ");
            sum = sum + startingNumber;
            startingNumber = startingNumber + difference;
        }
        System.Console.WriteLine($"\nSum of the series is : {sum}");
    }
}