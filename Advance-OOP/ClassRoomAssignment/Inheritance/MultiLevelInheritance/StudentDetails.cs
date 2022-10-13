namespace MultiLevelInheritance;
public enum Department
{
    Default,EEE,ECE,CSE,CIVIL,MECH
}
public class StudentDetails:PersonalDetails,IMarkDetails
{
    private static int s_studentID = 100;
    public string StudentID { get; }
    public Department StudentDepartment{ get; set; }
    public string Year { get; set; }
    public double Physics { get; set; }
    public double Chemistry { get; set; }
    public double Maths { get; set; }
    public double Total { get; set; }
    public double Average { get; set; }
    public double Percentage{ get; set; }

    public void Calculate(){
        Total = Physics + Chemistry + Maths;
        Average = Total/3;
    }

    public void GetMark(double physics,double chemistry,double maths){
        Physics = physics;
        Chemistry = chemistry;
        Maths = maths;
    }
    public StudentDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department,string year):base(aid,name,fatherName,gender,phoneNumber){
        s_studentID++;
        StudentID = "SID" + s_studentID;
        StudentDepartment = department;
        Year = year;
    }

    public StudentDetails(string sid,string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department):base(aid,name,fatherName,gender,phoneNumber){
        StudentID = sid;
        StudentDepartment = department;
    }

    public void Show(){
        System.Console.WriteLine($"Physics Mark \t: {Physics}");
        System.Console.WriteLine($"Chemistry Mark \t: {Chemistry}");
        System.Console.WriteLine($"Maths Mark \t: {Maths}");
        System.Console.WriteLine($"Total Mark \t: {Total}");
        System.Console.WriteLine($"Average \t: {Average.ToString("0.00")}");
    }
    public void ShowStudent(){
        //System.Console.WriteLine("*******STUDENT DETAILS******");
        System.Console.WriteLine($"StudentId \t: {StudentID}");
        ShowDetails();
        System.Console.WriteLine($"Department \t: {StudentDepartment}");
        //System.Console.WriteLine($"Year \t\t: {Year}");
    }
}