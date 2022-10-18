namespace OOPConcepts;
public enum BuyType
{
    Default,EMI,Netcash
}
public class Tata:CarModel,IEMI
{
    private static int s_modelID = 1000;
    public override double FuelCapacity { get; set; }
    public override double Mileage { get; set; }
    public double CarPrice { get; set; }
    public int NoOfMonths { get; set; }
    public double Interest { get; set; }
    public BuyType TypeOfBuy { get; set; }
    public string ModelID { get; }
    public double InsuranceAmount{get;set;}
    public Tata(){

    }
    public Tata(string colour,double fuelCapacity,double mileage, int noOfSeats,double carPrice,BuyType typeOfBuy,double insuranceAmount):base(colour,noOfSeats){
        s_modelID++;
        ModelID = "MID" + s_modelID;
        FuelCapacity = fuelCapacity;
        Mileage = mileage;
        CarPrice = carPrice;
        TypeOfBuy = typeOfBuy;
        InsuranceAmount = insuranceAmount;
        NoOfMonths = 24;
    }

    private double CalculateCarPrice(double price){
        double totalPrice = 0;
        if(TypeOfBuy.Equals(BuyType.EMI)){
            totalPrice = CalculateEMI(price) + InsuranceAmount;
        }
        else{
            totalPrice = price + InsuranceAmount;
        }
        return totalPrice;
    }

    public double CalculateEMI(double price){
        double emiAmountPerMonth = 0, emiAmount = 0;
        emiAmount = CarPrice + (CarPrice * Interest/100);
        emiAmountPerMonth = emiAmount / NoOfMonths;
        return emiAmountPerMonth;
    }

    public void ShowCatalog(){
        System.Console.WriteLine($"Car Model : {ModelID}");
        System.Console.WriteLine($"Fuel Capacity : {FuelCapacity}");
        System.Console.WriteLine($"Mileage : {Mileage}");
        System.Console.WriteLine($"No of Seats : {NoOfSeats}");
        System.Console.WriteLine($"Car Price : {CarPrice}");
        System.Console.WriteLine($"Method of Buy : {TypeOfBuy}");
        System.Console.WriteLine($"Payable Amount : {CalculateCarPrice(CarPrice).ToString("0.00")}");
    }
}