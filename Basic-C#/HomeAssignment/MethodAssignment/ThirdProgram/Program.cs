using System;
namespace ThirdProgram;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first number :");
        int value1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second number : ");
        int value2 = int.Parse(Console.ReadLine());

        //call function
        SwapNumbers(value1,value2);
        
        //swap function
        void SwapNumbers(int value1,int value2){
            int temp = value1;
            value1 = value2;
            value2 = temp;
            System.Console.WriteLine($"Now the 1st number is : {value1}, and the second number is : {value2}");
        }
    }
}