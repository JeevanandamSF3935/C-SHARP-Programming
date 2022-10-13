using System;
namespace SecondProgram;

class Program{
    public static void Main(string[] args)
    {
        double number, sum = 0;
        for(int i=1;i<=10;i++){
            number = double.Parse(Console.ReadLine());
            sum = sum + number;
        }
        System.Console.WriteLine($"Sum = {sum}\nAverage = {sum/10}");
    }
}