namespace ByType;
class Program
{

    static void Display(int number){
        System.Console.WriteLine($"Number : {number}");
    }

    //Method Overload
    static void Display(string name){
        System.Console.WriteLine($"Name is {name}");
    }
    public static void Main(string[] args)
    {
        Display(1);
        Display("Jeeva");
    }
}