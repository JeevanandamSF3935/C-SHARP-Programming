using System;
namespace FifthProgram;

class Program
{
    public static void Main(string[] args)
    {
        int count = 0, evenCount = 0, oddCount = 0, evenIterator = 0, oddIterator = 0;
        System.Console.WriteLine("Input the number of elements to be stored in the array :");
        count = int.Parse(Console.ReadLine());

        int[] numbersArray = new int[count];
        int[] evenNumbersArray = new int[count];
        int[] oddNumbersArray = new int[count];
        System.Console.WriteLine($"Input {count} elements in the array :");
        for(int i = 0;i < count;i++){
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < count; i++)
        {
            if(numbersArray[i] % 2 == 0){
                evenNumbersArray[evenIterator] = numbersArray[i];
                evenIterator++;
                evenCount++;
            }
            else{
                oddNumbersArray[oddIterator] = numbersArray[i];
                oddIterator++;
                oddCount++;
            }
        }

        System.Console.WriteLine("The Even numbers are :");
        for (int i = 0; i < evenCount; i++){
            System.Console.Write($"{evenNumbersArray[i]} ");
        }
        System.Console.WriteLine("\nThe Odd numbers are :");
        for (int i = 0; i < oddCount; i++)
        {
            System.Console.Write($"{oddNumbersArray[i]} ");
        }
    }
}