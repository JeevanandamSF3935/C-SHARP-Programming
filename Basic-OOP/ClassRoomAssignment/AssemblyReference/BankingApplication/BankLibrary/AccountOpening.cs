namespace BankLibrary;
public enum Gender
{
    Default, Male, Female, Transgender
}
public enum AccountType{
    Default, SB, FD, RD
}

public class AccountOpening
{
    private static int s_accountNumber = 0;
    private double _accountBalance = 0;
    public long AccountNumber{ get; }
    public string Name { get; set; }
    public string FatherName { get; set; }
    public Gender Gender { get; set; }
    public DateTime DOB { get; set; }
    public AccountType AccountType { get; set; }
    public double Balance { get; set; }

    public AccountOpening(string name, string fatherName, Gender gender, DateTime dob,AccountType accountType){
        s_accountNumber++;
        AccountNumber = 10012342100000 + s_accountNumber;
        Name = name;
        FatherName = fatherName;
        Gender = gender;
        DOB = dob;
        AccountType = accountType;
        Balance = _accountBalance;
    }

    public void DepositAmount(){
        System.Console.WriteLine("Do you want to deposit a amount ?");
        string choice = Console.ReadLine().ToLower();
        if(choice == "yes"){
            System.Console.Write("Enter the amount to be deposited : ");
            double depositAmount = double.Parse(Console.ReadLine());
            Balance +=  depositAmount;
            System.Console.WriteLine($"Rs.{depositAmount} has been deposited");
        }
    }

    public void WithDrawAmount(){
        System.Console.WriteLine("Do you want to withdraw a amount ?");
        string choice = Console.ReadLine().ToLower();
        if(choice == "yes"){
            System.Console.WriteLine("Enter the amount to be withdrawed : ");
            double withDrawAmount = double.Parse(Console.ReadLine());
            Balance -= withDrawAmount;
            System.Console.WriteLine($"Rs.{withDrawAmount} has been withdrawed");
        }
    }

    public void ShowBalance(){
        System.Console.WriteLine($"Your Account balance is : Rs.{Balance}");
    }
}