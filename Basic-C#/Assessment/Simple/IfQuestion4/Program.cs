using System;
namespace IfQuestion4;
class Program
{
    public static void Main(string[] args)
    {
        string nameOfMonth = "";
        int noOfLeaves = 0,salary = 0;
        System.Console.WriteLine("Enter the name of the month :");
        nameOfMonth = Console.ReadLine();
        System.Console.WriteLine("Enter the number of leaves taken :");
        noOfLeaves = int.Parse(Console.ReadLine());
        nameOfMonth = nameOfMonth.ToLower();
        switch(nameOfMonth){
            case "january":{
                salary = (31 - noOfLeaves) * 500;
                break;
            }
            case "february":{
                salary = (28 - noOfLeaves) * 500;
                break;
            }
            case "march":{
                salary = (31 - noOfLeaves) * 500;
                break;
            }
            case "april":{
                salary = (30 - noOfLeaves) * 500;
                break;
            }
            case "may":{
                salary = (31 - noOfLeaves) * 500;
                break;
            }
            case "june":{
                salary = (30 - noOfLeaves) * 500;
                break;
            }
            case "july":{
                salary = (31 - noOfLeaves) * 500;
                break;
            }
            case "august":{
                salary = (31 - noOfLeaves) * 500;
                break;
            }
            case "september":{
                salary = (30 - noOfLeaves) * 500;
                break;
            }
            case "october":{
                salary = (31 - noOfLeaves) * 500;
                break;
            }
            case "november":{
                salary = (30 - noOfLeaves) * 500;
                break;
            }
            case "december":{
                salary = (31 - noOfLeaves) * 500;
                break;
            }
            default:{
                System.Console.WriteLine("Invalid input");
                break;
            }
        }
        System.Console.WriteLine($"The salary is {salary}");
    }
}