using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        int bitCoin = 0;
        double yuvans = 0, commissionFee = 0,usd = 0,bgn = 0,eur = 0,totalEUR = 0;
        System.Console.Write("Enter the bitcoin count : ");
        bitCoin = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the yuvans having : ");
        yuvans = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the commission percentage : ");
        commissionFee = double.Parse(Console.ReadLine());

        bgn = (double)bitCoin * 1168;
        usd = yuvans * 0.15;

        bgn = bgn + (usd / 1.76);
        eur = bgn / 1.95;
        totalEUR = eur - (eur * commissionFee / 100);

        System.Console.WriteLine($"Peter has {totalEUR} Euro");
    }
}