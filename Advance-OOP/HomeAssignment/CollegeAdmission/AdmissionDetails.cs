using System;
namespace CollegeAdmission;
public class AdmissionDetails
{

    public static int s_admissionID = 1000;
    public string AdmissionID { get; }
    public string StudentID { get; set; }
    public string DepartmentID { get; set; }
    public DateTime AdmissionDate { get; set; }
    public string AdmissionStatus { get; set; }

    public AdmissionDetails(){
        
    }
    public AdmissionDetails(string studentID,string departmentID,DateTime admissionDate,string admissionStatus){
        s_admissionID++;
        AdmissionID = "AID" + s_admissionID;
        DepartmentID = departmentID;
        StudentID = studentID;
        DepartmentID = departmentID;
        AdmissionDate = admissionDate;
        AdmissionStatus = admissionStatus;
    }

    public AdmissionDetails(string admission){
        string[] values = admission.Split(',');
        s_admissionID = int.Parse(values[0].Remove(0,3));
        AdmissionID = values[0];
        DepartmentID = values[1];
        StudentID = values[2];
        AdmissionDate = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
        AdmissionStatus = values[4];
    }

    public static void ShowAdmission(){
        System.Console.WriteLine("AdmissionID\tStudentID\tDepartmentID\tAdmission Date\tAdmission status");
        foreach(AdmissionDetails admissions in AdmissionProcess.admissionsList){
            System.Console.WriteLine($"{admissions.AdmissionID}\t\t{admissions.StudentID}\t\t{admissions.DepartmentID}\t\t{admissions.AdmissionDate.ToString("dd/MM/yyyy")}\t\t{admissions.AdmissionStatus}\n");
        }
    }

}