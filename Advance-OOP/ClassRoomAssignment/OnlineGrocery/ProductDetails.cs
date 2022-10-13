using System;

namespace OnlineGrocery;
public class ProductDetails
{
    private static int s_productId = 100;
    public string ProductID { get; }
    public string ProductName { get; set; }
    public int QuantityAvailable { get; set; }
    public double PricePerQuantity { get; set; }

    public ProductDetails(){

    }
    public ProductDetails(string productName,int quantityAvailable,double pricePerQuantity){
        s_productId++;
        ProductID = "PID" + s_productId;
        ProductName = productName;
        QuantityAvailable = quantityAvailable;
        PricePerQuantity = pricePerQuantity;
    }

    public ProductDetails(string data){
        string[] values = data.Split(',');
        s_productId = int.Parse(values[0].Remove(0,3));
        ProductID = values[0];
        ProductName = values[1];
        QuantityAvailable = int.Parse(values[2]);
        PricePerQuantity = double.Parse(values[3]);
    }

    public void ShowProducts(){
        System.Console.WriteLine($"{ProductID}\t\t   {ProductName}   \t\t{QuantityAvailable}\t\t\t{PricePerQuantity}");
    }
}