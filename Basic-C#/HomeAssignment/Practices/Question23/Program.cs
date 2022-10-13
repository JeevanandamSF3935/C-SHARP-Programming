using System;
namespace Question23;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the count : ");
        int count = int.Parse(Console.ReadLine());
        double temp = Math.Ceiling((double)count / 2);
        double temp1 = temp;
        for(int i = 1; i <= count; i++){
            for(int j = 1; j <= count;j++){
                if(i < Math.Ceiling((double)count / 2)){
                    if(count % 2 == 0){
                        if(j >= temp && j <= temp1+1){
                            System.Console.Write("*");
                        }
                        else{
                            System.Console.Write("-");
                        }
                    }
                    else{
                        if(j >= temp && j <= temp1){
                            System.Console.Write("*");
                        }
                        else{
                            System.Console.Write("-");
                        }
                    }
                }
                else if(i == Math.Ceiling((double)count / 2)){
                    System.Console.Write("*");
                }
                else{
                    if(j == 1 || j == count){
                        System.Console.Write("|");
                    }
                    else{
                        System.Console.Write("*");
                    }
                }
            }
            temp--;
            temp1++;
            System.Console.WriteLine();
        }
    }
}