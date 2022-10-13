using System;
namespace SixthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0, temp = 0;
        System.Console.WriteLine("Input the size of array :");
        count = int.Parse(Console.ReadLine());

        int[] numbersArray = new int[count];
        System.Console.WriteLine($"Input {count} elements in the array :");
        for(int i = 0; i < count;i++){
            numbersArray[i] = int.Parse(Console.ReadLine());
        }
        for(int i = 0;i < count;i++){
            for(int j = i+1;j < count;j++){
                if(numbersArray[i] > numbersArray[j]){
                    temp = numbersArray[i];
                    numbersArray[i] = numbersArray[j];
                    numbersArray[j] = temp;
                }
            }
        }
        System.Console.WriteLine("Elements of array in sorted ascending order :");
        for (int i = 0; i < count; i++){
            System.Console.Write($"{numbersArray[i]} ");
        }
    }
}