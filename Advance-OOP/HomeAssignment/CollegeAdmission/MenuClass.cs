using System;
namespace CollegeAdmission;
public static class MenuClass
{
    public static void Menu(){
        int choice = 0;
        do{
            System.Console.WriteLine("**************************COLLEGE OF ENGINEEING**************************");
            System.Console.WriteLine("******Main Menu******");
            System.Console.WriteLine("Select your choice\n1. Student Registrartion\n2. Student Login\n3. Check Department wise seat availability\n4. Admin Login\n5. Exit");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    RegisterClass.Register();
                    break;
                }
                case 2:{
                    LoginClass.Login();
                    break;
                }
                case 3:{
                    DepartmentDetails.ShowDepartments();
                    break;
                }
                case 4:{
                    LoginClass.AdminLogin();
                    break;
                }
                case 5:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid Choice\nEnter again : ");
                    break;
                }
            }
        }while(choice!=5);
    }

    public static void SubMenu(int choice, StudentDetails students){
        switch(choice){
            case 1:{
                bool temp = students.CheckEligibility();
                break;
            }
            case 2:{
                students.ShowDetails();
                break;
            }
            case 3:{
                RegisterClass.Update(students);
                break;
            }
            case 4:{
                AdmissionProcess.TakeAdmission(students.StudentID);
                break;
            }
            case 5:{
                AdmissionProcess.CancelAdmission(students.StudentID);
                break;
            }
            case 6:{
                AdmissionDetails.ShowAdmission();
                break;
            }
            case 7:{
                break;
            }
        }
    }
}