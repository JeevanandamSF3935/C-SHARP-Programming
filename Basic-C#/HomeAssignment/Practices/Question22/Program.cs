using System;
namespace Question22;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the count : ");
        int count = int.Parse(Console.ReadLine());
        for(int i = 1;i <= count;i++){
            for(int j = 1;j <= 5*count;j++){
                if(i!=1 && i!=count){
                    if(j==1 || j==2*count||j == (3*count)+1 || j==5*count){
                        System.Console.Write("*");
                    }
                    else if(j > 2*count && j <= 3*count && i == Math.Ceiling((double)count/2)){
                        System.Console.Write("|");
                    }
                    else if((j > 1 && j < 2*count)||(j>3*count+1 && j<5*count)){
                        System.Console.Write("/");
                    }
                    else if(j > 2*count && j < 3*count+1){
                        System.Console.Write(" ");
                    }
                }
                else{
                    if(!(j > 2*count && j <= 3*count)){
                        System.Console.Write("*"); 
                    }
                    else{
                        System.Console.Write(" ");
                    }
                }
            }
            System.Console.WriteLine();
        }
    }
}