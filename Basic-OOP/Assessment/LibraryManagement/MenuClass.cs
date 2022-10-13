namespace LibraryManagement;
public class MenuClass
{
    public static void MainMenu(){
        int choice = 0;
        do{
            System.Console.WriteLine("Enter the choice for Main Menu :\n1.User Registration\n2.User Login\n3.Exit");
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
                    System.Console.WriteLine("Invalid choice!\nEnter again!!!");
                    break;
                }
            }
        }while(choice!=3);
    }
    public static void SubMenu(UserDetails user){
        int choice = 0;
        do{
            System.Console.WriteLine("Enter the choice for Sub Menu :\n1.Borrow Book\n2.Return Book\n3.Show Borowed History\n4.Show Wallet Balance\n5.Recharge Wallet\n6.Log out");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    Process.BorrowBook(user);
                    break;
                }
                case 2:{
                    Process.ReturnBook(user);
                    break;
                }
                case 3:{
                    Process.BorrowedHistory(user);
                    break;
                }
                case 4:{
                    System.Console.WriteLine($"Your wallet Balance is Rs.{user.WalletBalance}");
                    break;
                }
                case 5:{
                    Process.RechargeWallet(user);
                    break;
                }
                case 6:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid input!\nEnter again!!!");
                    break;
                }
            }
        }while(choice!=6);
    }
}