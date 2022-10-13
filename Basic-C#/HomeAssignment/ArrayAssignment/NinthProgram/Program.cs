using System;
namespace NinthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int rowOfFirstArray = 0,columnOfFirstArrray = 0,rowOfSecondArray = 0, columnOfSecondArrray = 0;
        System.Console.WriteLine("Input the row of first matrix :");
        rowOfFirstArray = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the column of first matrix :");
        columnOfFirstArrray = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the row of second matrix :");
        rowOfSecondArray = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the column of second matrix :");
        columnOfSecondArrray = int.Parse(Console.ReadLine());


        int[,] firstArray = new int[rowOfFirstArray,columnOfFirstArrray];
        int[,] secondArray = new int[rowOfSecondArray,columnOfSecondArrray];
        int[,] multiplyArray = new int[rowOfFirstArray,columnOfSecondArrray];

        System.Console.WriteLine("Input the element of first matrix :");
        for(int i = 0;i < rowOfFirstArray;i++){
            for(int j = 0;j < columnOfFirstArrray;j++){
                firstArray[i,j] = int.Parse(Console.ReadLine());
            }
        }

        System.Console.WriteLine("Input the element of second matrix :");
        for(int i = 0;i < rowOfSecondArray;i++){
            for(int j = 0;j < columnOfSecondArrray;j++){
                secondArray[i,j] = int.Parse(Console.ReadLine());
            }
        }

        for(int i = 0;i < rowOfFirstArray;i++){
            for(int j = 0;j < columnOfFirstArrray;j++){
                multiplyArray[i,j] = 0;
                for(int k=0;k < columnOfSecondArrray;k++){
                    multiplyArray[i,j]+=firstArray[i,k]*secondArray[k,j];
                }
            }
        }

        System.Console.WriteLine("The multiplication of two matrices :");
        for(int i = 0;i < rowOfFirstArray;i++){
            for(int j = 0;j < columnOfSecondArrray;j++){
                System.Console.Write($"{multiplyArray[i,j]} ");
            }
            System.Console.WriteLine();
        }
    }
}