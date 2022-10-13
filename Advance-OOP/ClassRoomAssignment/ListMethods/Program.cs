using System;
namespace ListMethods;
class Program{
    public static void Main(string[] args)
    {
        List<int> datas = new List<int>();
        datas.AddElement(1);
        datas.AddElement(2);

        for(int i = 0; i<datas.Count;i++){
            System.Console.WriteLine(datas[i]);
        }
        System.Console.WriteLine();
        datas[1] = 0;
        foreach(int i in datas){
            System.Console.WriteLine(i);
        }
    }
}