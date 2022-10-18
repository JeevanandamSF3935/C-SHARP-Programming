using System;
namespace Assignment2;
class Program
{
    public static void Main(string[] args)
    {
        int[] array = new int[10];
        System.Console.WriteLine("Enter the 10 numbers :");
        for(int iterator = 0; iterator < 10; iterator++){
            array[iterator] = int.Parse(Console.ReadLine());
        }
        
        System.Console.WriteLine("Even numbers of array in ascending order :");
        int[] evenArray = Ascending(array);
        for(int iterator = 0; iterator < 10; iterator++){
            if(evenArray[iterator] % 2 == 0){
                System.Console.Write($"{evenArray[iterator]} ");
            }
        }
        
        System.Console.WriteLine("\nOdd numbers of array in descending order :");
        int[] oddArray = Descending(array);
        for(int iterator = 0; iterator < 10; iterator++){
            if(oddArray[iterator] % 2 != 0){
                System.Console.Write($"{oddArray[iterator]} ");
            }
        }
    }

    public static int[] Ascending(int[] array){
        int temp = 0;
        for(int iterator = 0; iterator < array.Length; iterator++){
            for(int iterator1 = iterator; iterator1 < array.Length; iterator1++){
                if(array[iterator] > array[iterator1]){
                    temp = array[iterator];
                    array[iterator] = array[iterator1];
                    array[iterator1] = temp;
                }
            }
        }
        return array;
    }

    public static int[] Descending(int[] array){
        int temp = 0;
        for(int iterator = 0; iterator < array.Length; iterator++){
            for(int iterator1 = iterator; iterator1 < array.Length; iterator1++){
                if(array[iterator] < array[iterator1]){
                    temp = array[iterator];
                    array[iterator] = array[iterator1];
                    array[iterator1] = temp;
                }
            }
        }
        return array;
    }
}