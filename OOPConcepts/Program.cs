using System;
namespace OOPConcepts;
class Program
{
    public static void Main(string[] args)
    {
        Tata car1 = new Tata("Red",20,8,5,400000,BuyType.EMI,5000);
        Tata car2 = new Tata("Black",24,12,4,460000,BuyType.Netcash,10000);
        car1.ShowCatalog();
        System.Console.WriteLine();
        System.Console.WriteLine();
        car2.ShowCatalog();
    }
}