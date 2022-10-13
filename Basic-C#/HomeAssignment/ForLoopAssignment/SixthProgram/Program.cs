using System;
namespace SixthProgram;
class Program{
    public static void Main(string[] args)
    {
        for(int i=0;i<5;i++){
            for(int j=0;j<=i;j++){
                System.Console.Write("* ");
            }
            System.Console.Write("\n");
        }
    }
}