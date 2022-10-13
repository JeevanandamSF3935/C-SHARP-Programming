using System;
namespace TwelvethProgram;
class Program{
    public static void Main(string[] args)
    {
        int maxNumber = 0, minNumber = 0;
        System.Console.WriteLine("Enter the original string of numbers seperated by single space");
        string inputString = Console.ReadLine();
        
        string[] stringsArray = inputString.Split(' ');
        int[] numbersArray = new int[stringsArray.Length];
          
        for(int i = 0;i < stringsArray.Length;i++){
            numbersArray[i] = int.Parse(stringsArray[i]);
        }
        
        maxNumber = numbersArray[0];
        minNumber = numbersArray[0];

        for(int i = 1;i < numbersArray.Length;i++){
            if(minNumber > numbersArray[i]){
                minNumber = numbersArray[i];
            }
            if(maxNumber < numbersArray[i]){
                maxNumber = numbersArray[i];
            }
        }
        System.Console.WriteLine($"Minimum number : {minNumber}\nMaximum number : {maxNumber}");
    }
}