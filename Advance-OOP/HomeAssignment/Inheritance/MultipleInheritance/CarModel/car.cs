
namespace Exercise2
{   
    public enum Fuel { Default, Electric, Fossil }
    public class car
    {   

       public Fuel FuelType { get; set; }

       public int NoOfSeats { get; set; }

       public string Color { get; set; }

       public int TankCapacity { get; set; }

       public int KmDriven { get; set; }

       public car(Fuel type, int seats, string color, int capacity, int km)
       {
        FuelType = type;
        NoOfSeats = seats;
        Color = color;
        TankCapacity = capacity;
        KmDriven = km;
       }

       public void CalculateMileage()
       {
        double mileage = (double)TankCapacity / KmDriven;

        System.Console.WriteLine($"Mileage: {mileage}");
       }
    }
}