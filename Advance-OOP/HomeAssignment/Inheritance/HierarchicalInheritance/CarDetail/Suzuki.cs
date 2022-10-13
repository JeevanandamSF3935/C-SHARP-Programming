using System;

namespace CarDetail;
public class Suzuki:CarInfo
{
    public string ModelNumber { get; set; }
    public string ModelName { get; set; }
    public Suzuki(){

    } 
    public Suzuki(string modelNumber,string modelName,string rcBookNumber,string engineNumber,string chasisNumber,double mileage,double tankCapacity,int numberOfSeats,double numberOfKmsDriven,DateTime dateOfPurchase):base(rcBookNumber,engineNumber,chasisNumber,mileage,tankCapacity,numberOfSeats,numberOfKmsDriven,dateOfPurchase){
        ModelNumber = modelNumber;
        ModelName = modelName;
    }

    public void ShowInfo(){
        System.Console.WriteLine("SUZUKI MOTORS");
        System.Console.WriteLine($"Model Number : {ModelNumber}");
        System.Console.WriteLine($"Model Name : {ModelName}");
        System.Console.WriteLine($"RCBookNumber : {RCBookNumber}");
        System.Console.WriteLine($"Engine Number : {EngineNumber}");
        System.Console.WriteLine($"Chasis Number : {ChasisNumber}");
        System.Console.WriteLine($"Mileage : {Mileage}");
        System.Console.WriteLine($"Tank Capacity : {TankCapacity}");
        System.Console.WriteLine($"No Of Seats : {NumberOfSeats}");
        System.Console.WriteLine($"No of Kms Driven : {NumberOfKmsDriven}");
        System.Console.WriteLine($"Date of Purcahse : {DateOfPurchase.ToString("dd/MM/yyyy")}");
    }
}