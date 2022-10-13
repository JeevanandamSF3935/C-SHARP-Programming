using System;
namespace OnlineFoodOrder;
public class Process
{
    public static List<CustomerRegistration> customersList = new List<CustomerRegistration>();
    public static List<FoodDetails> foodsList = new List<FoodDetails>();
    public static List<OrderDetails> globalOrdersList = new List<OrderDetails>();
    public static List<BookingDetails> bookingsList = new List<BookingDetails>();
    public static void UserRegistration(){
        bool check = true;
        try{
            System.Console.WriteLine("******User Registration******");
            System.Console.Write("Enter the name : ");
            string name = Console.ReadLine();
            System.Console.Write("Enter your father name : ");
            string fatherName = Console.ReadLine();
            System.Console.Write("Enter your gender (Male or Female or Transgender): ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.Write("Enter your Mobile number : ");
            long phoneNumber = long.Parse(Console.ReadLine());
            System.Console.Write("Enter your Date of Birth : ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter your MailID : ");
            string mailId = Console.ReadLine();
            System.Console.Write("Enter your City : ");
            string city = Console.ReadLine();
            CustomerRegistration customer = new CustomerRegistration(name,fatherName,gender,phoneNumber,date,mailId,city);
            customersList.Add(customer);
            System.Console.WriteLine($"Registered Successfully\nYour CustomerId is {customer.CustomerId}");
            check = true;
        }
        catch(Exception e){
            check = false;
            System.Console.WriteLine(e.Message);
        }
        finally{
            if(!check){
                System.Console.WriteLine();
                System.Console.WriteLine("Enter the Details Again in correct value....");
                UserRegistration();
            }
        }

    }

    public static void UserLogin(){
        bool check = true;
        try{
            bool loginCheck = false;
            System.Console.WriteLine("******User Login******");
            System.Console.Write("Enter your CustomerID : ");
            string customerId = Console.ReadLine().ToUpper();
            foreach(CustomerRegistration customer in customersList){
                if(customer.CustomerId == customerId){
                    System.Console.WriteLine("Login Successfull!");
                    MenuClass.SubMenu(customer);
                    loginCheck = true;
                    break;
                }
                else{
                    loginCheck = false;
                }
            }
            if(!loginCheck){
                System.Console.WriteLine("Login Unsuccessfull!!!");
            }
        }
        catch(Exception e){
            System.Console.WriteLine(e.Message);
        }
        finally{
            if(!check){
                MenuClass.MainMenu();
            }
        }
    }

    public static void OrderFood(CustomerRegistration customer){
        string choice = "";
        bool check = true;
        BookingDetails booking = null;
        List<OrderDetails> ordersList = new List<OrderDetails>();
        double totalPrice = 0,orderPrice = 0;
        try{
            System.Console.WriteLine("Do you want to purchase (Yes or No)?");
            choice = Console.ReadLine().ToLower();
            if(choice == "yes"){
                booking = new BookingDetails(customer.CustomerId,totalPrice,DateTime.Now,BookingStatus.Initiated);
            }
            while(choice == "yes"){
                FoodDetails.ShowDetails();
                System.Console.Write("Enter the Food ID you want to order : ");
                string foodId = Console.ReadLine().ToUpper();
                System.Console.Write("Enter the quantity you need to order : ");
                int quantity = int.Parse(Console.ReadLine());
                foreach(FoodDetails food in foodsList){
                    if(food.FoodID == foodId){
                        orderPrice = food.PricePerQuantity * quantity;
                        if(customer.WalletBalance >= orderPrice){
                            OrderDetails order = new OrderDetails(booking.BookingID,foodId,quantity,orderPrice);
                            ordersList.Add(order);
                            totalPrice += orderPrice;
                        }
                        else{
                            while(customer.WalletBalance <= orderPrice){
                                System.Console.WriteLine($"You are having insufficcient balance : Rs.{customer.WalletBalance}\nRecahrge your Wallet");
                                customer.WalletRecharge();
                            }
                            OrderDetails order = new OrderDetails(booking.BookingID,foodId,quantity,orderPrice);
                            ordersList.Add(order);
                            totalPrice += orderPrice;
                        }
                        break;
                    }
                }
                System.Console.WriteLine("Do you want to purchase another food (Yes or No)?");
                choice = Console.ReadLine().ToLower();
            }
            
            System.Console.WriteLine("Do you want to purchase (Yes or No) ?");
            string purchaseChoice = Console.ReadLine().ToLower();
            if(purchaseChoice == "yes"){
                if(totalPrice <= customer.WalletBalance){
                    booking.TotalPrice = totalPrice;
                    customer.WalletBalance -= totalPrice;
                    booking.Status = BookingStatus.Booked;
                    globalOrdersList.AddRange(ordersList);
                    bookingsList.Add(booking);
                    System.Console.WriteLine($"Booking Successfull and Booking Id : {booking.BookingID}");
                }
                else{
                    while(customer.WalletBalance <= totalPrice){
                        System.Console.WriteLine($"You are having insufficcient balance : Rs.{customer.WalletBalance}\nRecahrge your Wallet");
                        customer.WalletRecharge();
                    }
                    booking.TotalPrice = totalPrice;
                    customer.WalletBalance -= totalPrice;
                    booking.Status = BookingStatus.Booked;
                    globalOrdersList.AddRange(ordersList);
                    bookingsList.Add(booking);
                    System.Console.WriteLine($"Booking Successfull and Booking Id : {booking.BookingID}");
                }
            }
            check = true;
        }
        catch(Exception e){
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine();
            check = false;
        }
        finally{
            if(!check){
                MenuClass.SubMenu(customer);
            }
        }
    }

    public static void CancelOrder(CustomerRegistration customer){
        bool orderCheck = true, check = true;
        try{
            System.Console.WriteLine("Booking ID\tCustomer ID\tTotal Price\tDate of Booking\tStatus");
            foreach(BookingDetails booking in bookingsList){
                if(booking.CustomerID == customer.CustomerId && booking.Status.Equals(BookingStatus.Booked)){
                    System.Console.WriteLine($"{booking.BookingID}\t\t{booking.CustomerID}\t\t{booking.TotalPrice}\t\t{booking.DateOfBooking.ToString("dd/MM/yyyy")}\t{booking.Status}");
                }
            }
            System.Console.Write("Enter the Booking Id : ");
            string bookingId = Console.ReadLine().ToUpper();
            System.Console.WriteLine("OrderId\tBooking ID\tFood ID\tPurchase Count\tPrice of Order");
            foreach(OrderDetails order in globalOrdersList){
                if(order.BookingID == bookingId){
                    System.Console.WriteLine($"{order.OrderID}\t\t{order.BookingID}\t\t{order.FoodID}\t\t{order.PurchaseCount}\t\t{order.PriceOfOrder}");
                }
            }
            System.Console.Write("Enter the Order Id want to cancel : ");
            string orderId = Console.ReadLine().ToUpper();
            foreach(OrderDetails order in globalOrdersList){
                if(order.OrderID == orderId){
                    order.PurchaseCount = 0;
                    foreach(BookingDetails booking in bookingsList){
                        if(bookingId == booking.BookingID){
                            booking.TotalPrice -= order.PriceOfOrder;
                            break;
                        }
                    }
                    customer.WalletBalance += order.PriceOfOrder;
                    order.PriceOfOrder = 0;
                    orderCheck = true;
                    System.Console.WriteLine("Your Order cancelled successfully");
                    break;
                }
                else{
                    orderCheck = false;
                }
            }
            if(!orderCheck){
                System.Console.WriteLine("Invalid Order ID");
            }
            check = true;
        }
        catch(Exception e){
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine();
            check = false;
        }
        finally{
            if(!check){
                MenuClass.SubMenu(customer);
            }
        }
    }

    public static void CancelBooking(CustomerRegistration customer){
        bool check = true,bookingCheck = true;
        try{
            System.Console.WriteLine("Booking ID\tCustomer ID\tTotal Price\tDate of Booking\tStatus");
            foreach(BookingDetails booking in bookingsList){
                if(booking.CustomerID == customer.CustomerId && booking.Status.Equals(BookingStatus.Booked)){
                    System.Console.WriteLine($"{booking.BookingID}\t\t{booking.CustomerID}\t\t{booking.TotalPrice}\t\t{booking.DateOfBooking.ToString("dd/MM/yyyy")}\t{booking.Status}");
                }
            }
            System.Console.Write("Enter Booking Id You want to cancel : ");
            string bookingId = Console.ReadLine().ToUpper();
            foreach(BookingDetails booking in bookingsList){
                if(booking.BookingID == bookingId){
                    booking.Status = BookingStatus.cancelled;
                    customer.WalletBalance += booking.TotalPrice;
                    bookingCheck = true;
                    System.Console.WriteLine("Your Booking Cancelled Successfully");
                    break;
                }
                else{
                    bookingCheck = false;
                }
            }
            if(!bookingCheck){
                System.Console.WriteLine("Your Booking not Cancelled\nInvalid Boooking Id");
            }
            check = true;
        }catch(Exception e){
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine();
            check = false;
        }
        finally{
            if(!check){
                MenuClass.SubMenu(customer);
            }
        }
    }

    public static void OrderHistory(CustomerRegistration customer){
        bool check = true,orderCheck=true;
        try{
            System.Console.WriteLine("\tORDER HISTORY");
            System.Console.WriteLine("Order ID\tBooking ID\tFood ID\tTotal Quantity\tTotal Price");
            foreach(BookingDetails booking in bookingsList){
                if(booking.CustomerID == customer.CustomerId){
                    foreach(OrderDetails order in globalOrdersList){
                        if(booking.BookingID == order.BookingID){
                            System.Console.WriteLine($"{order.OrderID}\t\t{order.BookingID}\t\t{order.FoodID}\t\t{order.PurchaseCount}\t\t{order.PriceOfOrder}");
                        }
                    }
                    orderCheck = true;
                }
                else{
                    orderCheck = false;
                }
            }
            if(!orderCheck){
                System.Console.WriteLine("Invalid Order ID");
            }
            check = true;
        }
        catch(Exception e){
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine();
            check = false;
        }
        finally{
            if(!check){
                MenuClass.SubMenu(customer);
            }
        }
    }

}