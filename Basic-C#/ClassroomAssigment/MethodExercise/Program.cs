using System;
namespace MethodAssignment;

class Program
{
    public static void Main(string[] args)
    {
        int choice = 0;
        do{
            System.Console.WriteLine("Enter the choice :\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
            choice = int.Parse(Console.ReadLine());

            switch(choice){
                case 1:
                {
                    int[] inputs = GetValue(); 
                    int result = Addition(inputs[0],inputs[1]);
                    System.Console.WriteLine($"Addition of two numbers is : {result}");
                    break;
                }
                case 2:
                {
                    int[] inputs = GetValue();
                    int result = Subtraction(inputs[0],inputs[1]);
                    System.Console.WriteLine($"Subtraction of two numbers is : {result}");
                    break;
                }
                case 3:
                {
                    int[] inputs = GetValue();
                    int result = Multiplication(inputs[0],inputs[1]);
                    System.Console.WriteLine($"Multiplication of two numbers is : {result}");
                    break;
                }
                case 4:
                {
                    int[] inputs = GetValue();
                    double result = Division(inputs[0],inputs[1]);   
                    System.Console.WriteLine($"Division of two numbers is : {result}");
                    break;
                }
                case 5:
                {
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid input, enter the valid choice.");
                    break;
                }
            }
        }while(choice != 5);

        int[] GetValue(){
            int[] inputArray = new int[2];
            System.Console.WriteLine("Enter the first number :");
            inputArray[0] = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the second number :");
            inputArray[1] = int.Parse(Console.ReadLine());
            return inputArray;
        }

        //Addition function
        int Addition(int number1,int number2){
            int sum = number1 + number2;
            return sum;
        }

        //Subtraction fuction
        int Subtraction(int number1,int number2){
            int subtractedValue = number1 - number2;
            return subtractedValue;
        }

        //Multiplication function
        int Multiplication(int number1,int number2){
            int multipliedValue = number1 * number2;
            return multipliedValue;
        }

        //Division function
        double Division(int number1,int number2){
            double dividedValue = (double)number1/number2;
            return dividedValue;
        }
    }
}