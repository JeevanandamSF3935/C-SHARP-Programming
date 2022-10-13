namespace HieraricalInheritance;
public enum Department
{
    Default,EEE,ECE,CSE,CIVIL,MECH
}
public class StudentDetails:PersonalDetails
{
    private static int s_studentID = 100;
    public string StudentID { get; }
    public Department StudentDepartment{ get; set; }
    public string Year { get; set; }
    public StudentDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base(aid,name,fatherName,gender,phoneNumber){
        s_studentID++;
        StudentID = "SID" + s_studentID;
        StudentDepartment = department;
        Year = year;
    }

    public void ShowStudent(){
        System.Console.WriteLine("*******STUDENT DETAILS******");
        System.Console.WriteLine($"StudentId \t: {StudentID}");
        ShowDetails();
        System.Console.WriteLine($"Department \t: {StudentDepartment}");
        System.Console.WriteLine($"Year \t\t: {Year}");
    }
}