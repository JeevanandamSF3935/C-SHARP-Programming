namespace MultiLevelInheritance;
public class EmployeeDetails:StudentDetails
{
    public static int s_employeeID = 1000;

    public string EmployeeID { get; }
    public DateTime RegisterDate { get; set; }
    public EmployeeDetails(string sid,string aid,string name,string fatherName,Gender gender,long phoneNumber,Department department):base(sid,aid,name,fatherName,gender,phoneNumber,department){
        s_employeeID++;
        EmployeeID = "EID" + s_employeeID;
        RegisterDate = DateTime.Now;
    }

    public void ShowEmployee(){
        System.Console.WriteLine("*******EMPLOYEE DETAILS******");
        System.Console.WriteLine($"EmployeeId \t: {EmployeeID}");
        ShowStudent();
        System.Console.WriteLine($"Registered Date : {RegisterDate.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Year \t\t: {RegisterDate.AddDays(364).ToString("dd/MM/yyyy")}");
    }

}