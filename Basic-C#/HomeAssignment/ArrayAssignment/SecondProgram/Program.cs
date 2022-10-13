using System;
namespace SecondProgram;

class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        System.Console.WriteLine("Input the number of elements to store in the array :");
        count = int.Parse(Console.ReadLine());

        int[] numbersArray = new int[count];
        System.Console.WriteLine($"Input {count} numbers of elements in the array :");
        for(int i = 0;i < count;i++){
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        System.Console.WriteLine("The value stored in the array :");
        for(int i = 0;i < count;i++){
            System.Console.Write($"{numbersArray[i]} ");
        }
        System.Console.WriteLine("\nThe value stored in the array in reverse are :");
        for(int i = count - 1;i >= 0;i--){
            System.Console.Write($"{numbersArray[i]} ");
        }
    }
}