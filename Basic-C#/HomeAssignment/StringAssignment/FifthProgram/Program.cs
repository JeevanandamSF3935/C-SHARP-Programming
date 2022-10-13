using System;
namespace FifthProgram;

class Program
{
    public static void Main(string[] args)
    {
        int firstStringCount = 0, secondStringCount = 0, checker = 0;
        string firstString = "",secondString = "";
        System.Console.WriteLine("Enter the 1st string :");
        firstString = Console.ReadLine();
        System.Console.WriteLine("Enter the 2nd string :");
        secondString = Console.ReadLine();
        string[] firstSeperated = firstString.Split(' ',',');
        string[] secondSeperated = secondString.Split(' ',',');
        foreach (string seperatedString in firstSeperated)
        {
            firstStringCount++;
        }
        foreach (string seperatedString in secondSeperated)
        {
            secondStringCount++;
        }
        System.Console.WriteLine(secondSeperated[0]);
        if(firstStringCount == secondStringCount){
            System.Console.Write("The length of both strings are equal");
            for(int i = 0;i < firstStringCount;i++){
                char[] firstStringChecker = firstSeperated[i].ToCharArray();
                char[] secondStringChecker = secondSeperated[i].ToCharArray();
                for(int j = 0;j < firstStringChecker.Length && j < secondStringChecker.Length;j++){
                    if(firstStringChecker[j] == secondStringChecker[j]){
                    checker = 1;
                }
                else{
                    checker = 0;
                }
                }
            }
            if(checker == 1){
                System.Console.WriteLine(" and also, both strings are equal");
            }
            else{
                System.Console.WriteLine(" and strings are not equal");
            }
        }
        else{
            System.Console.WriteLine("The length of both strings are not equal");
        }
    }
}