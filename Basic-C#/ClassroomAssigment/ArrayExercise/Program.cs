using System;
namespace ArrayAssignment;

class Program
{
    public static void Main(string[] args)
    {
        int flag = 0, count = 0;
        System.Console.WriteLine("Enter the number of names to be stored :");
        count = int.Parse(Console.ReadLine());

        string[] names = new string[count];
        System.Console.WriteLine("Enter the Names :");
        for(int i=0;i < count;i++){
            names[i] = Console.ReadLine().ToLower();
        }

        System.Console.WriteLine("Names in array are :");
        for(int i=0;i < count;i++){
            System.Console.WriteLine(names[i]);
        }

        //using for
        System.Console.WriteLine("Enter the Name to be searches :");
        string searchName = Console.ReadLine().ToLower();
        for(int i = 0;i < count;i++){
            if(names[i] == searchName){
                System.Console.WriteLine($"The name is present in array at the index {i}");
                flag = 1;
            }
            else{
                continue;
            }
        }
        if(flag == 0){
            System.Console.WriteLine("The name is not present in array");
        }
        //using foreach
        flag = 0;
        System.Console.WriteLine("Enter the Name to be searches :");
        string searchName1 = Console.ReadLine().ToLower();
        foreach(string name in names){
            if(name == searchName1){
                System.Console.WriteLine($"The name is present in array");
                flag = 1;
            }
            else{
                continue;
            }
        }
        if(flag == 0){
            System.Console.WriteLine("The name is not present in array");
        }
    }
}