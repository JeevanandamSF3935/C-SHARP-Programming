
namespace Exercise2
{
    public class AccountInfo : PersonalInfo
    {
        public int AccountNumber { get; set; }

        public string BranchName { get; set; }

        public string IFSC { get; set; }

        public double Balance { get; set; }

        public AccountInfo()
        {

        }

        public AccountInfo(string name, string fatherName, long phoneNumber, Gender sex, int accNo, string branch, string ifsc, double bal):base(name, fatherName, phoneNumber, sex)
        {
            AccountNumber = accNo;
            BranchName = branch;
            IFSC = ifsc;
            Balance = bal;
        }


        public void ShowAccountsInfo()
        {
            System.Console.WriteLine("< ------- ACCOUNT INFO ------->");
            System.Console.WriteLine();
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Father Name: {FatherName}");
            System.Console.WriteLine($"Phone: {Phone}");
            System.Console.WriteLine($"Mail: {Mail}");
            System.Console.WriteLine($"DOB: {DOB}");
            System.Console.WriteLine($"Gender: {genderInfo}");
            System.Console.WriteLine($"Account Number: {AccountNumber}");
            System.Console.WriteLine($"Branch Name: {BranchName}");
            System.Console.WriteLine($"IFSC Code: {IFSC}");
            System.Console.WriteLine($"Balance: {Balance}");
        }

        public void AccBal()
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Balance: {Balance}");
        }
    }
}