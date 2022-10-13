using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        int checker = 0;
        string nameOne = "", nameTwo = "";
        System.Console.Write("Enter the name one : ");
        nameOne = Console.ReadLine();
        System.Console.Write("Enter the name two : ");
        nameTwo = Console.ReadLine();
        
        char[] charOfNameOne = nameOne.ToCharArray();
        char[] charOfNameTwo = nameTwo.ToCharArray();

        if(charOfNameOne.Length == charOfNameTwo.Length){
            for(int i = 0;i < charOfNameOne.Length; i++){
                for(int j = 0; j<charOfNameOne.Length; j++){
                    if(charOfNameOne[i] == charOfNameTwo[j]){
                        charOfNameTwo[j] = ' ';
                        checker = 1;
                        break;
                    }
                    else{
                        checker = 0;
                    }
                }
            }
            if(checker == 1){
                System.Console.WriteLine("Name one and two are anagrams");
            }
            else{
                System.Console.WriteLine("Name one and two are not anagrams");
            }
        }
        else{
            System.Console.WriteLine("Name one and two are not a anagrams");
        }
    }
}