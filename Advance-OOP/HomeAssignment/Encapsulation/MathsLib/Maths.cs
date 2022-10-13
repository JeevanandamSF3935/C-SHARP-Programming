namespace MathsLib;
public class Maths
{
    protected internal double PI = 3.14;
    internal double g = 9.8;
    public double Weight { get; set; }
    public Maths(){

    }
    public void CalculateWeight(double mass){
        Weight = mass * g;
        System.Console.WriteLine($"Weight : {Weight.ToString("0.00")}");
    }
}