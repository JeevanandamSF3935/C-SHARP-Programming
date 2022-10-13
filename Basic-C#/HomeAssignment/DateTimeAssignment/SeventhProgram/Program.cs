using System;
namespace SeventhProgram;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the first date in the formate (dd/MM/yyyy) :");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.WriteLine("Enter the second date in the formate (dd/MM/yyyy) :");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        int checker = DateTime.Compare(firstDate,secondDate);
        if(checker < 0){
            System.Console.WriteLine($"{firstDate} is earlier than {secondDate}");
        }
        else if(checker == 0){
            System.Console.WriteLine($"{firstDate} and {secondDate} are same days");
        }
        else{
            System.Console.WriteLine($"{firstDate} is later than {secondDate}");
        }
    }
}