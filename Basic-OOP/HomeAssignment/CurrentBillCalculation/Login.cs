
namespace CurrentBillCalculation
{
    public class Login
    {
        static BillCalculation bill = new BillCalculation();
        public static void EBLogin(){
            System.Console.Write("Enter your EB Meter ID : ");
            string ebID = Console.ReadLine();
            foreach(BillCalculation bills in Register.ebList){
                if(bills.MeterID == ebID){
                    System.Console.WriteLine("Login Successfully!");
                    bill = bills;
                    SubMenu();
                }
                else{
                    System.Console.WriteLine("Wrong Password");
                    EBLogin();
                }
            }
        }

        public static void SubMenu(){
            int choice = 0;
            do{
                System.Console.WriteLine("Select option\n1. Show Details\n2. Units Used\n3. Calculate Tariff\n4. Exit SubMenu");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        System.Console.WriteLine("Details :");
                        bill.ShowDetails();
                        break;
                    }
                    case 2:{
                        System.Console.WriteLine("Units Used :");
                        bill.UnitsMeasured();
                        break;
                    }
                    case 3:{
                        System.Console.WriteLine("Calculate Tariff :");
                        bill.CalculateBill();
                        break;
                    }
                    case 4:{
                        System.Console.WriteLine("Exit");
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Invalid choice!\nEnter again");
                        break;
                    }
                }
            }while(choice!=4);
        }
    }
}