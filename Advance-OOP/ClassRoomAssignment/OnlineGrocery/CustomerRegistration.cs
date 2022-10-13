using System;

namespace OnlineGrocery;
public class CustomerRegistration:PersonalDetails,IBalance
{
    private static int s_customerID = 3000;
    public string CustomerID { get; }
    public double WalletBalance { get; set; }
    public CustomerRegistration(){

    } 
    public CustomerRegistration(string name,string fatherName,Gender gender, long mobileNumber,DateTime dateOfBirth,string mailId):base(name,fatherName,gender,mobileNumber,dateOfBirth,mailId){
        s_customerID++;
        CustomerID = "CID" + s_customerID;
        WalletBalance = 0;
    }

    public CustomerRegistration(string data){
        string[] values = data.Split(',');
        s_customerID = int.Parse(values[0].Remove(0,3));
        CustomerID = values[0];
        WalletBalance = double.Parse(values[1]);
        Name = values[2];
        FatherName = values[3];
        UserGender = Enum.Parse<Gender>(values[4],true);
        MobileNumber = long.Parse(values[5]);
        DateOfBirth = DateTime.ParseExact(values[6],"dd/MM/yyyy",null);
        MailID = values[7];
    }
    public void WalletRecharge(){
        System.Console.Write("Enter the amount to be Recharged : ");
        double rechargeAmount = double.Parse(Console.ReadLine());
        WalletBalance += rechargeAmount;
        System.Console.WriteLine($"Recharge successfull!\nWallet Balance : {WalletBalance}");
    }

    public void ShowDetails(){
        System.Console.WriteLine($"{CustomerID}\t\t{Name}    \t{FatherName}\t{UserGender}\t\t{MobileNumber}\t{DateOfBirth.ToString("dd/MM/yyyy")}\t\t{MailID}  \t{WalletBalance}");
    }
}