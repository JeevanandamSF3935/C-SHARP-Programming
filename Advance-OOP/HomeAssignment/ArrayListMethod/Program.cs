using System;
namespace ArrayListMethod;

class Program
{
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("ADD");
        list.Add(0.5);
        list.Add('a');
        list.Add(2);
        list.Remove("ADD");
        list.RemoveAt(1);
        int j = list.IndexOf('a');
        System.Console.WriteLine(j);
        System.Console.WriteLine();
        for(int i = 0;i<list.Count;i++){
            System.Console.WriteLine(list[i]);
        }
    }
}