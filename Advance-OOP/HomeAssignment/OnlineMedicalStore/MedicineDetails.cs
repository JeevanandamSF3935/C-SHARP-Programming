using System;
namespace OnlineMedicalStore;
public class MedicineDetails
{
    private static int s_medicineId = 100;
    public string MedicineId { get;}
    public string MedicineName { get; set; }
    public int AvailableCount { get; set; }
    public double Price { get; set; }
    public DateTime ExpiryDate{ get; set; }

    public MedicineDetails(){

    }
    public MedicineDetails(string medicineName,int availableCount,double price,DateTime expiryDate){
        s_medicineId++;
        MedicineId = "MD" + s_medicineId;
        MedicineName = medicineName;
        AvailableCount = availableCount;
        Price = price;
        ExpiryDate = expiryDate;
    }


    public MedicineDetails(string data){
        string[] values = data.Split(',');
        s_medicineId = int.Parse(values[0].Remove(0,2));
        MedicineId = values[0];
        MedicineName = values[1];
        AvailableCount = int.Parse(values[2]);
        Price = double.Parse(values[3]);
        ExpiryDate = DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
    }

    public static void ShowMedicine(){
        System.Console.WriteLine("MedicineId\tMedicine Name   Available Count\tPrice\tExpiry Date");
        foreach(MedicineDetails medicine in Process.medicinesList){
            System.Console.WriteLine($"{medicine.MedicineId}\t\t{medicine.MedicineName}   \t{medicine.AvailableCount}\t\t{medicine.Price}\t{medicine.ExpiryDate.ToString("dd/MM/yyyy")}");
        }
    }


}