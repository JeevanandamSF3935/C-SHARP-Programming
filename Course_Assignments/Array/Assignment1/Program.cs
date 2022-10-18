using System;
namespace Assignment1;
class Program
{
    public static void Main(string[] args)
    {
        int temp = 0;
        int[] array = new int[5];
        System.Console.WriteLine("Enter 5 numbers :");
        for(int iterator = 0; iterator < 5; iterator++){
            array[iterator] = int.Parse(Console.ReadLine());
        }
        for(int iterator = 0; iterator < 5; iterator++){
            for(int iterator1 = iterator; iterator1 < 5; iterator1++){
                if(array[iterator] > array[iterator1]){
                    temp = array[iterator];
                    array[iterator] = array[iterator1];
                    array[iterator1] = temp;
                }
            }
        }
        System.Console.WriteLine("Sorted array is :");
        for(int iterator = 0; iterator < 5; iterator++){
            System.Console.Write($"{array[iterator]} ");
        }
    }
}