using MathsLib;
namespace CalculatorApp;
public class CircleArea:Maths
{
    protected double radius;
    public double Radius { get; set; }
    internal double Area { get; set; }

    public CircleArea(){
        
    }

    public void GetData(){
        System.Console.Write("Enter the radius : ");
        radius = double.Parse(Console.ReadLine());
        Radius = radius;
    }
    public double CalculateArea(){
        Area = PI * Radius * Radius;
        return Area;
    }

}