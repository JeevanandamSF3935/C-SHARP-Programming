
namespace Exercise3
{
    public class RecurringDeposit:PersonalInfo, ICalculate
    {
        public int AccNumber { get; set; }

        public Acc AccType { get; set; }

        public double Balance { get; set; }

        public RecurringDeposit(int accNumber, Acc type, string name, Gender sex , DateTime dob, long phoneNumber, long mobile, string pan):base(name, sex , dob, phoneNumber, mobile, pan)
        {
            AccNumber = accNumber;
            AccType = type;
        }

        public void BalanceCheck()
        {
            System.Console.WriteLine($"Balance: {Balance}");
        }
    }
}