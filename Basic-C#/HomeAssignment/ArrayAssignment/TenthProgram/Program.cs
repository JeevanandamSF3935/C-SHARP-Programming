using System;
namespace TenthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int rowSize = 0, columnSize = 0;
        System.Console.WriteLine("Input the row size of matrix :");
        rowSize = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Input the column size of matrix :");
        columnSize = int.Parse(Console.ReadLine());

        int[,] numbersArray = new int[rowSize,columnSize];
        int[,] transposedArray = new int[columnSize,rowSize];

        System.Console.WriteLine("Input the elements of matrix :");
        for(int i = 0;i < rowSize;i++){
            for(int j = 0;j < columnSize;j++){
                numbersArray[i,j] = int.Parse(Console.ReadLine());
            }
        }

        for(int i = 0;i < rowSize;i++){
            for(int j = 0;j < columnSize;j++){
                transposedArray[j,i] = numbersArray[i,j];
            }
        }

        for(int i = 0;i < columnSize;i++){
            for(int j = 0;j < rowSize;j++){
                System.Console.Write($"{transposedArray[i,j]} ");
            }
            System.Console.WriteLine();
        }

    }
}