using System;
namespace CollegeAdmission;
public class LoginClass
{
    public static void Login(){
        bool  flag = true;
        int choice = 0;
        System.Console.WriteLine("******LOGIN FORM******");
        System.Console.Write("Enter the Student ID : ");
        string studentID = Console.ReadLine();
        foreach(StudentDetails students in RegisterClass.studentsList){
            flag = true;
            if(students.StudentID == studentID.ToUpper()){
                System.Console.WriteLine("Login Successfully!\n");
                flag = false;
                do{
                    System.Console.WriteLine("******SUB MENU******");
                    System.Console.WriteLine("Select the choice \n1.Check Eligibility\n2.Show Details\n3.Update Details\n4.Take Admission\n5.Cancel Admission\n6.Show Admission Details\n7.Log out");
                    choice = int.Parse(Console.ReadLine());
                    MenuClass.SubMenu(choice, students);
                }while(choice!=7);
                break;
            }
            else{
                flag = true;
            }
        }
        if(flag){
                System.Console.WriteLine("Invalid Student ID");
            }
    }


    public static void AdminLogin(){
        System.Console.WriteLine("*****ADMIN LOGIN PAGE******");
        int choice = 0;
        bool departmentCheck = true;
        System.Console.Write("Enter the Admin ID : ");
        string adminId = Console.ReadLine();
        System.Console.WriteLine("Enter the password : ");
        string passWord = Console.ReadLine();
        if(adminId == "CollegeAdmin123" && passWord == "Admit@123"){
            System.Console.WriteLine("Login Successfull!!!");
            do{
                System.Console.WriteLine("Enter the choice :\n1.Add Department\n2.Add Department Seats\n3.Show Departments\n4.Logout");
                choice = int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        System.Console.Write("Enter the department name to be added : ");
                        string department = Console.ReadLine().ToUpper();
                        System.Console.Write("Enter the number of seats to be allocated : ");
                        int count = int.Parse(Console.ReadLine());
                        DepartmentDetails department1 = new DepartmentDetails(department,count);
                        DepartmentDetails.departmentsList.Add(department1);
                        break;
                    }
                    case 2:{
                        DepartmentDetails.ShowDepartments();
                        System.Console.Write("Enter the Department Id : ");
                        string departmentId = Console.ReadLine().ToUpper();
                        foreach(DepartmentDetails department in DepartmentDetails.departmentsList){
                            if(department.DepartmentID == departmentId){
                                System.Console.Write("Enter the number of seats to be extended : ");
                                int count = int.Parse(Console.ReadLine());
                                department.NoOfSeats += count;
                                departmentCheck = true;
                                break;
                            }
                            else{
                                departmentCheck = false;
                            }
                        }
                        if(!departmentCheck){
                            System.Console.WriteLine("Department not found!!!");
                        }
                        break;
                    }
                    case 3:{
                        DepartmentDetails.ShowDepartments();
                        break;
                    }
                    case 4:{
                        break;
                    }
                    default:{
                        System.Console.WriteLine("Invalid Choice\nEnter again : ");
                        break;
                    }
                }
            }while(choice != 4);
        }
        else{
            System.Console.WriteLine("Login Unsuccessfull!!!\nIncorrect Username or Password!!!\nEnter again...");
        }
    }

}