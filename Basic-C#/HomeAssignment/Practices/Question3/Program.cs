using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        double sideOfGround = 0, widthOfTile = 0, lengthOfTile = 0, widthOfBench = 0, lengthOfBench = 0,areaOfGround = 0, areaOfTile = 0, areaOfBench = 0, tilesRequired = 0,timeRequired = 0;
        System.Console.Write("Enter the side of ground : ");
        sideOfGround = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the width of tile : ");
        widthOfTile = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the length of tile : ");
        lengthOfTile = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the width of bench : ");
        widthOfBench = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the length of bench : ");
        lengthOfBench = double.Parse(Console.ReadLine());

        areaOfBench = lengthOfBench * widthOfBench;
        areaOfTile = lengthOfTile * widthOfTile;
        areaOfGround = sideOfGround * sideOfGround;

        areaOfGround = areaOfGround - areaOfBench;
        tilesRequired = areaOfGround / areaOfTile;
        timeRequired = tilesRequired * 0.2;
        System.Console.WriteLine($"Tiles reqiured to replace : {tilesRequired}");
        System.Console.WriteLine($"Time reqiured to replace : {timeRequired}");
    }
}