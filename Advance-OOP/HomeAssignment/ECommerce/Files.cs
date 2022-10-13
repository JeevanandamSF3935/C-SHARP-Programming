namespace ECommerce;
public class Files
{
    public static void CreateFile(){
        if(!Directory.Exists("Ecommerce")){
            System.Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory("Ecommerce");
        }
        else{
            System.Console.WriteLine("Folder Already Exists!!!");
        }

        if(!File.Exists("Ecommerce\\CustomerDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("Ecommerce\\CustomerDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }

        if(!File.Exists("Ecommerce\\ProductDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("Ecommerce\\ProductDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }

        if(!File.Exists("Ecommerce\\OrderDetails.csv")){
            System.Console.WriteLine("Creating Files...");
            File.Create("Ecommerce\\OrderDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }
    }

    public static void ReadFile(){
        string[] productDetails = File.ReadAllLines("Ecommerce\\ProductDetails.csv");
        foreach(string product in productDetails){
            ProductDetails product1 = new ProductDetails(product);
            ProductDetails.productsList.Add(product1);
        }

        string[] orderDetails = File.ReadAllLines("Ecommerce\\OrderDetails.csv");
        foreach(string order in orderDetails){
            OrderDetails order1 = new OrderDetails(order);
            OrderDetails.ordersList.Add(order1);
        }

        string[] customerDetails = File.ReadAllLines("Ecommerce\\CustomerDetails.csv");
        foreach(string customer in customerDetails){
            CustomerDetails customer1 = new CustomerDetails(customer);
            Registration.customersList.Add(customer1);
        }

    }

    public static void WriteFile(){
        string[] customerDetails = new string[Registration.customersList.Count];
        for(int iterator = 0; iterator < Registration.customersList.Count;iterator++){
            customerDetails[iterator] = Registration.customersList[iterator].CustomerID+","+Registration.customersList[iterator].CustomerName+","+Registration.customersList[iterator].City+","+Registration.customersList[iterator].PhoneNumber+","+Registration.customersList[iterator].MailID+","+Registration.customersList[iterator].WalletBalance;
        }
        File.WriteAllLines("Ecommerce\\CustomerDetails.csv",customerDetails);

        string[] productDetails = new string[ProductDetails.productsList.Count];
        for(int iterator = 0;iterator < ProductDetails.productsList.Count;iterator++){
            productDetails[iterator] = ProductDetails.productsList[iterator].ProductID+","+ProductDetails.productsList[iterator].ProductName+","+ProductDetails.productsList[iterator].Price+","+ProductDetails.productsList[iterator].Stock+","+ProductDetails.productsList[iterator].ShippingDuration;
        }
        File.WriteAllLines("Ecommerce\\ProductDetails.csv",productDetails);

        string[] orderDetails = new string[OrderDetails.ordersList.Count];
        for(int iterator = 0; iterator < OrderDetails.ordersList.Count;iterator++){
            orderDetails[iterator] = OrderDetails.ordersList[iterator].OrderID+","+OrderDetails.ordersList[iterator].CustomerID+","+OrderDetails.ordersList[iterator].ProductID+","+OrderDetails.ordersList[iterator].TotalPrice+","+OrderDetails.ordersList[iterator].PurchaseDate.ToString("dd/MM/yyyy")+","+OrderDetails.ordersList[iterator].Quantity+","+OrderDetails.ordersList[iterator].OrderStatus;
        }
        File.WriteAllLines("Ecommerce\\OrderDetails.csv",orderDetails);

    }
}