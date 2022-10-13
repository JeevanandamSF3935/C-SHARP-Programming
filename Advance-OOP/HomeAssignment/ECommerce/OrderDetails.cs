namespace ECommerce;
public class OrderDetails
{
    public static List<OrderDetails> ordersList = new List<OrderDetails>();
    public static int s_orderId = 1000;
    public string OrderID { get; }
    public string CustomerID { get; set; }
    public string ProductID { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int TotalPrice { get; set; }
    public int Quantity { get; set; }
    public string OrderStatus { get; set; }

    public OrderDetails(){

    }

    public OrderDetails(string customerID,string productID,int totalPrice,DateTime purchaseDate,int quantity,string orderStatus){
        s_orderId++;
        OrderID = "OID"+s_orderId;
        CustomerID = customerID;
        ProductID = productID;
        TotalPrice = totalPrice;
        PurchaseDate = purchaseDate;
        Quantity = quantity;
        OrderStatus = orderStatus;
    }

    public OrderDetails(string order){
        string[] values = order.Split(',');
        s_orderId = int.Parse(values[0].Remove(0,3));
        OrderID = values[0];
        CustomerID = values[1];
        ProductID = values[2];
        TotalPrice = int.Parse(values[3]);
        PurchaseDate = DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
        Quantity = int.Parse(values[5]);
        OrderStatus = values[6];
    }
}