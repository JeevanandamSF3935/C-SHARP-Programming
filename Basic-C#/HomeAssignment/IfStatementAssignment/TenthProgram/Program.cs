using System;
namespace tenthProgram;

class Program{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the Password :");
        string passWord = Console.ReadLine();
        
        if(passWord == "HiTeam"){
            System.Console.WriteLine("Right Password");
        }
        else{
            System.Console.WriteLine("Wrong Password");
        }
    }
}