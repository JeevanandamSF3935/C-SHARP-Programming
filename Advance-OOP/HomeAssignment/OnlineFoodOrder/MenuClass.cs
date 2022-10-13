using System;
namespace OnlineFoodOrder;
public class MenuClass
{
    public static void MainMenu(){
        int choice = 0;
        bool check = true;
        try{
            do{
                System.Console.WriteLine();
                System.Console.WriteLine("\tONLINE FOOD ORDER APPLICATION");
                System.Console.WriteLine("\t******Main Menu******");
                System.Console.WriteLine("Enter the choice :\n1.Customer Registration\n2.Customer Login\n3.Exit");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        Process.UserRegistration();
                        break;
                    }
                    case 2:{
                        Process.UserLogin();
                        break;
                    }
                    case 3:{
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Invalid Choice!!!");
                        break;
                    }
                }
            }while(choice!=3);
            check = true;
        }catch(Exception e){
            check = false;
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine();
        }finally{
            if(!check){
                MainMenu();
            }
        }
    }

    public static void SubMenu(CustomerRegistration customer){
        int choice = 0;
        bool check = true;
        try{
            do{
                System.Console.WriteLine();
                System.Console.WriteLine("Enter the choice :\n1.Show Food Item Details\n2.Order Food\n3.Cancel Order\n4.Cancel Booking\n5.Order History\n6.Recharge Wallet\n7.Log Out");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        FoodDetails.ShowDetails();
                        break;
                    }
                    case 2:{
                        Process.OrderFood(customer);
                        break;
                    }
                    case 3:{
                        Process.CancelOrder(customer);
                        break;
                    }
                    case 4:{
                        Process.CancelBooking(customer);
                        break;
                    }
                    case 5:{
                        Process.OrderHistory(customer);
                        break;
                    }
                    case 6:{
                        customer.WalletRecharge();
                        break;
                    }
                    case 7:{
                        System.Console.WriteLine("Logging Out!!!");
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Invalid Choice!!!");
                        break;
                    }
                }
                check = true;
            }while(choice!=7);
        }
        catch(Exception e){
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine();
            check = false;
        }
        finally{
            if(!check){
                SubMenu(customer);
            }
        }
    }
}