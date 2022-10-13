using System;
namespace EigthProgram;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the details to calculate percentage :");
        int [] marksDetails = GetDetails();
        double obtainedPercentage = PercentageCalculator(marksDetails);
        System.Console.WriteLine($"Percentage : {obtainedPercentage}%");

        //Details getting method
        int[] GetDetails(){
            int[] marksArray = new int[3];
            System.Console.WriteLine("Enter the mark 1:");
            marksArray[0] = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the mark 2:");
            marksArray[1] = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the mark 3:");
            marksArray[2] = int.Parse(Console.ReadLine());
            return marksArray;
        }

        //Percentage calculation method
        double PercentageCalculator(int[] markDetails){
            double percentage = (double) (markDetails[0] + markDetails[1] +markDetails[2])/3;
            return percentage;
        }
    }
}