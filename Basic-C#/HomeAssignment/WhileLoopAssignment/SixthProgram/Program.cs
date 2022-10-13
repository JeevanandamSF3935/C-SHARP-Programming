using System;
namespace SixthProgram;

class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        int iterator = 1;
        while(iterator <= 100){
            if(iterator % 2 ==0){
                System.Console.Write($"\n{iterator} is Even");
            }
            else{
                System.Console.Write($"\n{iterator} is Odd");
                int temp = 1,dividingCount = 0;
                while(temp <= iterator){
                    if(iterator % temp == 0){
                        dividingCount++;
                    }
                    temp++;
                }
                if(dividingCount <= 2){
                        count++;
                        System.Console.Write(" and Prime");
                    }
            }
            iterator++;
        }
        //System.Console.WriteLine(count);
    }
}