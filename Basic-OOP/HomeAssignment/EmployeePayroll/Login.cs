using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public class Login
    {
        static EmployeePayment employee = new EmployeePayment();
        public static void LoginEmployee(){
            System.Console.Write("Enter your EmployeeID : ");
            string employeeID = Console.ReadLine();
            foreach(EmployeePayment employees in Register.employeeList){
                if(employees.EmployeeID == employeeID){
                    System.Console.WriteLine("Login Successfully!");
                    employee = employees;
                    SubMenu();
                }
                else{
                    System.Console.WriteLine("Wrong Password");
                    LoginEmployee();
                }
            }
        }

        public static void SubMenu(){
            int choice = 0;
            do{
                System.Console.WriteLine("Select option\n1. Show Details\n2. Worked Days\n3. Calculate Payment\n4. Exit SubMenu");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        System.Console.WriteLine("Details :");
                        employee.ShowDetails();
                        break;
                    }
                    case 2:{
                        System.Console.WriteLine("Worked Days :");
                        employee.DaysWorked();
                        break;
                    }
                    case 3:{
                        System.Console.WriteLine("Calculate Payment");
                        employee.CalculateSalary();
                        break;
                    }
                    case 4:{
                        System.Console.WriteLine("Exit Submenu");
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