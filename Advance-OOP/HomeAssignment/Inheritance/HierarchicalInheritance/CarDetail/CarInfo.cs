using System;
namespace CarDetail;
public class CarInfo
{
    public string RCBookNumber { get; set; }
    public string EngineNumber { get; set; }
    public string ChasisNumber { get; set; }
    public double Mileage { get; set; }
    public double TankCapacity { get; set; }
    public int NumberOfSeats { get; set; }
    public double NumberOfKmsDriven { get; set; }
    public DateTime DateOfPurchase { get; set; }

    public CarInfo(){

    }

    public CarInfo(string rcBookNumber,string engineNumber,string chasisNumber,double mileage,double tankCapacity,int numberOfSeats,double numberOfKmsDriven,DateTime dateOfPurchase){
        RCBookNumber = rcBookNumber;
        EngineNumber = engineNumber;
        ChasisNumber = chasisNumber;
        Mileage = mileage;
        TankCapacity = tankCapacity;
        NumberOfSeats = numberOfSeats;
        NumberOfKmsDriven = numberOfKmsDriven;
        DateOfPurchase = dateOfPurchase;
    }
}