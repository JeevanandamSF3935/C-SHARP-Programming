namespace EmployeePayroll
{
    public class MainMenu
    {
        public static void MenuList(){
            System.Console.WriteLine("Select the option :\n1. Registration\n2. Login\n3. Exit");
            int choice = int.Parse(Console.ReadLine());
            do{
                switch(choice){
                    case 1:{
                        System.Console.WriteLine("Registration");
                        Register.RegisterEmployee();
                        break;
                    }
                    case 2:{
                        System.Console.WriteLine("Login");
                        Login.LoginEmployee();
                        break;
                    }
                    case 3:{
                        System.Console.WriteLine("Exit");
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Invalid choice");
                        break;
                    }
                }
                System.Console.WriteLine("Select the option :\n1. Registration\n2. Login\n3. Exit");
                choice = int.Parse(Console.ReadLine());
            }while(choice!=3);
        }
    }
}