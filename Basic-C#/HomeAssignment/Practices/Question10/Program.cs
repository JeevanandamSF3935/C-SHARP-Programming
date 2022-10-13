using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        double hoursNeeded = 0, daysForProject = 0, workers = 0, daysForWork = 0, workTimeOfEmployee = 0, timeForProject = 0;
        System.Console.Write("Enter the hours needed for project : ");
        hoursNeeded = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the days for project : ");
        daysForProject = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the number of workers : ");
        workers = double.Parse(Console.ReadLine());

        daysForWork = daysForProject - (daysForProject * 0.1);
        workTimeOfEmployee = daysForWork * 10;
        timeForProject = workTimeOfEmployee * workers;

        if(timeForProject > hoursNeeded){
            System.Console.WriteLine($"Yes!{timeForProject-hoursNeeded} hours left");
        }
        else{
            System.Console.WriteLine($"No!{hoursNeeded - timeForProject} hours needed");
        }
    }
}