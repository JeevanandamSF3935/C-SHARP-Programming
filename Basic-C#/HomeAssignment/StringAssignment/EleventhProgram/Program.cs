using System;
namespace EleventhProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string :");
        string inputString = Console.ReadLine();
        string outputString = "";
        char[] charsArray = inputString.ToCharArray();
        for(int i = 0;i < charsArray.Length;i++){
            for(int j = i + 1;j < charsArray.Length;j++){
                if(charsArray[i]==charsArray[j]){
                    charsArray[j] = ' ';
                }
                else {
                    continue;
                }
            }
        }
        for(int i = 0;i < charsArray.Length;i++){
            if(charsArray[i] != ' '){
                outputString = outputString + charsArray[i];
            }
            else continue;
        }
        System.Console.WriteLine(outputString);
    }
}