using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int rowOfFirstArray = 0, rowOfSecondArray = 0, columnOfFirstArray = 0, columnOfSecondArray = 0;
        System.Console.Write("Enter the row of first array : ");
        rowOfFirstArray = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the column of first array : ");
        columnOfFirstArray = int.Parse(Console.ReadLine());

        System.Console.Write("Enter the row of second array : ");
        rowOfSecondArray = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the column of second array : ");
        columnOfSecondArray = int.Parse(Console.ReadLine());

        int[,] firstArray = new int[rowOfFirstArray,columnOfFirstArray];
        int[,] secondArray = new int[rowOfSecondArray,columnOfSecondArray];
        int[,] multipliedArray = new int[rowOfFirstArray,columnOfSecondArray];

        if(columnOfFirstArray == rowOfSecondArray){

            System.Console.WriteLine("Enter the elements of first matrix :");
            for(int i = 0; i < rowOfFirstArray; i++){
                for(int j = 0;j < columnOfFirstArray; j++){
                    firstArray[i,j] = int.Parse(Console.ReadLine());
                }
            }

            System.Console.WriteLine("Enter the elements of second matrix :");
            for(int i = 0; i < rowOfSecondArray; i++){
                for(int j = 0;j < columnOfSecondArray; j++){
                    secondArray[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i = 0;i < rowOfFirstArray; i++){
                for(int j = 0;j < columnOfFirstArray; j++){
                    multipliedArray[i,j] = 0;
                    for(int k = 0;k < columnOfSecondArray; k++){
                        multipliedArray[i,j] += firstArray[i,k] * secondArray[k,j];
                    }
                }
            }

            System.Console.WriteLine("The multiplied matrix :");
            for(int i = 0; i < rowOfFirstArray; i++){
                for(int j = 0;j < columnOfSecondArray; j++){
                    System.Console.Write($"{multipliedArray[i,j]} ");
                }
                System.Console.WriteLine();
            }
        }
        else{
            System.Console.WriteLine("\nMatrix multiplication is not possible for these two matrices");
        }
    }
}