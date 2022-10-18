using System;
namespace IfStatment;
class Program
{
    public static void Main(string[] args)
    {
        char grade;
        System.Console.Write("Enter the Grade : ");
        grade = char.Parse(Console.ReadLine().ToUpper());
        if(grade == 'A'){
            System.Console.WriteLine("Grade A denotes 9 points");
        }
        else if(grade == 'B'){
            System.Console.WriteLine("Grade A denotes 8 points");
        }
        else if(grade == 'C'){
            System.Console.WriteLine("Grade A denotes 7 points");
        }
        else if(grade == 'D'){
            System.Console.WriteLine("Grade A denotes 6 points");
        }
        else{
            System.Console.WriteLine("This is not valid grade");
        }
    }
}