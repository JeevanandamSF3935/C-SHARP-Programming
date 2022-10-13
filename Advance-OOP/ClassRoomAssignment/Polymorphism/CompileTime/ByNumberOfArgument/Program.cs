namespace ByNumberOfArguments;
public class MyClass
{

    static void Display(int number){
        System.Console.WriteLine($"Number : {number}");
    }

    //Method Overload
    static void Display(int number1,int number2){
        System.Console.WriteLine($"Number1 is {number1} and Number2 is {number2}");
    }
    public static void Main(string[] args)
    {
        Display(1);
        Display(2,3);
    }
}