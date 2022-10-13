
namespace BankAccount
{
    public class Login
    {
        static AccountOpening account = new AccountOpening();
        public static void AccountLogin(){
            System.Console.Write("Enter the Account Number : ");
            long accountNumber = long.Parse(Console.ReadLine());
            foreach(AccountOpening accounts in Register.accountsList){
                if(accounts.AccountNumber == accountNumber){
                    System.Console.WriteLine("Login Successfully!");
                    account = accounts;
                    SubMenu();
                }
                else{
                    System.Console.WriteLine("Wrong Password");
                    AccountLogin();
                }
            }
        }

        public static void SubMenu(){
            int choice = 0;
            do{
                System.Console.WriteLine("Select option\n1. Show Details\n2. Withdraw\n3. Deposit\n4. Show Balance\n5. Exit SubMenu");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        System.Console.WriteLine("Details :");
                        account.ShowDetails();
                        break;
                    }
                    case 2:{
                        System.Console.WriteLine("Withdraw :");
                        account.WithDrawAmount();
                        break;
                    }
                    case 3:{
                        System.Console.WriteLine("Deposit");
                        account.DepositAmount();
                        break;
                    }
                    case 4:{
                        System.Console.WriteLine("Show Balance");
                        account.ShowBalance();
                        break;
                    }
                    case 5:{
                        System.Console.WriteLine("Exit Sub menu");
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Invalid choice!\nEnter again");
                        break;
                    }
                }
            }while(choice!=5);
        }
    }
}