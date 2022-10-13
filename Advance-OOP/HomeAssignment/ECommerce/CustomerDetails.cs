namespace ECommerce;

public class CustomerDetails
{
    public static int s_customerId = 1000;
    public string CustomerID { get; }
    public string CustomerName { get; set; }
    public string City { get; set; }
    public long PhoneNumber { get; set; }
    public string MailID { get; set; }
    public int WalletBalance { get; set; }
    public CustomerDetails(){

    }
    public CustomerDetails(string customerName,string city,long phoneNumber,string mailId,int walletBalance){
        s_customerId++;
        CustomerID = "CID" + s_customerId;
        CustomerName = customerName;
        City = city;
        PhoneNumber = phoneNumber;
        MailID = mailId;
        WalletBalance = walletBalance;
    }

    public CustomerDetails(string customer){
        string[] values = customer.Split(',');
        s_customerId = int.Parse(values[0].Remove(0,3));
        CustomerID = values[0];
        CustomerName = values[1];
        City = values[2];
        PhoneNumber = long.Parse(values[3]);
        MailID = values[4];
        WalletBalance = int.Parse(values[5]);
    }

}