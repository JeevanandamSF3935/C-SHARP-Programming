namespace ECommerce;
public class ProductDetails
{
    public static List<ProductDetails> productsList = new List<ProductDetails>();
    public static int s_productId = 100;
    public string ProductID { get; }
    public string ProductName { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
    public int ShippingDuration { get; set; }

    public ProductDetails(){

    }

    public ProductDetails(string productName,int price,int stock,int shippingDuration){
        s_productId++;
        ProductID = "PID" + s_productId;
        ProductName = productName;
        Price = price;
        Stock = stock;
        ShippingDuration = shippingDuration;
    }

    public ProductDetails(string product){
        string[] values = product.Split(',');
        s_productId = int.Parse(values[0].Remove(0,3));
        ProductID = values[0];
        ProductName = values[1];
        Price = int.Parse(values[2]);
        Stock = int.Parse(values[3]);
        ShippingDuration = int.Parse(values[4]);
    }
    public static void ShowProducts(){
        System.Console.WriteLine("ProductID\tProduct Name\tAvailable Stock\t\tPrice Per Quantity\tShipping Duration");
        foreach(ProductDetails product in productsList){
            System.Console.WriteLine($"{product.ProductID}\t\t{product.ProductName}\t\t{product.Stock}\t\t\t{product.Price}\t\t\t{product.ShippingDuration}");
        }
    }
}