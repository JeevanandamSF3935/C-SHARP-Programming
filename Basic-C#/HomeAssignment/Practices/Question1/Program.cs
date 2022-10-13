using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        double length = 0,breadth = 0,rowOccupy = 0,columnOccupy = 0;
        int workPlaces = 0;
        System.Console.WriteLine("Enter the length of the lab :");
        length = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the breadth of the lab :");
        breadth = double.Parse(Console.ReadLine());

        breadth = breadth - 1;

        rowOccupy = length / 1.2;
        columnOccupy = breadth / 0.7;
        rowOccupy = Math.Floor(rowOccupy);
        columnOccupy = Math.Floor(columnOccupy);
        workPlaces = (int)(rowOccupy * columnOccupy) - 3;

        System.Console.WriteLine($"The number of working places in lab : {workPlaces}");
    }
}