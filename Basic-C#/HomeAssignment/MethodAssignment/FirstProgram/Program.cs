using System;
namespace FirstProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input1 :");
        int value1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Input2 :");
        int value2 = int.Parse(Console.ReadLine());

        //function call
        Addition(value1,value2);
        Subtraction(value1,value2);
        Multiplication(value1,value2);
        Division(value1,value2);

        //Addition function
        void Addition(int value1,int value2){
            int addedValue = value1 + value2;
            System.Console.WriteLine($"Addition : {addedValue}");
        }

        //Subtraction function
        void Subtraction(int value1,int value2){
            int subtractedValue = value1 - value2;
            System.Console.WriteLine($"Subtraction : {subtractedValue}");
        }

        //Multiplication function
        void Multiplication(int value1,int value2){
            int multipliedValue = value1 * value2;
            System.Console.WriteLine($"Multiplication : {multipliedValue}");
        }

        //Division function
        void Division(int value1,int value2){
            double dividedValue = (double)value1 / value2;
            System.Console.WriteLine($"Division : {dividedValue}");
        }
    }
}