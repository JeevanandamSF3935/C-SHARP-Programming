using System;
using System.Collections.Generic;
namespace CollegeAdmission;
public class AdmissionProcess
{
    public static List<AdmissionDetails> admissionsList = new List<AdmissionDetails>();
    public static void CancelAdmission(string studentID){
        System.Console.WriteLine("****ADMISSION CANCELLATION****");
        bool admissionNoCheck = true;
        System.Console.WriteLine("Are you sure, you want to cancel the admission ?\nYes or No");
        string choice = Console.ReadLine().ToLower();
        if(choice == "yes"){
            foreach(AdmissionDetails admissions in admissionsList){
                admissionNoCheck = true;
                if(admissions.StudentID == studentID){
                    string admissionID = admissions.AdmissionID;
                    if(admissions.AdmissionStatus.ToLower() == "booked")
                    {
                        admissions.AdmissionStatus = "Cancelled";
                        foreach(DepartmentDetails departments in DepartmentDetails.departmentsList){
                            if(admissions.DepartmentID == departments.DepartmentID){
                                departments.NoOfSeats++;
                            }
                        }
                        System.Console.WriteLine("Your admission cancelled\n");
                        break;
                    }
                    else{
                        System.Console.WriteLine("Your admission already cancelled\n");
                        break;
                    }
                }
                else{
                    admissionNoCheck = false;
                }
            }
            if(!admissionNoCheck){
                System.Console.WriteLine("You are not yet admitted\n");
            }
        }
    }

    public static void TakeAdmission(string studentID){
        bool admissionCheck = true;
        DepartmentDetails.ShowDepartments();
        System.Console.WriteLine("***ADMISSION FORM***");
        System.Console.Write("Enter the DepartmentID : ");
        string departmentID = Console.ReadLine().ToUpper();
        foreach(DepartmentDetails departments in DepartmentDetails.departmentsList){
            if(departments.DepartmentID == departmentID){
                foreach(AdmissionDetails admissions in admissionsList){
                    if(admissions.StudentID == studentID){
                        admissionCheck = false;
                        break;
                    }
                    else{
                        admissionCheck = true;
                    }
                }
                if(departments.NoOfSeats > 0){
                    if(admissionCheck){
                        bool eligibilityCheck = false;
                        foreach(StudentDetails students in RegisterClass.studentsList){
                            if(studentID == students.StudentID){
                                eligibilityCheck = students.CheckEligibility();
                            }
                        }
                        if(eligibilityCheck){
                            AddAddmission(studentID,departmentID);
                        }
                        else{
                            System.Console.WriteLine("Not eligible for admission\n");
                            break;
                        }
                    }
                    else{
                        System.Console.WriteLine("Already Admitted\n");
                    }
                }
                else{
                    System.Console.WriteLine("There is no seat in selected department\n");
                }
            }
        }
    }

    public static void AddAddmission(string studentID,string departmentID){
        string status = "Booked";
        AdmissionDetails admission = new AdmissionDetails(studentID,departmentID,DateTime.Today,status);
        admissionsList.Add(admission);
        System.Console.WriteLine("Admitted successfully for the selected department\n");
        foreach(DepartmentDetails department in DepartmentDetails.departmentsList){
            if(departmentID == department.DepartmentID){
                department.NoOfSeats--;
            }
        }
    }
}