namespace ECommerce;
public class PurchaseClass
{
    public static void Purchase(CustomerDetails customer){
        ProductDetails.ShowProducts();
        bool productCheck = true;
        int purchaseCount = 0,purchasePrice = 0;
        System.Console.Write("Enter the ProductID want to purchase : ");
        string productId = Console.ReadLine();
        foreach(ProductDetails product in ProductDetails.productsList){
            if(productId == product.ProductID){
                System.Console.Write("Enter the count of product you wish to buy : ");
                purchaseCount = int.Parse(Console.ReadLine());
                if(purchaseCount <= product.Stock){
                    purchasePrice = (product.Price * purchaseCount) + 50;
                    if(customer.WalletBalance >= purchasePrice){
                        customer.WalletBalance -= purchasePrice;
                        product.Stock -= purchaseCount;
                        System.Console.Write("Order Placed successfully\n");
                        OrderDetails order = new OrderDetails(customer.CustomerID,productId,purchasePrice,DateTime.Now,purchaseCount,"Ordered");
                        OrderDetails.ordersList.Add(order);
                        System.Console.WriteLine($"OrderID : {order.OrderID}");
                    }
                    else{
                        System.Console.WriteLine($"Insuffictient balance in wallent\nYour balance is {customer.WalletBalance}");
                    }
                }
                else{
                    System.Console.WriteLine($"Required count not available\nCurrent Availability is {product.Stock}");
                }
                break;
            }
            else{
                productCheck = false;
            }
        }
        if(!productCheck){
            System.Console.WriteLine("ProductID not available");
        }
    }

    public static void OrderHistory(CustomerDetails customer){
        System.Console.WriteLine("OrderID\t\tProductID\tTotal Price\tPurchase Date\t\tQuantity\tOrderStatus");
        foreach(OrderDetails order in OrderDetails.ordersList){
            if(order.CustomerID == customer.CustomerID){
                System.Console.WriteLine($"{order.OrderID}\t\t{order.ProductID}\t\t{order.TotalPrice}\t\t{order.PurchaseDate.ToString("dd/MM/yyyy")}\t\t{order.Quantity}\t\t{order.OrderStatus}");
            }
        }
    }

    public static void CancelOrder(CustomerDetails customer){
        bool orderCheck = true;
        foreach(OrderDetails order in OrderDetails.ordersList){
            orderCheck = true;
            if(order.CustomerID == customer.CustomerID){
                order.OrderStatus = "Cancelled";
                customer.WalletBalance += (order.TotalPrice - 50);
                foreach(ProductDetails product in ProductDetails.productsList){
                    if(product.ProductID == order.ProductID){
                        product.Stock += order.Quantity;
                        System.Console.WriteLine("Order cancelled successfully");
                        break;
                    }
                }
                break;
            }
            else{
                orderCheck = false;
            }
        }
        if(!orderCheck){
            System.Console.WriteLine("You didn't purchased yet!");
        }
    }

    public static void WalletBalanceCheck(CustomerDetails customer){
        System.Console.WriteLine($"Your wallet balance : {customer.WalletBalance}");
        System.Console.WriteLine("Do you want to add balance to your wallet ?");
        string choice = Console.ReadLine().ToLower();
        if(choice == "yes"){
            System.Console.Write("Enter the amount to be added : ");
            int amount = int.Parse(Console.ReadLine());
            customer.WalletBalance += amount;
            System.Console.WriteLine($"Updated wallet balance : {customer.WalletBalance}");
        }
    }

}