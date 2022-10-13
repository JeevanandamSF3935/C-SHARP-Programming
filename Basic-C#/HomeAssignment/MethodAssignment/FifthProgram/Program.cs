using System;
namespace FifthProgram;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number :");
        int value1 = int.Parse(Console.ReadLine());
        int check = PrimeNumberChecker(value1);
        if(check == 1){
            System.Console.WriteLine($"{value1} is a prime number");
        }
        else{
            System.Console.WriteLine($"{value1} is not a prime number");
        }
        //Prime number checking function
        int PrimeNumberChecker(int value1){
            int count = 0;
            for(int i = 1;i <= value1;i++){
                if(value1 % i == 0){
                    count++;
                }
                else{
                    continue;
                }
            }
            if(count <= 2){
                return 1;
            }
            else{
                return 0;
            }
        }
    }
}