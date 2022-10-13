using System;
namespace FirstProgram;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the numbers dates should be stored :");
        int dateCount = int.Parse(Console.ReadLine());
        DateTime[] daysContent = new DateTime[dateCount + 1];
        daysContent[0] = DateTime.Now;
        System.Console.WriteLine("Enter the date and time in the formate of (yyyy,MM,dd,hh,mm,ss):");
        for(int i = 1;i <= dateCount;i++){
            daysContent[i] = DateTime.ParseExact(Console.ReadLine(),"yyyy,MM,dd,HH,mm,ss",null);
        }
        System.Console.WriteLine("Entered dates are (*Note : first date and time is always present date and time) :");
        for(int i = 0;i <= dateCount;i++){
            System.Console.WriteLine($"Day: {daysContent[i].ToString("MM/dd/yyyy")} Time: {daysContent[i].TimeOfDay}");
            System.Console.WriteLine($"Day: {daysContent[i].ToString("MM/dd/yyyy")} Time: {daysContent[i].ToString("hh:mm tt")}");
            System.Console.WriteLine();
        } 
    }
}