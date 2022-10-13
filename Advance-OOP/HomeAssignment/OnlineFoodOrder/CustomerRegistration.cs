using System;
namespace OnlineFoodOrder;
public class CustomerRegistration:PersonalDetails,IBalance
{
    private static int s_customerId = 1000;
    public string CustomerId { get;}
    public double WalletBalance { get; set; }
    public CustomerRegistration(){

    }
    public CustomerRegistration(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mailId,string location):base(name,fatherName,gender,mobileNumber,dob,mailId,location){
        s_customerId++;
        CustomerId = "CID" + s_customerId;
        WalletBalance = 0;
    }

    public CustomerRegistration(string data){
        string[] values = data.Split(',');
        s_customerId = int.Parse(values[0].Remove(0,3));
        CustomerId = values[0];
        WalletBalance = double.Parse(values[1]);
        Name = values[2];
        FatherName = values[3];
        UserGender = Enum.Parse<Gender>(values[4],true);
        MobileNumber = long.Parse(values[5]);
        DOB = DateTime.ParseExact(values[6],"dd/MM/yyyy",null);
        MailId = values[7];
        Location = values[8];
    }

    public void WalletRecharge(){
        System.Console.Write("Enter amount to be recharged : ");
        double amount = double.Parse(Console.ReadLine());
        WalletBalance += amount;
        System.Console.WriteLine($"Recharged Successfully...\nWallet Balance : {WalletBalance}");
    }
}