using System;
namespace TenthProblem;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number :");
        int value1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the second number :");
        int value2 = int.Parse(Console.ReadLine());

        //first comparision
        if(value1 > value2){
            Console.WriteLine("a. True");
        }
        else{
            Console.WriteLine("a. False");
        }

        //second comparision
        if(value1 < value2){
            Console.WriteLine("b. True");
        }
        else{
            Console.WriteLine("b. False");
        }

        //third comparision
        if(value1 >= value2){
            Console.WriteLine("c. True");
        }
        else{
            Console.WriteLine("c. False");
        }

        //fourth comparision
        if(value1 == value2){
            Console.WriteLine("d. True");
        }
        else{
            Console.WriteLine("d. False");
        }

        //fifth comparision
        if(value1 != value2){
            Console.WriteLine("e. True");
        }
        else{
            Console.WriteLine("e. False");
        }

        //sixth comparision
        if(value1 <= value2){
            Console.WriteLine("f. True");
        }
        else{
            Console.WriteLine("f. False");
        }

        //seventh comparision
        if(value1 >= 10 && value2 >= 10){
            Console.WriteLine("g. True");
        }
        else{
            Console.WriteLine("g. False");
        }

        //eigth comparision
        if(value1 >= 10 || value2 >= 30){
            Console.WriteLine("h. True");
        }
        else{
            Console.WriteLine("h. False");
        }

        //ninth comparision
        if(!(value1 > 10)){
            Console.WriteLine("i. True");
        }
        else{
            Console.WriteLine("i. False");
        }

        //tenth comparision using ternary operator
        String value = value1 == 15 ? "j. True" : "j. False";
        Console.WriteLine($"{value}");

        //increment
        value1++;
        Console.WriteLine($"k. {value1}");

        //decrement
        value1--;
        Console.WriteLine($"l. {value1}");

        Console.ReadKey();
    }
}