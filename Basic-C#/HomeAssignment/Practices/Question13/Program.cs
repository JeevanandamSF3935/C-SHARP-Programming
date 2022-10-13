using System;
namespace Question13;
class Program{
    public static void Main(string[] args)
    {
        int height = 0;
        System.Console.Write("Enter the height of block : ");
        height = int.Parse(Console.ReadLine());
        int blockWidth = height * 3;
        int blockHeight = height * 4;
        System.Console.WriteLine("Enter the co-ordinates :");
        int xCoordinate = int.Parse(Console.ReadLine());
        int yCoordinate = int.Parse(Console.ReadLine());
        if(xCoordinate >= 0 && xCoordinate < height){
            if(yCoordinate >= 0 && yCoordinate < height){
                if(xCoordinate % height == 0 || yCoordinate % height == 0){
                    System.Console.WriteLine("Border");
                }
                else{
                    System.Console.WriteLine("Inside");
                }
            }
            else{
                System.Console.WriteLine("Outside");
            }
        }
        else if(xCoordinate >= height && xCoordinate <= 2*height){
            if(yCoordinate >= 0 && yCoordinate <= 4*height){
                if(xCoordinate % height == 0 || yCoordinate % height == 0){
                    System.Console.WriteLine("Border");
                }
                else{
                    System.Console.WriteLine("Inside");
                }
            }
            else{
                System.Console.WriteLine("Outside");
            }
        }
        else if(xCoordinate > 2*height && xCoordinate <= 3*height){
            if(yCoordinate >= 0 && yCoordinate <= height){
                if(xCoordinate % height == 0 || yCoordinate % height == 0){
                    System.Console.WriteLine("Border");
                }
                else{
                    System.Console.WriteLine("Inside");
                }
            }
            else{
                System.Console.WriteLine("Outside");
            }
        }
        else{
            System.Console.WriteLine("Outside");
        }
    }
}