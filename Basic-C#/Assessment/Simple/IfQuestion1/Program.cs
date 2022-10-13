using System;
namespace IfQuestion1;
class Program
{
    public static void Main(string[] args)
    {
        string passWord = "" , checkPassWord = "s3cr3t!P@ssw0rd";
        System.Console.WriteLine("Enter the password : (CASE SENSITIVE)");
        passWord = Console.ReadLine();
        if(passWord == checkPassWord){
            System.Console.WriteLine("Welcome");
        }
        else{
            System.Console.WriteLine("Wrong password!");
        }
    }
}