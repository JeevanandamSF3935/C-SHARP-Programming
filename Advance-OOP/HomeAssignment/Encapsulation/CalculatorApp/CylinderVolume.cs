namespace CalculatorApp;
public class CylinderVolume:CircleArea
{
    private double height;
    public double Height { get; set; }
    internal double Volume { get; set; }
    public CylinderVolume(){
        
    }

    public void GetHeightData(){
        System.Console.Write("Enter the height : ");
        height = double.Parse(Console.ReadLine());
        Height = height;
    }
    public void CalculateVolume(CircleArea circle){
        double area = circle.CalculateArea();
        Volume = area * Height;
        System.Console.WriteLine($"Volume : {Volume.ToString("0.00")}");
    }
}