using System;
namespace Question6;
class Program{
    public static void Main(string[] args)
    {
        int[,] firstArray = new int[3,3];
        int[,] secondArray = new int[3,3];
        int[,] sumArray = new int[3,3];

        System.Console.WriteLine("Enter the elements of first array :");
        for(int i = 0;i < 3; i++){
            for(int j = 0;j < 3;j++){
                firstArray[i,j] = int.Parse(Console.ReadLine());
            }
        }

        System.Console.WriteLine("Enter the elements of second array :");
        for(int i = 0;i < 3; i++){
            for(int j = 0;j < 3;j++){
                secondArray[i,j] = int.Parse(Console.ReadLine());
            }
        }

        for(int i = 0;i < 3; i++){
            for(int j = 0;j < 3;j++){
                sumArray[i,j] = firstArray[i,j] + secondArray[i,j];
            }
        }

        System.Console.WriteLine("Sum of the two arrays :");
        for(int i = 0;i < 3; i++){
            for(int j = 0;j < 3;j++){
                System.Console.Write($"{sumArray[i,j]} ");
            }
            System.Console.WriteLine();
        }
    }
}