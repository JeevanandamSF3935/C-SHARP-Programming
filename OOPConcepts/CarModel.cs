namespace OOPConcepts;
public abstract class CarModel
{
    public string Colour { get; set; }
    public abstract double FuelCapacity { get; set; }
    public int NoOfSeats { get; set; }
    public abstract double Mileage { get; set; }

    public CarModel(){

    }
    public CarModel(string colour , int noOfSeats){
        Colour = colour;
        NoOfSeats = noOfSeats;
    }
}