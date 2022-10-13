using System;
namespace ThirdProgram;
class Program{
    public static void Main(string[] args)
    {
        int count = 0, sum = 0;
        System.Console.WriteLine("Enter the number of elements to be entered in array :");
        count = int.Parse(Console.ReadLine());

        int[] numbersArray = new int[count];
        System.Console.WriteLine($"Input {count} elements in array :");
        for(int i = 0;i < count;i++){
            numbersArray[i] = int.Parse(Console.ReadLine());
            sum = sum + numbersArray[i];
        }
        System.Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
    }
}