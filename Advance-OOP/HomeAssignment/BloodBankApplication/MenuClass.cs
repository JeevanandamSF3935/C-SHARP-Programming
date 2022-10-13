namespace BloodBankApplication;

public class MenuClass
{
    public static void MainMenu(){
        int choice = 0;
        do{
            System.Console.WriteLine("Enter your choice:\n1.Registration\n2.Login \n3.Fetch Donor Details\n4.Exit");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    Process.UserRegister();
                    break;
                }
                case 2:{
                    Process.Login();
                    break;
                }
                case 3:{
                    Process.ShowDonors();
                    break;
                }
                case 4:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice!\nEnter again\n");
                    break;
                }
            }
        }while(choice!=4);
    }

    public static void SubMenu(Registration donor){
        int choice = 0;
        do{
            System.Console.WriteLine("Enter your choice:\n1.Donate Blood\n2.Donation History\n3.Next Eligible Date\n4.Logout");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    Process.DonateBlood(donor);
                    break;
                }
                case 2:{
                    Process.DonationHistory(donor);
                    break;
                }
                case 3:{
                    Process.NextDueDate(donor);
                    break;
                }
                case 4:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice!\nEnter again\n");
                    break;
                }
            }
        }while(choice!=4);
    }
}