using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        DefaultValue();
    }

    static void DefaultValue()
    {
        SavingsAccount obj = new SavingsAccount(798993, Acc.Savings, "Vikram", Gender.Male, new DateTime(2001, 11, 20), 8687687876, 878775, "FSB&98");
        obj.BalanceCheck();

        RecurringDeposit obj1  = new RecurringDeposit(3634524, Acc.Savings, "Ayan", Gender.Male, new DateTime(2011, 11, 20), 346365, 8734638775, "FSG6798");
        obj.BalanceCheck();
    }
}