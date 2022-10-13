using System;
namespace EigthProgram;
class Program{
    public static void Main(string[] args)
    {
        int count = 1;
        for(int i=0;i<4;i++){
            for(int j=4-i;j>1;j--){
                System.Console.Write(" ");
            }
            for(int j=0;j<=i;j++){
                System.Console.Write($"{count} ");
                count++;
            }
            System.Console.WriteLine();
        }
    }
}