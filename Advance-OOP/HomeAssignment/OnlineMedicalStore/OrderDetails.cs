using System;

namespace OnlineMedicalStore;
public enum OrderStatus
{
    Default,Purchased,Cancelled
}
public class OrderDetails
{
    private static int s_orderID = 2000;
    public string OrderID { get; set; }
    public string UserID { get; set; }
    public string MedicineID { get; set; }
    public int MedicineCount { get; set; }
    public double Price { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }

    public OrderDetails(){

    }

    public OrderDetails(string userID,string medicineID,int medicineCount,double price,DateTime orderDate,OrderStatus status){
        s_orderID++;
        OrderID = "OID" + s_orderID;
        UserID = userID;
        MedicineID = medicineID;
        MedicineCount = medicineCount;
        Price = price;
        OrderDate = orderDate;
        Status = status;
    }

    public OrderDetails(string data){
        string[] values = data.Split(',');
        s_orderID = int.Parse(values[0].Remove(0,3));
        OrderID = values[0];
        UserID = values[1];
        MedicineID = values[2];
        MedicineCount = int.Parse(values[3]);
        Price = double.Parse(values[4]);
        OrderDate = DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
        Status = Enum.Parse<OrderStatus>(values[6]);
    }


}