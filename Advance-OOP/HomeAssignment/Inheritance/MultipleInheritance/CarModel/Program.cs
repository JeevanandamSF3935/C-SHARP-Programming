namespace Exercise2;

class Program 
{
    public static void Main(string[] args)
    {
      DefaultValue();  
    }

    static void DefaultValue()
    {
        ShiftDezire obj1 = new ShiftDezire(2, 3, "Benz", "Classiz", Fuel.Electric, 4, "Black", 5, 200);
        obj1.ShowDetails();

        System.Console.WriteLine();

        Eco obj2 = new Eco(2,3, "Tesla", "Vetran", Fuel.Electric, 4, "Black", 4, 100);
        obj2.ShowDetails();
    }
}