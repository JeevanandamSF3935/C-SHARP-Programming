using System;

namespace WriteRead;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the name");
        String name = Console.ReadLine();
        Console.WriteLine("Enter the age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Using Conactenation:");
        Console.WriteLine("Name is : " + name + " and your age is " + age);
        Console.WriteLine("Using PlaceHolder");
        Console.WriteLine("Name is {0} and your age is {1}",name,age);
        Console.WriteLine("Using Interpolation");
        Console.WriteLine($"Name is : {name} and your age is {age}");
    }
}