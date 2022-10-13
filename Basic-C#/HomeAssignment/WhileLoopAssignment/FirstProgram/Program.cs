using System;
namespace FirstProgram;
class Program{
    public static void Main(string[] args)
    {
        int number = 1;
        while(number <= 10){
            System.Console.Write($"{number} ");
            number++;
        }
    }
}