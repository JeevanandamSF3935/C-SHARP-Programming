using System;
namespace SeventhProgram;
class Program{
    public static void Main(string[] args)
    {
        for(int i=0;i<4;i++){
            for(int j=4-i;j>1;j--){
                System.Console.Write(" ");
            }
            for(int j=0;j <= i;j++){
                System.Console.Write("* ");
            }
            System.Console.Write("\n");
        }
    }
}