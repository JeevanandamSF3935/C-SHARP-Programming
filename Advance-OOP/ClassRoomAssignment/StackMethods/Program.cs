using System;
namespace StackMethods;
class Program
{
    public static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("Hi");
        stack.Push("Hello");
        string s = stack.Pop();
        System.Console.WriteLine(s);
        s = stack.Pop();
        System.Console.WriteLine(s);
        s = stack.Pop();
        System.Console.WriteLine(s);
        s = stack.Pop();
    }
}