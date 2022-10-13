using System;
namespace OnlineMedicalStore;
public class MenuClass
{
    public static void MainMenu(){
        int choice = 0;
        System.Console.WriteLine("\tONLINE MEDICAL STORE");
        System.Console.WriteLine("******Main Menu******");
        do{
            System.Console.WriteLine("Enter the choice :\n1.User Registration\n2.User Login\n3.Exit");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    Process.UserRegister();
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
                    System.Console.WriteLine("Invalid Choice\nEnter again!!!");
                    break;
                }
            }
        }while(choice!=3);
    }

    public static void SubMenu(UserDetails user){
        int choice = 0;
        System.Console.WriteLine("\tONLINE MEDICAL STORE");
        System.Console.WriteLine("******Sub Menu******");
        do{
            System.Console.WriteLine("Enter the choice :\n1.Show Medical List\n2.Purchase Medicine\n3.Cancel Purchase\n4.Show Purchase History\n5.Recharge\n6.Log Out");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    MedicineDetails.ShowMedicine();
                    break;
                }
                case 2:{
                    Process.Purchase(user);
                    break;
                }
                case 3:{
                    Process.CancelPurchase(user);
                    break;
                }
                case 4:{
                    Process.ShowPurchase(user);
                    break;
                }
                case 5:{
                    user.Recharge();
                    break;
                }
                case 6:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid Choice\nEnter Again!!!");
                    break;
                }
            }
        }while(choice!=6);
    }

}