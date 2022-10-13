using System;
namespace CollegeAdmission
{
    public static class Login
    {
        static StudentsDetails students = new StudentsDetails();
        public static void LoginStudent(){
            int i = 0;
            System.Console.Write("Enter your register number : ");
            long register = long.Parse(Console.ReadLine());
            if(Register.studentDictionary.LinearSearch(register,out i)){
                System.Console.WriteLine("Login Successfull");
                SubMenu(Register.studentDictionary.ElementAt(i));
            }        
        }

        public static void SubMenu(KeyValue<long,StudentsDetails> student){
            int choice = 0;
            do{
                System.Console.WriteLine("Select option\n1. Show Details\n2. Check Eligibility\n3. Exit SubMenu");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        System.Console.WriteLine("Details :");
                        student.Value.ShowDetails();
                        break;
                    }
                    case 2:{
                        System.Console.WriteLine("Checking Eligibility...");
                        bool temp = student.Value.EligibilityCheck(75);
                        if(temp){
                            System.Console.WriteLine("Eligible!");
                        }
                        else{
                            System.Console.WriteLine("Not Eligible!");
                        }
                        break;
                    }
                    case 3:{
                        System.Console.WriteLine("Exit");
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Invalid choice!\nEnter again");
                        break;
                    }
                }
            }while(choice!=3);
        }
    }
}