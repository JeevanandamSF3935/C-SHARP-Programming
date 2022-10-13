using System;

namespace IfStatementAssignment;
class Program{
    public static void Main(string[] args){
        System.Console.WriteLine("Enter the mark");
        int mark = int.Parse(Console.ReadLine());
        if(mark > 80 && mark < 100){
            System.Console.WriteLine("Grade A");
        }
        else if(mark > 60 && mark <= 80){
            System.Console.WriteLine("Grade B");
        }
        else if(mark > 35 && mark <= 60){
            System.Console.WriteLine("Grade C");
        }
        else if(mark <= 35 && mark >= 0){
            System.Console.WriteLine("Grade D");
        }
        else{
            System.Console.WriteLine("Invalid Input");
        }
        
    }
}