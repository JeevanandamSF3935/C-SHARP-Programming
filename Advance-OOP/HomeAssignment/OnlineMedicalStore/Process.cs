using System;
namespace OnlineMedicalStore;
public class Process
{
    public static List<UserDetails> usersList = new List<UserDetails>(); 
    public static List<MedicineDetails> medicinesList = new List<MedicineDetails>();
    public static List<OrderDetails> ordersList = new List<OrderDetails>();

    public static void UserRegister(){
        string choice = "";
        System.Console.WriteLine("ONLINE MEDICAL STORE");
        System.Console.WriteLine("******User Registration******");
        System.Console.Write("Enter the name : ");
        string name = Console.ReadLine();
        System.Console.Write("Enter the age : ");
        int age = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the city : ");
        string city = Console.ReadLine();
        System.Console.Write("Enter the phone Number : ");
        long phoneNumber = long.Parse(Console.ReadLine());
        UserDetails user = new UserDetails(name,age,city,phoneNumber);
        usersList.Add(user);
        System.Console.WriteLine($"User Registered Successfully!\nUser ID is {user.UserId}");
        System.Console.WriteLine($"Your wallet balance is {user.Balance}");
        System.Console.WriteLine("Do you want to Recharge : ");
        choice = Console.ReadLine().ToLower();
        if(choice == "yes"){
            user.Recharge();
        }
    }


    public static void UserLogin(){
        bool check = true;
        System.Console.Write("Enter your User ID : ");
        string userId = Console.ReadLine().ToUpper();
        foreach(UserDetails user in usersList){
            check = true;
            if(user.UserId == userId){
                System.Console.WriteLine("Login SucessFull!!!");
                MenuClass.SubMenu(user);
            }
            else{
                check = false;
            }
        }
        if(!check){
            System.Console.WriteLine("Login Unsuccessfull");
        }
    }

    public static void Purchase(UserDetails user){
        MedicineDetails.ShowMedicine();
        double price = 0;
        bool check = true;
        System.Console.Write("Enter the Medicine ID you want to purchase : ");
        string medicineId = Console.ReadLine().ToUpper();
        System.Console.Write("Enter the count of medicine you want : ");
        int count = int.Parse(Console.ReadLine());
        foreach(MedicineDetails medicine in medicinesList){
            check = true;
            if(medicine.MedicineId == medicineId){
                if(medicine.AvailableCount > 0){
                    if(medicine.ExpiryDate > DateTime.Now){
                        price = count * medicine.Price;
                        if(user.Balance >= price){
                            user.Balance -= price;
                            medicine.AvailableCount-=count;
                            OrderDetails order = new OrderDetails(user.UserId,medicine.MedicineId,count,price,DateTime.Now,OrderStatus.Purchased);
                            Process.ordersList.Add(order);
                            System.Console.WriteLine("Medicine Purchased Successfully!");
                        }
                        else{
                            System.Console.WriteLine("You have insufficient balance!!!\nRecharge your wallet");
                            user.Recharge();
                            user.Balance -= price;
                            medicine.AvailableCount-=count;
                            OrderDetails order = new OrderDetails(user.UserId,medicine.MedicineId,count,price,DateTime.Now,OrderStatus.Purchased);
                            Process.ordersList.Add(order);
                            System.Console.WriteLine("Medicine Purchased Successfully!");
                        }
                    }
                    else{
                        System.Console.WriteLine("Medicine Expired!!!");
                    }
                }
                else{
                    System.Console.WriteLine("Medicine out of stock!!!");
                }
                check = true;
                break;
            }
            else{
                check = false;
            }
        }
        if(!check){
            System.Console.WriteLine("Medicine ID not available!!!");
        }
    }

    public static void ShowPurchase(UserDetails user){
        System.Console.WriteLine("Order ID\tUser Id\tMedicineId\tMedicine Count\tTotal Price\tOrder Date\tOrder Status");
        foreach(OrderDetails order in ordersList){
            if(order.UserID == user.UserId){
                System.Console.WriteLine($"{order.OrderID}\t\t{order.UserID}\t{order.MedicineID}\t\t{order.MedicineCount}\t\t{order.Price}\t\t{order.OrderDate.ToString("dd/MM/yyyy")}\t{order.Status}");
            }
        }
    }

    public static void CancelPurchase(UserDetails user){
        System.Console.WriteLine("Order ID\tUser Id\tMedicineId\tMedicine Count\tTotal Price\tOrder Date\tOrder Status");
        foreach(OrderDetails order in ordersList){
            if(order.UserID == user.UserId && order.Status.ToString() == "Purchased"){
                System.Console.WriteLine($"{order.OrderID}\t\t{order.UserID}\t{order.MedicineID}\t\t{order.MedicineCount}\t\t{order.Price}\t\t{order.OrderDate.ToString("dd/MM/yyyy")}\t{order.Status}");
            }
        }

        System.Console.Write("Enter the Order ID : ");
        string orderId = Console.ReadLine();
        bool check = true;
        foreach(OrderDetails order in ordersList){
            check = true;
            if(orderId == order.OrderID){
                order.Status = OrderStatus.Cancelled;
                break;
            }
            else{
                check = false;
            }
        }
        if(!check){
            System.Console.WriteLine("Order Not found!!!");
        }
    }

}