
namespace CurrentBillCalculation
{
    public class Register
    {
        public static List<BillCalculation> ebList = new List<BillCalculation>();
        public static void EBRegister(){
            System.Console.Write("Enter the User name : ");
            string userName = Console.ReadLine();
            System.Console.Write("Enter the MailId : ");
            string mailID = Console.ReadLine();
            System.Console.Write("Enter the Phone number : ");
            long phoneNumber = long.Parse(Console.ReadLine());
            BillCalculation bill = new BillCalculation(userName,phoneNumber,mailID);
            System.Console.WriteLine($"EB connections is generated\nYour MeterId is {bill.MeterID}");
            ebList.Add(bill);
        }
    }
}