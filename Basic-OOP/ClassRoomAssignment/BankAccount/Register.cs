namespace BankAccount
{
    public static class Register
    {
        public static List<AccountOpening> accountsList = new List<AccountOpening>();
        public static void UserRegister(){
            Gender gender;
            AccountType accountType;
            System.Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            System.Console.Write("Enter your father's name : ");
            string fatherName = Console.ReadLine();
            System.Console.Write("Enter your gender : ");
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!temp){
                System.Console.WriteLine("Not entered correct option.\nEnter again :");
                temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            System.Console.Write("Enter your date of birth in the formate dd/mm/yyyy : ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter the account type (SB or FD or RD) : ");
            bool temp1 = Enum.TryParse<AccountType>(Console.ReadLine(),true,out accountType);
            while(!temp1){
                System.Console.WriteLine("Not entered correct option.\nEnter again :");
                temp1 = Enum.TryParse<AccountType>(Console.ReadLine(),true,out accountType);
            }

            AccountOpening account = new AccountOpening(name,fatherName,gender,dob,accountType);
            accountsList.Add(account);
            System.Console.WriteLine($"Account generated!\nYour Account number is : {account.AccountNumber}");
        }
    }
}