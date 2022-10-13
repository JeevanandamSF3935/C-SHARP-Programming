using System;
namespace OnlineFoodOrder;
public delegate void Function();
class Program
{
    public static void Main(string[] args)
    {
        Function function = new Function(Files.CreateFile);
        function += new Function(Files.ReadFile);
        function += new Function(MenuClass.MainMenu);
        function += new Function(Files.WriteFile);
        function();
    }
}