namespace ECommerce;
public class Login
{
    public static void CustomerLogin(){
        bool customerCheck = true;
        System.Console.Write("Enter the Customer ID : ");
        string customerId = Console.ReadLine().ToUpper();
        foreach(CustomerDetails customer in Registration.customersList){
            customerCheck = true;
            if(customer.CustomerID == customerId){
                System.Console.WriteLine("Login Successfull\n");
                MenuClass.SubMenu(customer);
                break;
            }
            else{
                customerCheck = false;
            }
        }
        if(!customerCheck){
            System.Console.WriteLine("Login Unsuccessfull\nInvalid Customer ID!!!\n");
        }
    }
}