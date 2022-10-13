using BankLibrary;
namespace BankApplication;
public class Operations
{
    public static void MainMenu()
    {
        string willing = "",name = "",fatherName = "";
        Gender gender;
        AccountType accountType;
        DateTime dob = new DateTime();
        List<AccountOpening> accountList = new List<AccountOpening>();

        System.Console.WriteLine("Do you want to open an account in our bank ?");
        willing = Console.ReadLine().ToLower();
        
        do{
            System.Console.Write("Enter your name : ");
            name = Console.ReadLine();
            System.Console.Write("Enter your father's name : ");
            fatherName = Console.ReadLine();
            System.Console.Write("Enter your gender : ");
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!temp){
                System.Console.WriteLine("Not entered correct option.\nEnter again :");
                temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            System.Console.Write("Enter your date of birth in the formate dd/mm/yyyy : ");
            dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter the account type (SB or FD or RD) : ");
            bool temp1 = Enum.TryParse<AccountType>(Console.ReadLine(),true,out accountType);
            while(!temp1){
                System.Console.WriteLine("Not entered correct option.\nEnter again :");
                temp1 = Enum.TryParse<AccountType>(Console.ReadLine(),true,out accountType);
            }

            AccountOpening account = new AccountOpening(name,fatherName,gender,dob,accountType);
            accountList.Add(account);
            System.Console.WriteLine($"Account generated!\nYour Account number is : {account.AccountNumber}");
            System.Console.WriteLine("Do you want to open an account in our bank ?");
            willing = Console.ReadLine().ToLower();
        }while(willing == "yes");

        foreach(AccountOpening accounts in accountList){
            System.Console.WriteLine($"Account number\t: {accounts.AccountNumber}");
            System.Console.WriteLine($"Name \t\t: {accounts.Name}");
            System.Console.WriteLine($"Father's Name\t: {accounts.FatherName}");
            System.Console.WriteLine($"Gender \t\t: {accounts.Gender}");
            System.Console.WriteLine($"Date of Birth\t: {accounts.DOB.ToShortDateString()}");
            System.Console.WriteLine($"Account Type\t: {accounts.AccountType}");
            accounts.DepositAmount();
            accounts.ShowBalance();
            accounts.WithDrawAmount();
            accounts.ShowBalance();
        }
    }
}