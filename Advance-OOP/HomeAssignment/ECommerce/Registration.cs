namespace ECommerce;
public class Registration
{
    public static List<CustomerDetails> customersList = new List<CustomerDetails>();
    public static void CustomerRegistration(){
        System.Console.Write("Enter the name : ");
        string customerName = Console.ReadLine();
        System.Console.Write("Enter the city : ");
        string city = Console.ReadLine();
        System.Console.Write("Enter the phone number : ");
        long phoneNumber = long.Parse(Console.ReadLine());
        System.Console.Write("Enter the MailID : ");
        string mailId = Console.ReadLine();
        int walletBalance = 0;
        CustomerDetails customer = new CustomerDetails(customerName,city,phoneNumber,mailId,walletBalance);
        customersList.Add(customer);
        System.Console.Write($"Registered Successfully\nCustomerId : {customer.CustomerID}\n");
    }
}