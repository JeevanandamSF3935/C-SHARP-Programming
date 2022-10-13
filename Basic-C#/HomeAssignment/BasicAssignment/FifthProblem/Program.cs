using System;
namespace FifthProblem;

class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the physics mark");
        int physicsMark = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the chemistry mark");
        int chemistryMark = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the maths mark");
        int mathsMark = int.Parse(Console.ReadLine());

        int sum = (physicsMark+chemistryMark+mathsMark);

        double percentage = (double)sum/3;
        percentage = Math.Round(percentage,2);

        Console.WriteLine($"Sum = {sum}\nPercentage = {percentage}%");
        Console.ReadKey();
    }
}