using System;
namespace DateTimeAssignment;
class Program
{
    public static void Main(string[] args)
    {
        DateTime day = new DateTime(2021,8,10,10,40,32);
        System.Console.WriteLine("Year \t: "+day.Year);
        System.Console.WriteLine("Month \t: "+day.Month);
        System.Console.WriteLine("Day \t: "+day.Day);
        System.Console.WriteLine("Hours \t: "+day.Hour);
        System.Console.WriteLine("Minutes : "+day.Minute);
        System.Console.WriteLine("Seconds : "+day.Second);
        string dayTime = day.ToString();
        System.Console.WriteLine(dayTime);
        string[] splitedDayTime = dayTime.Split(' ','/',':');
        for(int i = splitedDayTime.Length-1;i >= 0;i--){
            System.Console.Write($"{splitedDayTime[i]} ");
        }
        System.Console.WriteLine("Enter the date and time in the format (2001/12/31 13hrs:32mins:12secs tt)");
        DateTime userDayTime = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd HH:mm:ss tt",null);
        System.Console.WriteLine($"Year\t: {userDayTime.Year}");
        System.Console.WriteLine($"Month\t: {userDayTime.Month}");
        System.Console.WriteLine($"Day\t: {userDayTime.Day}");
    }
}