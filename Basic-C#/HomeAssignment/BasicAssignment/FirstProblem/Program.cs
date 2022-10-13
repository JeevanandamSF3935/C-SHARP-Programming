using System;
namespace FirstProblem;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name :");
        String name = Console.ReadLine();
        Console.WriteLine("Hello: {0}",name);
        Console.WriteLine("Hello: "+name);
        Console.WriteLine($"Hello: {name}");
        Console.ReadKey();
    }
}