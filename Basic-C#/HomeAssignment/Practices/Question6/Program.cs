using System;
namespace Question6;
class Program
{
    public static void Main(string[] args)
    {
        int noOfKms = 0;
        string travelPreference = "";
        double taxiCharge = 0, busCharge = 0, trainCharge = 0, minimumCharge = 0;
        System.Console.Write("Enter the number of kilometers to be traveled : ");
        noOfKms = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the preference of your travel (day or night) : ");
        travelPreference = Console.ReadLine().ToLower();
        
        if(travelPreference == "day"){
            taxiCharge = noOfKms * 0.79 + 0.70;
            System.Console.WriteLine($"Taxi travel charges {taxiCharge} EUR");
        }
        else{
            taxiCharge = noOfKms * 0.90 + 0.70;
        }
        minimumCharge = taxiCharge;

        if(noOfKms > 20){
            busCharge = noOfKms * 0.09;
            System.Console.WriteLine($"Bus travel charges {busCharge} EUR");
            minimumCharge = busCharge;
        }
        else{
            System.Console.WriteLine("Cannot be travlled by bus");
        }
        if(noOfKms > 100){
            trainCharge = noOfKms * 0.06;
            System.Console.WriteLine($"Train travel charges {trainCharge} EUR");
            minimumCharge = trainCharge;
        }
        else{
            System.Console.WriteLine("Cannot be travelled by train");
        }

        System.Console.WriteLine($"The minimum transport costs {minimumCharge} EUR");
    }
}