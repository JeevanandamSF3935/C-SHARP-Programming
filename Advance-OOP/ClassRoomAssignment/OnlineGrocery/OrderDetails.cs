using System;
namespace OnlineGrocery;
public class OrderDetails
{
    private static int s_orderId = 100;
    public string OrderID { get; }
    public string BookingID { get; set; }
    public string ProductID { get; set; }
    public int PurchaseCount { get; set; }
    public double PriceOfOrder { get; set; }
    public OrderDetails(){

    }
    public OrderDetails(string bookingId,string productId,int purchaseCount,double priceOfOrder){
        s_orderId++;
        OrderID = "OID" + s_orderId;
        BookingID = bookingId;
        ProductID = productId;
        PurchaseCount = purchaseCount;
        PriceOfOrder = priceOfOrder;
    }
    public OrderDetails(string data){
        string[] values = data.Split(',');
        s_orderId = int.Parse(values[0].Remove(0,3));
        OrderID = values[0];
        BookingID = values[1];
        ProductID = values[2];
        PurchaseCount = int.Parse(values[3]);
        PriceOfOrder = double.Parse(values[4]);
    }

    public void ShowOrders(){
        System.Console.WriteLine($"{OrderID}\t\t{BookingID}\t\t{ProductID}\t\t{PurchaseCount}\t\t{PriceOfOrder}");
    }
}