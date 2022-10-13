
using System.IO;
namespace CollegeAdmission;
public static class Files
{
    public static void create(){
        if(!Directory.Exists("College")){
            System.Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory("College");
        }
        else{
            System.Console.WriteLine("Folder Already Exists!!!");
        }
        if(!File.Exists("College\\StudentsDetails.csv")){
            System.Console.WriteLine("Creating File for Students Details...");
            File.Create("College\\StudentsDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }
        if(!File.Exists("College\\DepartmentDetails.csv")){
            System.Console.WriteLine("Creating File for Department Details...");
            File.Create("College\\DepartmentDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }
        if(!File.Exists("College\\AdmissionDetails.csv")){
            System.Console.WriteLine("Creating File for Admission Details...");
            File.Create("College\\AdmissionDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }
    }

    
    public static void ReadFile(){
        string [] students = File.ReadAllLines("College\\StudentsDetails.csv");
        foreach(string student1 in students){
            StudentDetails student = new StudentDetails(student1);
            RegisterClass.studentsList.Add(student);
        }

        string[] departments = File.ReadAllLines("College\\DepartmentDetails.csv");
        foreach(string department in departments){
            DepartmentDetails department1 = new DepartmentDetails(department);
            DepartmentDetails.departmentsList.Add(department1);
        }

        string[] admissions = File.ReadAllLines("College\\AdmissionDetails.csv");
        foreach(string admission in admissions){
            AdmissionDetails admission1 = new AdmissionDetails(admission);
            AdmissionProcess.admissionsList.Add(admission1);
        }
    }


    public static void WriteFile(){
        string[] studentsDetails = new string[RegisterClass.studentsList.Count];
        for(int iterator = 0;iterator<RegisterClass.studentsList.Count;iterator++){
            studentsDetails[iterator] = RegisterClass.studentsList[iterator].StudentID+","+RegisterClass.studentsList[iterator].StudentName+","+RegisterClass.studentsList[iterator].FatherName+","+RegisterClass.studentsList[iterator].DOB.ToString("dd/MM/yyyy")+","+RegisterClass.studentsList[iterator].StudentGender+","+RegisterClass.studentsList[iterator].PhysicsMark+","+RegisterClass.studentsList[iterator].ChemistryMark+","+RegisterClass.studentsList[iterator].MathsMark+","+RegisterClass.studentsList[iterator].HSCMarkSheet;
        }
        File.WriteAllLines("College\\StudentsDetails.csv",studentsDetails);


        string[] departmentDetails = new string[DepartmentDetails.departmentsList.Count];
        for(int iterator = 0;iterator < DepartmentDetails.departmentsList.Count;iterator++){
            departmentDetails[iterator] = DepartmentDetails.departmentsList[iterator].DepartmentID+","+DepartmentDetails.departmentsList[iterator].DepartmentName+","+DepartmentDetails.departmentsList[iterator].NoOfSeats;
        }
        File.WriteAllLines("College\\DepartmentDetails.csv",departmentDetails);

        string[] admissionDetails = new string[AdmissionProcess.admissionsList.Count];
        for(int iterator = 0;iterator < AdmissionProcess.admissionsList.Count;iterator++){
            admissionDetails[iterator] = AdmissionProcess.admissionsList[iterator].AdmissionID+","+AdmissionProcess.admissionsList[iterator].DepartmentID+","+AdmissionProcess.admissionsList[iterator].StudentID+","+AdmissionProcess.admissionsList[iterator].AdmissionDate.ToString("dd/MM/yyyy")+","+AdmissionProcess.admissionsList[iterator].AdmissionStatus;
        }
        File.WriteAllLines("College\\AdmissionDetails.csv",admissionDetails);
    }

}