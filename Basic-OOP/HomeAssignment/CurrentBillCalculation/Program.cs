using System;
namespace CurrentBillCalculation;
class Program
{
    public static void Main(string[] args)
    {
        string userName = "",mailID = "",choice = "";
        long phoneNumber = 0;
        int unitsUsed = 0;

        List<BillCalculation> ebList = new List<BillCalculation>();

        System.Console.WriteLine("Do you want a EB connection ?");
        choice = Console.ReadLine().ToLower();
        
        do{
            System.Console.Write("Enter the User name : ");
            userName = Console.ReadLine();
            System.Console.Write("Enter the MailId : ");
            mailID = Console.ReadLine();
            System.Console.Write("Enter the Phone number : ");
            phoneNumber = long.Parse(Console.ReadLine());
            System.Console.Write("Enter the units used in this month : ");
            unitsUsed = int.Parse(Console.ReadLine());
            BillCalculation bill = new BillCalculation(userName,phoneNumber,mailID,unitsUsed);
            System.Console.WriteLine($"EB connections is generated\nYour MeterId is {bill.MeterID}");
            ebList.Add(bill);
            System.Console.WriteLine("Do you want a EB connection ?");
            choice = Console.ReadLine();

        }while(choice == "yes");

        foreach(BillCalculation bill in ebList){
            System.Console.WriteLine($"Meter ID\t: {bill.MeterID}");
            System.Console.WriteLine($"User Name\t: {bill.UserName}");
            System.Console.WriteLine($"Mail ID\t\t: {bill.MailID}");
            System.Console.WriteLine($"Phone Number \t: {bill.PhoneNumber}");
            bill.CalculateBill();
        }
    }
}