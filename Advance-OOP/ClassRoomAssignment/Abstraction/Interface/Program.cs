namespace Interface;
class Program
{
    public static void Main(string[] args)
    {
        Draw draw = new Draw();
        draw.GetData(2.0,3.0);
        draw.CalculateArea();
        draw.Show();
    }
}