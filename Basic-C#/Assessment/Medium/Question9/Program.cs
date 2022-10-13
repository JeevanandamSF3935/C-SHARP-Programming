using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        System.Console.WriteLine("Enter the number to form a pyramid layer :");
        count = int.Parse(Console.ReadLine());
        System.Console.WriteLine("The pyramid is :");
        for(int i = 0;i < count;i++){
            for(int j = count-i;j > 0;j--){
                System.Console.Write(" ");
            }
            for(int j = 0;j <=i;j++){
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }
    }
}