using System;
namespace Question8;
class Program
{
    public static void Main(string[] args)
    {
        int numberOfHolidays = 0, workDayPlaytime = 63, holidayPlaytime = 127, playInWorkDays = 0, playInHolidays = 0, totalPlayTime = 0,playInHrs = 0,playInMins = 0;
        System.Console.Write("Enter the nummber of holidays : ");
        numberOfHolidays = int.Parse(Console.ReadLine());
        playInWorkDays = (365 - numberOfHolidays) * workDayPlaytime;
        playInHolidays = numberOfHolidays * holidayPlaytime;
        totalPlayTime = playInHolidays + playInWorkDays;

        if(totalPlayTime > 30000){
            totalPlayTime -= 30000;
            playInHrs = totalPlayTime / 60;
            playInMins = totalPlayTime % 60;
            System.Console.WriteLine($"Tom will run away\n{playInHrs} hours and {playInMins} minutes for play");
        }
        else{
            totalPlayTime = 30000 - totalPlayTime;
            playInHrs = totalPlayTime / 60;
            playInMins = totalPlayTime % 60;
            System.Console.WriteLine($"Toms sleeps well\n{playInHrs} hours and {playInMins} minutes less for play");
        }
    }
}