using MathsLib;
namespace CalculatorApp;

class Program
{
    public static void Main(string[] args)
    {
        CircleArea circle = new CircleArea();
        circle.GetData();
        double area = circle.CalculateArea();
        System.Console.WriteLine($"Area : {area}");
        CylinderVolume cylinder = new CylinderVolume();
        cylinder.GetHeightData();
        cylinder.CalculateVolume(circle);
        System.Console.Write("Enter the weight : ");
        double weight = double.Parse(Console.ReadLine());
        Maths weight1 = new Maths();
        weight1.CalculateWeight(weight);
    }
}