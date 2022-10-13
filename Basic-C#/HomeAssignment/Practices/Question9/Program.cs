using System;
namespace Question9;
class Program
{
    public static void Main(string[] args)
    {
        int vineYardSize = 0, requiredWine = 0, numberOfWorkers = 0, wineForWorkers = 0;
        double grapesForWine = 0, obtainedWine = 0, grapesPerMeterSqr = 0, cultivatedGrapes = 0;
        System.Console.Write("Enter the vineyard size in meter square : ");
        vineYardSize = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the grapes cultivated in yard in kg/m2 : ");
        grapesPerMeterSqr = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the required quantity of wine in litres : ");
        requiredWine = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the number of workers in vineyard : ");
        numberOfWorkers = int.Parse(Console.ReadLine());

        cultivatedGrapes = vineYardSize * grapesPerMeterSqr;
        grapesForWine = cultivatedGrapes * 0.4;

        obtainedWine = Math.Floor(grapesForWine / 2.5);

        if(requiredWine > obtainedWine){
            requiredWine = requiredWine - (int)obtainedWine;
            System.Console.WriteLine($"It will be tough winter! More {requiredWine} liters wine needed");
        }
        else{
            System.Console.WriteLine($"Good harvest this year! Total wine : {obtainedWine} liters");
            obtainedWine = (double)obtainedWine - requiredWine;
            wineForWorkers = (int)obtainedWine / numberOfWorkers;
            System.Console.Write($"{obtainedWine} liters left -> {wineForWorkers} liters per person");
        }
    }
}