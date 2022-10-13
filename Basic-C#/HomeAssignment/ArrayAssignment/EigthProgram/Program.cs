using System;
namespace EigthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int arraySize = 0, sum = 0;
        System.Console.WriteLine("Input the size of the square matrix (Less than 5) :");
        arraySize = int.Parse(Console.ReadLine());

        int[,] firstArray = new int[arraySize,arraySize];
        int[,] secondArray = new int[arraySize,arraySize];
        int[,] sumArray = new int[arraySize,arraySize];

        System.Console.WriteLine("Input element for the first matrix :");
        for(int i = 0;i < arraySize;i++){
            for(int j = 0; j < arraySize;j++){
                firstArray[i,j] = int.Parse(Console.ReadLine());
            }
        }

        System.Console.WriteLine("Input element for the second matrix :");
        for(int i = 0;i < arraySize;i++){
            for(int j = 0; j < arraySize;j++){
                secondArray[i,j] = int.Parse(Console.ReadLine());
            }
        }

        System.Console.WriteLine("Addition of two matrices :");
        for(int i = 0;i < arraySize;i++){
            for(int j = 0; j < arraySize;j++){
                sumArray[i,j] = firstArray[i,j] + secondArray[i,j];
                sum = firstArray[i,j] + secondArray[i,j];
                System.Console.Write($"{sum} ");
            }
            System.Console.WriteLine();
        }
    }
}