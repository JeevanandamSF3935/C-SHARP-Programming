using System;
namespace FirstProgram;
class Program
{
    public static void Main(string[] args)
    {
        int [] numbersArray = new int[10];
        System.Console.WriteLine("Enter input for 10 Elements in array :");
        for(int i = 0;i < 10;i++){
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0;i < 10;i++){
            System.Console.Write($"{numbersArray[i]} ");
        }
    }
}