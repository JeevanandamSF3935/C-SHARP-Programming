using System;
using System.Linq;
using System.Collections.Generic;
namespace EigthProblem;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the length in meter");
        int meter = int.Parse(Console.ReadLine());
        int centiMeter = meter * 100;
        int milliMeter = centiMeter * 10;
        double inch = (double)meter * 39.3;
        int foot = meter * 12;
        double mile = (double)meter * 0.0006213715277778;

        Console.WriteLine($"CM \t= {centiMeter} cm\nMm \t= {milliMeter} mm\nInch \t= {inch} inch\nFoot \t= {foot} feet\nMile \t= {mile} miles");
        Console.ReadKey();
        Dictionary<string,string> phone = new Dictionary<string, string>();
    }
}