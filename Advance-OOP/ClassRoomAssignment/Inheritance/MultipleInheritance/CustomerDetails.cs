namespace MultipleInheritance;
public class CustomerDetails:PersonalDetails
{
    public static int s_customerId=1000;
    public string CustomerID { get; set; }
    public double Balance { get; set;}
    public CustomerDetails(){

    }
    public CustomerDetails(string name,string fatherName,Gender gender,long phoneNumber):base(name,fatherName,gender,phoneNumber){
        s_customerId++;
        CustomerID = "CID"+s_customerId;
    }

    public void Recharge(){
        System.Console.Write("\n\nEnter the amount to be recharged : ");
        Balance += double.Parse(Console.ReadLine());
    }

    public void ShowCustomer(){
        System.Console.WriteLine("******CUSTOMER DETAILS******");
        System.Console.WriteLine($"Customer ID \t: {CustomerID}");
        ShowDetails();
        System.Console.WriteLine($"Wallet Balance \t: {Balance}");
    }

}