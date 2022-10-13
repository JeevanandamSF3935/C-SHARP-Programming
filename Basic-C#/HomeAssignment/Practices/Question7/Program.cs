using System;
namespace Question7;
class Program
{
    public static void Main(string[] args)
    {
        int volumeOfTank = 0, flowOfPipeOne = 0, flowOfPipeTwo = 0;
        double absenceOfWork = 0,waterFilled = 0, waterLost = 0,waterByPipe1 = 0, waterByPipe2 = 0;

        System.Console.Write("Enter the volume of the tank : ");
        volumeOfTank = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the flow rate of pipe-1 in L/Hr : ");
        flowOfPipeOne = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the flow rate of pipe-2 in L/Hr : ");
        flowOfPipeTwo = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the absence of worker in Hrs : ");
        absenceOfWork = double.Parse(Console.ReadLine());
        
        waterByPipe1 = flowOfPipeOne * absenceOfWork;
        waterByPipe2 = flowOfPipeTwo * absenceOfWork;
        waterFilled = waterByPipe1 + waterByPipe2;

        waterLost = volumeOfTank - waterFilled;

        if(waterLost < 0){
            System.Console.WriteLine($"For {absenceOfWork} the pool overflows with {waterLost + (waterLost * -2)}");
        }
        else{
            waterByPipe1 = (waterByPipe1 / waterFilled) * 100;
            waterByPipe1 = 
            waterByPipe2 = (waterByPipe2 / waterFilled) * 100;
            System.Console.WriteLine($"The pool is {waterFilled / volumeOfTank * 100}% full. Pipe 1: {waterByPipe1}. Pipe 2:{waterByPipe2}%");
        }
    }
}