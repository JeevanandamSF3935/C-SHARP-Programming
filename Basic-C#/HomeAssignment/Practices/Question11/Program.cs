using System;
namespace Question11;
public enum ScreenType
{
    Default,Priemere,Normal,Discount
}
class Program
{
    public static void Main(string[] args)
    {
        int rows = 0, columns = 0, totalSeats = 0;
        float totalIncome = 0;
        ScreenType screenType;
        System.Console.Write("Enter the screen type : ");
        bool temp = Enum.TryParse<ScreenType>(Console.ReadLine(),true,out screenType);
        while(!temp){
            System.Console.Write("Invalid entry\nEnter again : ");
            temp = Enum.TryParse<ScreenType>(Console.ReadLine(),true,out screenType);
        }
        System.Console.Write("Enter the rows : ");
        rows = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the columns : ");
        columns = int.Parse(Console.ReadLine());
        totalSeats = rows * columns;
        switch(screenType.ToString()){
            case "Priemere":
            {
                totalIncome = (float)totalSeats * 12.0f;
                break;
            }
            case "Normal":
            {
                totalIncome = (float)totalSeats * 7.50f;
                break;
            }
            case "Discount":
            {
                totalIncome = (float)totalSeats * 5.00f;
                break;
            }
        }
        System.Console.WriteLine(totalIncome.ToString("0.00"));
    }
}