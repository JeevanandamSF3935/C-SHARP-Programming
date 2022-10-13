namespace OperatorOverloading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1 = new Box(1,1,1);
        double volume = box1.Volume();
        System.Console.WriteLine($"Volume of box1 : {volume.ToString("0.00")}");
        Box box2 = new Box(1,1,1);
        volume = box2.Volume();
        System.Console.WriteLine($"Volume of box2 : {volume.ToString("0.00")}");
        Box box3 = box1 + box2;
        volume = box3.Volume();
        System.Console.WriteLine($"Volume of box3 : {volume.ToString("0.00")}");
        Box box4 = box2 + box3;
        volume = box4.Volume();
        System.Console.WriteLine($"Volume of box4 : {volume.ToString("0.00")}");
    }
}