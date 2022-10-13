namespace Multipath;

class Program 
{
    public static void Main(string[] args)
    {
        DefaultValue();
    }
    
    static void DefaultValue()
    {
        PGCounselling obj = new PGCounselling(new DateTime(2021, 10, 11), FeeStatus.Paid, "AID9854798", "Vikram", "Raghu", 96678689, 8768687, 100,100,100, 300, 300, 100, 96976966, 90, 98, 97, 90, 390, 98);
        obj.PayFees(500);
        obj.ShowInfo();




    }
}