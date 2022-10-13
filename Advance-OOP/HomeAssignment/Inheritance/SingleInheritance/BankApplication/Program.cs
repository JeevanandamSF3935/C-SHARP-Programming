using System;

namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
        DefaultValue();
    }

    public static void DefaultValue()
    {
        AccountInfo obj = new AccountInfo("Vikram", "raghu", 97909798, PersonalInfo.Gender.Male, 097238793, "AVADI", "CBN0001", 10000);
        obj.AccBal();
        obj.ShowAccountsInfo();

        AccountInfo obj1 = new AccountInfo("Jeeva", "perumal", 3446363, PersonalInfo.Gender.Male, 778866788, "CHENNAI", "CBN0881", 11000);
        obj1.AccBal();
        obj1.ShowAccountsInfo();
    }
}