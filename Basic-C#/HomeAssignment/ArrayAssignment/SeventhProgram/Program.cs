using System;
namespace SeventhProgram;

class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        System.Console.WriteLine("Enter the size of N x N matrix");
        count = int.Parse(Console.ReadLine());

        int[,] twoDArray = new int[count,count];
        System.Console.WriteLine("Input elements in the matrix :");
        for(int i = 0;i < count;i++){
            for(int j = 0;j < count;j++){
                twoDArray[i,j] = int.Parse(Console.ReadLine());
            }
        }
        System.Console.WriteLine("The matrix is :");

        for(int i = 0;i < count;i++){
            for(int j = 0;j < count;j++){
                System.Console.Write($"{twoDArray[i,j]} ");
            }
            System.Console.WriteLine();
        }
    }
}