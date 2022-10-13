namespace ECommerce;
public class MenuClass
{
    public static void MainMenu(){
        int choice = 0;
        do{
            System.Console.WriteLine("Enter your choice:\n1.Registration\n2.Login and purchase\n3.Exit");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    Registration.CustomerRegistration();
                    break;
                }
                case 2:{
                    Login.CustomerLogin();
                    break;
                }
                case 3:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice!\nEnter again\n");
                    break;
                }
            }
        }while(choice!=3);
    }

    public static void SubMenu(CustomerDetails customer){
        int choice = 0;
        do{
            System.Console.WriteLine("Enter your choice:\n1.Purchase\n2.Order History\n3.Cancel Order\n4.Wallet Balance\n5.Log out");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    PurchaseClass.Purchase(customer);
                    break;
                }
                case 2:{
                    PurchaseClass.OrderHistory(customer);
                    break;
                }
                case 3:{
                    PurchaseClass.CancelOrder(customer);
                    break;
                }
                case 4:{
                    PurchaseClass.WalletBalanceCheck(customer);
                    break;
                }
                case 5:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice!\nEnter again\n");
                    break;
                }
            }
        }while(choice!=5);
    }
}
