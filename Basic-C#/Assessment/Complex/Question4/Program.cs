using System;
namespace Question4;
public class MyClass
{
    public static void Main(string[] args)
    {
        string inputString = "";
        System.Console.WriteLine("Enter the string :");
        inputString = Console.ReadLine();
        
        char[] stringToChar = inputString.ToCharArray();
        int lengthOfCharArray = stringToChar.Length;
        for(int i = 0;i < lengthOfCharArray; i++){
            for(int j = i + 1; j < lengthOfCharArray; j++){
                if(stringToChar[i] == stringToChar[j]){
                    for(int k = j ; k < stringToChar.Length-1; k++){
                        stringToChar[k] = stringToChar[k+1];
                    }
                    lengthOfCharArray--;
                }
            }
        }
        System.Console.WriteLine(lengthOfCharArray);
        for(int i = 0; i < lengthOfCharArray; i++){
            System.Console.Write(stringToChar[i]);
        }
    }
}