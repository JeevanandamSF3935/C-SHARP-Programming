using System;
using System.IO;
namespace OnlineMedicalStore;
public class Files
{
    public static void CreateFile(){
        if(!Directory.Exists("MedicalStore")){
            System.Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory("MedicalStore");
        }
        else{
            System.Console.WriteLine("Folder Exists!!!");
        }
        if(!File.Exists("MedicalStore\\UserDetails.csv")){
            System.Console.WriteLine("Creating file...");
            File.Create("MedicalStore\\UserDetails.csv");
        }
        else{
            System.Console.WriteLine("File Exists!!!");
        }
        if(!File.Exists("MedicalStore\\MedicineDetails.csv")){
            System.Console.WriteLine("Creating file...");
            File.Create("MedicalStore\\MedicineDetails.csv");
        }
        else{
            System.Console.WriteLine("File Exists!!!");
        }
        if(!File.Exists("MedicalStore\\OrderDetails.csv")){
            System.Console.WriteLine("Creating file...");
            File.Create("MedicalStore\\OrderDetails.csv");
        }
        else{
            System.Console.WriteLine("File Exists!!!");
        }
    }

    public static void ReadFile(){
        string[] medicineData = File.ReadAllLines("MedicalStore\\MedicineDetails.csv");
        foreach(string medicine in medicineData){
            MedicineDetails medicine1 = new MedicineDetails(medicine);
            Process.medicinesList.Add(medicine1);
        }

        string[] orderData = File.ReadAllLines("MedicalStore\\OrderDetails.csv");
        foreach(string order in orderData){
            OrderDetails order1 = new OrderDetails(order);
            Process.ordersList.Add(order1);
        }

        string[] userData = File.ReadAllLines("MedicalStore\\UserDetails.csv");
        foreach(string user in userData){
            UserDetails user1 = new UserDetails(user);
            Process.usersList.Add(user1);
        }
    }

    public static void WriteFile(){
        string[] userData = new string[Process.usersList.Count];
        for(int i = 0;i<Process.usersList.Count;i++){
            userData[i] = Process.usersList[i].UserId+","+Process.usersList[i].UserName+","+Process.usersList[i].Age+","+Process.usersList[i].City+","+Process.usersList[i].PhoneNumber+","+Process.usersList[i].Balance;
        }
        File.WriteAllLines("MedicalStore\\UserDetails.csv",userData);

        string[] orderData = new string[Process.ordersList.Count];
        for(int i = 0;i<Process.ordersList.Count;i++){
            orderData[i] = Process.ordersList[i].OrderID+","+Process.ordersList[i].UserID+","+Process.ordersList[i].MedicineID+","+Process.ordersList[i].MedicineCount+","+Process.ordersList[i].Price+","+Process.ordersList[i].OrderDate.ToString("dd/MM/yyyy")+","+Process.ordersList[i].Status;
        }
        File.WriteAllLines("MedicalStore\\OrderDetails.csv",orderData);

        string[] medicineData = new string[Process.medicinesList.Count];
        for(int i = 0; i < Process.medicinesList.Count;i++){
            medicineData[i] = Process.ordersList[i].MedicineID+","+Process.medicinesList[i].MedicineName+","+Process.medicinesList[i].AvailableCount+","+Process.medicinesList[i].Price+","+Process.medicinesList[i].ExpiryDate.ToString("dd/MM/yyyy");
        }
        File.WriteAllLines("MedicalStore\\MedicineDetails.csv",medicineData);

    }


}