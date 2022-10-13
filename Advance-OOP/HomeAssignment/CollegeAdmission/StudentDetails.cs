using System;
namespace CollegeAdmission;
public enum Gender
{
    Default,Male,Female,Transgender
}
public class StudentDetails
{
    public static int s_studentID = 1000;
    public string StudentID { get; set; }
    public string StudentName{ get; set; }
    public string FatherName { get; set; }
    public DateTime DOB { get; set; }
    public Gender StudentGender { get; set; }
    public int PhysicsMark { get; set; }
    public int ChemistryMark { get; set; }
    public int MathsMark { get; set; }
    public string HSCMarkSheet{ get; set; }
    public StudentDetails(){
        
    }
    public StudentDetails(string studentName,string fatherName,DateTime dob,Gender gender,int physicsMark,int chemistryMark,int mathsMark,string hscMarkSheet){
        s_studentID++;
        StudentID = "SF"+s_studentID;
        StudentName = studentName;
        FatherName = fatherName;
        DOB = dob;
        StudentGender = gender;
        PhysicsMark = physicsMark;
        ChemistryMark = chemistryMark;
        MathsMark = mathsMark;
        HSCMarkSheet = hscMarkSheet;
    }
    public StudentDetails(string data){
        string [] values = data.Split(',');
        s_studentID = int.Parse(values[0].Remove(0,2));
        StudentID = values[0];
        StudentName = values[1];
        FatherName = values[2];
        DOB = DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
        StudentGender = Enum.Parse<Gender>(values[4],true);
        PhysicsMark = int.Parse(values[5]);
        ChemistryMark = int.Parse(values[6]);
        MathsMark = int.Parse(values[7]);
        HSCMarkSheet = values[8];
    }

    public void UpdateDetails(string studentID,string studentName,string fatherName,DateTime dob,Gender gender,int physicsMark,int chemistryMark,int mathsMark){
        StudentID = studentID;
        StudentName = studentName;
        FatherName = fatherName;
        DOB = dob;
        StudentGender = gender;
        PhysicsMark = physicsMark;
        ChemistryMark = chemistryMark;
        MathsMark = mathsMark;
    }

    public void ShowDetails(){
        System.Console.WriteLine("******YOUR DETAILS******");
        System.Console.WriteLine("StudentID\tStudent Name\tFather Name\tDOB\t\tGender\tPhysics\tChemistry\tMaths");
        System.Console.WriteLine($"{StudentID}\t\t{StudentName}\t{FatherName}\t\t{DOB.ToString("dd/MM/yyyy")}\t{StudentGender}\t{PhysicsMark}\t{ChemistryMark}\t\t{MathsMark}\n");
    }

    public bool CheckEligibility(){
        System.Console.WriteLine("***YOUR ELIGIBILITY***");
        double average = (double)(PhysicsMark + ChemistryMark + MathsMark)/3;
        if(average >= 75.0){
            System.Console.WriteLine("Eligible for Admission\n");
            return true;
        }
        else{
            System.Console.WriteLine("Not Eligible for Admission\n");
            return false;
        }
    }

}