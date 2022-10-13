using System;
namespace ExcptionHandling;
class Program
{
    public static void Main(string[] args)
    {
        try{
            int number1 = 0, number2 = 0;
            System.Console.Write("Enter the first number : ");
            number1 = int.Parse(Console.ReadLine());
            System.Console.Write("Enter the second number : ");
            number2 = int.Parse(Console.ReadLine());
            int number3 = number1 / number2;
            System.Console.WriteLine($"Output : {number3}");
        }
        catch(DivideByZeroException e){
            System.Console.WriteLine($"Exception occured : {e.Message}");
        }
        catch(FormatException e){
            System.Console.WriteLine($"Exception occured : {e.StackTrace}");
        }
        catch(Exception e){
            System.Console.WriteLine(e.StackTrace);
        }
        finally{
            System.Console.WriteLine("Exception Handled without crashing application");
        }
    }
}