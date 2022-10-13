namespace AbstractClasses;
class Program
{
    public static void Main(string[] args)
    {
        TCS company1 = new TCS();
        company1.Name = "Developer";
        company1.Salary(30);
        Syncfusion company2 = new Syncfusion();
        company2.Name = "Testing Engineer";
        company2.Salary(30);
    }
}