using System;
namespace OnlineFoodOrder;
public class FoodDetails
{
    public string FoodID { get;}
    public string FoodName { get; set; }
    public double PricePerQuantity { get; set; }

    public FoodDetails(string data){
        string[] values = data.Split(',');
        FoodID = values[0];
        FoodName = values[1];
        PricePerQuantity = double.Parse(values[2]);
    }
    public static void ShowDetails(){
        System.Console.WriteLine("Food ID\tFood Name\tPrice Per Quantity");
        foreach(FoodDetails food in Process.foodsList){
            System.Console.WriteLine($"{food.FoodID}\t{food.FoodName}\t-{food.PricePerQuantity}");
        }
    }
}