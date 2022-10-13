using System.Collections.Generic;
namespace CollegeAdmission;
public class DepartmentDetails
{
    public static List<DepartmentDetails> departmentsList = new List<DepartmentDetails>();
    public static int s_departmentID = 100;
    public string DepartmentID { get; }
    public string DepartmentName { get; set; }
    public int NoOfSeats { get; set; }

    public DepartmentDetails(){

    }
    public DepartmentDetails(string departmentName, int noOfSeats){
        s_departmentID++;
        DepartmentID = "DID" + s_departmentID;
        DepartmentName = departmentName;
        NoOfSeats = noOfSeats;
    }

    public DepartmentDetails(string department){
        string[] values = department.Split(',');
        s_departmentID = int.Parse(values[0].Remove(0,3));
        DepartmentID = values[0];
        DepartmentName = values[1];
        NoOfSeats = int.Parse(values[2]);
    }


    public static void ShowDepartments(){
        System.Console.WriteLine("\t****DEPARTMENTS IN OUR COLLEGE****");
        System.Console.WriteLine("DepartmentID\tDepartment Name\t\tNumber of seats");
        foreach(DepartmentDetails departments in departmentsList){
            System.Console.WriteLine($"{departments.DepartmentID}\t\t\t{departments.DepartmentName}\t\t\t{departments.NoOfSeats}\n");
        }
        
    }
}
