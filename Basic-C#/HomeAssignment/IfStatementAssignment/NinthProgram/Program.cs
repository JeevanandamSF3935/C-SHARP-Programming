using System;
namespace NinthProgram;
class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the month with first letter in uppercase:");
        String month = Console.ReadLine();
        if(month == "January" || month == "February" || month == "December"){
            System.Console.WriteLine("Winter");
        }
        else if(month == "March" || month == "April" || month == "May"){
            System.Console.WriteLine("Spring");
        }
        else if(month == "June" || month == "July" || month == "August"){
            System.Console.WriteLine("Summer");
        }
        else if(month == "September" || month == "October" || month == "November"){
            System.Console.WriteLine("Rainfall");
        }
        else{
            System.Console.WriteLine("Invalid month");
        }
    }
}