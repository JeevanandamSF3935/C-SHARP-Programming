using System;

namespace OnlineGrocery;
public class Operations
{
    public static List<CustomerRegistration> customersList = new List<CustomerRegistration>();
    public static List<ProductDetails> productsList = new List<ProductDetails>();
    public static List<BookingDetails> bookingsList = new List<BookingDetails>();
    public static List<OrderDetails> ordersList = new List<OrderDetails>();
    
    static CustomerRegistration currentLoggedInCustomer = null;
    
    public static void MainMenu(){
        string choice = "yes";
        do{
            System.Console.WriteLine("******Main Menu******");
            System.Console.WriteLine("1.User Registration\n2.User Login\n3.Exit");
            int choice1 = int.Parse(Console.ReadLine());
            switch(choice1){
                case 1:{
                    CustomerRegistration();
                    break;
                }
                case 2:{
                    CustomerLogin();
                    break;
                }
                case 3:{
                    System.Console.WriteLine("Exiting Main Menu...");
                    choice = "no";
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid Choice\n");
                    break;
                }
            }
        }while(choice == "yes");
    }

    public static void CustomerRegistration(){
        System.Console.Write("Enter the Name : ");
        string name = Console.ReadLine();
        System.Console.Write("Enter Father Name : ");
        string fatherName = Console.ReadLine();
        System.Console.Write("Enter your Gender (Male or Female or Transgender): ");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.Write("Enter your Mobile number : ");
        long phoneNumber = long.Parse(Console.ReadLine());
        System.Console.Write("Enter Date of Birth : ");
        DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        System.Console.Write("Enter your MailID : ");
        string mailId = Console.ReadLine();
        
        CustomerRegistration customer = new CustomerRegistration(name,fatherName,gender,phoneNumber,dateOfBirth,mailId);
        customersList.Add(customer);
        System.Console.WriteLine($"Registered successfully\nCustomer ID : {customer.CustomerID}");
    }

    public static void CustomerLogin(){
        bool check = false;
        System.Console.Write("Enter the Customer ID : ");
        string customerId = Console.ReadLine().ToUpper();
        foreach(CustomerRegistration customer in customersList){
            if(customer.CustomerID.Equals(customerId)){
                System.Console.WriteLine("Login Successfull");
                currentLoggedInCustomer = customer;
                check = true;
                SubMenu();
            }
        }
        if(!check){
            System.Console.WriteLine("Invalid Customer ID");
        }
    }

    public static void SubMenu(){
        string choice1 = "yes";
        do{
            int choice = 0;
            System.Console.WriteLine("\n******SUB MENU******");
            System.Console.WriteLine("1.Show Person Details\n2.Show Products Details\n3.Wallet recharge\n4.Take Order\n5.Cancel Order\n6.Log Out");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    System.Console.WriteLine("Customer ID\tName\t\tFather Name\tGender\t\tMobile Number\tDate Of Birth\t\tMailID\t\tWallet Balance");
                    System.Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------");
                    currentLoggedInCustomer.ShowDetails();
                    break;
                }
                case 2:{
                    ShowProductsDetails();
                    break;
                }
                case 3:{
                    currentLoggedInCustomer.WalletRecharge();
                    break;
                }
                case 4:{
                    TakeOrder();
                    break;
                }
                case 5:{
                    CancelOrder();
                    break;
                }
                case 6:{
                    System.Console.WriteLine("Loging Out");
                    choice1 = "no";
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid Choice!");
                    break;
                }
            }
        }while(choice1 == "yes");
    }

    /*public static void AddDefaultDatas(){
        //Customer Details Data
        CustomerRegistration customer1 = new CustomerRegistration("Ravi","Ettapparajan",Gender.Male,974774646,new DateTime(1999,11,11),"ravi@gamil.com");
        CustomerRegistration customer2 = new CustomerRegistration("Baskaran","Sethurajan",Gender.Male,847575775,new DateTime(1999,11,11),"baskaran@gamil.com");
        customersList.Add(customer1);
        customersList.Add(customer2);

        //Product Details Data
        ProductDetails product1 = new ProductDetails("Sugar",20,40);
        ProductDetails product2 = new ProductDetails("Rice",100,50);
        ProductDetails product3 = new ProductDetails("Milk",10,40);
        ProductDetails product4 = new ProductDetails("Coffee",10,10);
        ProductDetails product5 = new ProductDetails("Tea",10,10);
        ProductDetails product6 = new ProductDetails("Masala Powder",10,20);
        ProductDetails product7 = new ProductDetails("Salt",10,10);
        ProductDetails product8 = new ProductDetails("Turmeric Powder",10,25);
        ProductDetails product9 = new ProductDetails("Chilli Powder",10,20);
        ProductDetails product10 = new ProductDetails("Groundnut Oil",10,140);
        productsList.Add(product1);
        productsList.Add(product2);
        productsList.Add(product3);
        productsList.Add(product4);
        productsList.Add(product5);
        productsList.Add(product6);
        productsList.Add(product7);
        productsList.Add(product8);
        productsList.Add(product9);
        productsList.Add(product10);
        
        //Booking Details Data        
        BookingDetails booking1 = new BookingDetails("CID3001",220,new DateTime(2022,07,26),BookingStatus.Booked);
        BookingDetails booking2 = new BookingDetails("CID3002",400,new DateTime(2022,07,26),BookingStatus.Booked);
        BookingDetails booking3 = new BookingDetails("CID3001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
        BookingDetails booking4 = new BookingDetails("CID3002",0,new DateTime(2022,07,26),BookingStatus.Initiated);
        bookingsList.Add(booking1);
        bookingsList.Add(booking2);
        bookingsList.Add(booking3);
        bookingsList.Add(booking4);

        //Order Details Data
        OrderDetails order1 = new OrderDetails("BID3001","PID101",2,80);
        OrderDetails order2 = new OrderDetails("BID3001","PID102",2,100);
        OrderDetails order3 = new OrderDetails("BID3001","PID103",1,40);
        OrderDetails order4 = new OrderDetails("BID3002","PID101",1,40);
        OrderDetails order5 = new OrderDetails("BID3002","PID102",4,200);
        OrderDetails order6 = new OrderDetails("BID3002","PID110",1,140);
        OrderDetails order7 = new OrderDetails("BID3002","PID109",1,20);
        OrderDetails order8 = new OrderDetails("BID3003","PID102",2,100);
        OrderDetails order9 = new OrderDetails("BID3003","PID108",4,100);
        OrderDetails order10 = new OrderDetails("BID3003","PID101",2,80);
        ordersList.Add(order1);
        ordersList.Add(order2);
        ordersList.Add(order3);
        ordersList.Add(order4);
        ordersList.Add(order5);
        ordersList.Add(order6);
        ordersList.Add(order7);
        ordersList.Add(order8);
        ordersList.Add(order9);
        ordersList.Add(order10);
    }*/

    public static void ShowProductsDetails(){
        System.Console.WriteLine("\t\t\t******PRODUCT DETAILS******");
        System.Console.WriteLine();
        System.Console.WriteLine("ProductID\tProduct Name\t\tQuantity Available\tPrice Per Quantity");
        foreach(ProductDetails product in productsList){
            product.ShowProducts();
        }
    }

    public static void TakeOrder(){
        
        List<OrderDetails> tempOrdersList = new List<OrderDetails>();
        double totalPrice = 0,orderPrice = 0;
        int quantity = 0;
        bool productCheck = true;
        string choice = "yes";

        BookingDetails booking = new BookingDetails(currentLoggedInCustomer.CustomerID,totalPrice,DateTime.Now,BookingStatus.Initiated);
        
        do
        {
            ShowProductsDetails();
            System.Console.Write("\nSelect the product from above list and enter the product id : ");
            string productId = Console.ReadLine().ToUpper();
            foreach(ProductDetails product in productsList){
                if(product.ProductID.Equals(productId)){
                    System.Console.Write("\nEnter the quantity of the product you want : ");
                    quantity = int.Parse(Console.ReadLine());
                    if(quantity <= product.QuantityAvailable){
                        orderPrice = quantity * product.PricePerQuantity;
                        product.QuantityAvailable -= quantity;
                        OrderDetails order = new OrderDetails(booking.BookingID,productId,quantity,orderPrice);
                        tempOrdersList.Add(order);
                        System.Console.WriteLine($"\nSelected product -- {product.ProductName} of quantity -- {quantity} has been added to your cart successfully\n");
                    }
                    else{
                        System.Console.WriteLine("\nOut Of Stock!!!");
                    }
                    productCheck = true;
                    break;
                }
                else{
                    productCheck = false;
                }
            }
            if(!productCheck){System.Console.WriteLine("\nInvalid Product ID");}
            System.Console.WriteLine("\nDo you want order another product (yes or no)?");
            choice = Console.ReadLine().ToLower();
        } while (choice == "yes");
        foreach(OrderDetails order1 in tempOrdersList){
            totalPrice += order1.PriceOfOrder;
        }
        System.Console.WriteLine("Do you want to confirm the purchase ?");
        string confirmChoice = Console.ReadLine().ToLower();
        if(confirmChoice == "yes"){
            if(totalPrice >= currentLoggedInCustomer.WalletBalance){
                while(totalPrice > currentLoggedInCustomer.WalletBalance){
                    System.Console.WriteLine($"You have insufficient balance\nYou need Rs.{totalPrice-currentLoggedInCustomer.WalletBalance} to place your order");
                    currentLoggedInCustomer.WalletRecharge();
                }
            }
            currentLoggedInCustomer.WalletBalance -= totalPrice;
            booking.TotalPrice = totalPrice;
            booking.StatusOfBooking = BookingStatus.Booked;
            ordersList.AddRange(tempOrdersList);
            bookingsList.Add(booking);
            System.Console.WriteLine($"Your order placed successfully\nBooking ID : {booking.BookingID}");
        }
        else{
           System.Console.WriteLine("Your order cart deleted successfully");
           foreach(OrderDetails order in tempOrdersList){
                foreach(ProductDetails product in productsList){
                    if(product.ProductID.Equals(order.ProductID)){
                        product.QuantityAvailable += order.PurchaseCount;
                    }
                }
           }
        }
    }

    public static void CancelOrder(){
        bool bookingCheck = true;
        System.Console.WriteLine("\t\t\t******BOOKING DETAILS******");
        System.Console.WriteLine();
        System.Console.WriteLine("Booking ID\tCustomer ID\tTotal Price\tBooking Date\tBooking Status");
        foreach(BookingDetails booking in bookingsList){
            if(currentLoggedInCustomer.CustomerID.Equals(booking.CustomerID) && booking.StatusOfBooking.Equals(BookingStatus.Booked)){
                booking.ShowBookings();
            }
        }
        System.Console.Write("Select the Booking Id that you want to cancel : ");
        string bookingId = Console.ReadLine().ToUpper();
        foreach(BookingDetails booking in bookingsList){
            if(booking.BookingID.Equals(bookingId)){
                booking.StatusOfBooking = BookingStatus.Cancelled;
                currentLoggedInCustomer.WalletBalance += booking.TotalPrice;
                foreach(OrderDetails order in ordersList){
                    foreach(ProductDetails product in productsList){
                        if(product.ProductID.Equals(order.ProductID)){
                            product.QuantityAvailable += order.PurchaseCount;
                        }
                    }
                }
                System.Console.WriteLine("Your booking has been cancelled successfully");
            }
            else{
                bookingCheck = false;
            }
        }
        if(!bookingCheck){System.Console.WriteLine("Invalid Booking ID");}
    }

}