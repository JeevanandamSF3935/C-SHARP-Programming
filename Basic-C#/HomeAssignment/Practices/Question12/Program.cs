namespace Question12;
class Program
{
    public static void Main(string[] args)
    {
        string inputYearType = "";
        int countOfHolidays = 0, countOfWeekendsToHome = 0;
        double holidayPlayingTime = 0, weekendPlayingTime = 0, leapYearPlayTime = 0, totalPlayTime = 0;
        
        System.Console.Write("Enter the year type (leap or normal) : ");
        inputYearType = Console.ReadLine();
        
        System.Console.Write("Enter the count of holidays : ");
        countOfHolidays = int.Parse(Console.ReadLine());
        
        System.Console.Write("Enter the count of weekends going to hometown : ");
        countOfWeekendsToHome = int.Parse(Console.ReadLine());
        holidayPlayingTime = (double)(countOfHolidays * 2) / 3;
        weekendPlayingTime = (double)(48 * 3) / 4;
        totalPlayTime = holidayPlayingTime + weekendPlayingTime;
        
        if(inputYearType == "leap"){
            leapYearPlayTime = totalPlayTime + (totalPlayTime * 0.15);
            leapYearPlayTime = Math.Floor(leapYearPlayTime);
            System.Console.WriteLine(leapYearPlayTime);
        }
        else{
            totalPlayTime = Math.Floor(totalPlayTime);
            System.Console.WriteLine(totalPlayTime);
        }
    }
}