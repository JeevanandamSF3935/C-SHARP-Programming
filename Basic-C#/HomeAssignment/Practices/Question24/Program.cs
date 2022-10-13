using System;
namespace Question24;
class Program
{
    public static void Main(string[] args)
    {
        int count1 = 0;
        System.Console.Write("Enter the count : ");
        int count = int.Parse(Console.ReadLine());
        double temp = Math.Ceiling((double)count / 2);
        double temp1 = temp;
        if(count % 2==0){count1 = count-1;}
        else{count1 = count;}
        for(int i = 1; i <= count1; i++){
            for(int j = 1; j <= count;j++){
                if(i < Math.Ceiling((double)count / 2)){
                    if(count % 2 == 0){
                        if(j == temp || j == temp1+1){
                            System.Console.Write("*");
                        }
                        else{
                            System.Console.Write("-");
                        }
                    }
                    else{
                        if(j == temp || j == temp1){
                            System.Console.Write("*");
                        }
                        else{
                            System.Console.Write("-");
                        }
                    }
                }
                else if(i == Math.Ceiling((double)count / 2)){
                    if(count % 2 == 0){
                        if(j == temp || j == temp1+1){
                            System.Console.Write("*");
                        }
                        else{
                            System.Console.Write("-");
                        }
                    }
                    else{
                        if(j == temp || j == temp1){
                            System.Console.Write("*");
                        }
                        else{
                            System.Console.Write("-");
                        }
                    }
                }
                else{
                    if(count % 2 == 0){
                        if(j == temp || j == temp1+1){
                            System.Console.Write("*");
                        }
                        else{
                            System.Console.Write("-");
                        }
                    }
                    else{
                        if(j == temp || j == temp1){
                            System.Console.Write("*");
                        }
                        else{
                            System.Console.Write("-");
                        }
                    }
                }
            }
            if(i < Math.Ceiling((double)count / 2)){
                temp--;
                temp1++;
            }
            else{
                temp++;
                temp1--;
            }
            System.Console.WriteLine();
        }
    }
}