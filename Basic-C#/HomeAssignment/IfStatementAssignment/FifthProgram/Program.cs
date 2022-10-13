using System;

namespace FifthProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the physics mark :");
        int physicsMark = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the chemistry mark :");
        int chemistryMark = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the maths mark :");
        int mathsMark = int.Parse(Console.ReadLine());

        double percentage = (double)(physicsMark+chemistryMark+mathsMark)/3;

        if(percentage >= 75){
            System.Console.WriteLine("The candidate is eligible for admission");
        }
        else{
            System.Console.WriteLine("The candidate is not eligible for admission");
        }
    }
}