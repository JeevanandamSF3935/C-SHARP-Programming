using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        double taylorSeriesSum = 0;
        while(count <= 8){
            taylorSeriesSum += (double)powerOfTwo(count)/factorial(count);
            count++;
        }
        taylorSeriesSum = Math.Round(taylorSeriesSum,4);

        System.Console.WriteLine($"The result of taylor series upto 8 is : {taylorSeriesSum}");

        //function of power of two
        int powerOfTwo(int power){
            int result = 1;
            while(power > 0){
                result = result * 2;
                power--;
            }
            return result;
        }

        //function of factorial
        int factorial(int number){
            int fact = 1;
            while(number > 0){
                fact = fact * number;
                number--;
            }
            return fact;
        }
    }
}