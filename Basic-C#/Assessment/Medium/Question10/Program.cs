using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        int length = 0, breadth = 0;
        System.Console.WriteLine("Input the length of the rectangle :");
        length = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input the breadth of the rectangle :");
        breadth = int.Parse(Console.ReadLine());
        for(int i = 0; i < breadth; i++){
            for(int j = 0;j < length; j++){
                if(i == 0 || i == breadth-1){
                    System.Console.Write("* ");
                }
                else{
                    if(j == 0 || j == length-1){
                        System.Console.Write("* ");
                    }
                    else{
                        System.Console.Write("  ");
                    }
                }
            }
            System.Console.WriteLine();
        }
    }
}