using System;
namespace CarDetail;

class Program
{
    public static void Main(string[] args)
    {
        Suzuki car1 = new Suzuki("SUZ10034","Alto","128734","ENG1293","CIS098767",25,20,5,14024,new DateTime(2011,06,30));
        car1.ShowInfo();
        System.Console.WriteLine("\n\n");
        Tata car2 = new Tata("TATA452426","Nexon","345226","ENG4563","CIS13086",22,17,6,8344,new DateTime(2018,01,20));
        car2.ShowInfo();
    }
}