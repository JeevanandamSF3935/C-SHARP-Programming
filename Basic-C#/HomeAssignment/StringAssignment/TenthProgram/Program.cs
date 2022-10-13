using System;
namespace TenthProgram;
class Program
{
    public static void Main(string[] args)
    {
        int checker = 1,checker1 = 1;
        string userName = "", passWord = "";
        string[] userNames = {"user","user1","user2","user3","user4"};
        string[] passWords = {"pass","pas123","Pass123","Pass@21","pas#321"};
        System.Console.WriteLine("Input a username :");
        userName = Console.ReadLine();
        System.Console.WriteLine("Input a password :");
        passWord = Console.ReadLine();
        foreach(string checkUser in userNames){
            if(checkUser == userName){
                System.Console.Write("Username found, ");
                foreach(string checkPass in passWords){
                    if(checkPass == passWord){
                        System.Console.WriteLine("Password entered successfully!");
                        break;
                    }
                    else{
                        checker = 0;
                    }
                }
                if(checker == 0) System.Console.WriteLine("Password not entered successfully!");
                break;
            }
            else{
                checker1 = 0;
            }
        }
        if(checker1 == 0){
            System.Console.WriteLine("UserName not found");
        }
    }
}