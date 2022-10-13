using System;
namespace EmployeePayroll;
public enum Gender
{
    Default,Male,Female,Transgender
}
public enum WorkLocation
{
    Default,Madura,Eymard
}
class Program
{
    public static void Main(string[] args)
    {
        string employeeName = "", role = "",teamName = "", choice = "";
        WorkLocation employeeWorkLocation; 
        DateTime dateOfJoining, workingMonthAndYear;
        int workingDays = 0;
        double leaveTaken = 0;
        Gender employeeGender;
        
        List<EmployeePayment> employeeList = new List<EmployeePayment>();
        System.Console.WriteLine("Do you want to enroll the employee ?");
        choice = Console.ReadLine().ToLower();
        
        do{
            System.Console.Write("Enter the employee name : ");
            employeeName = Console.ReadLine();
            System.Console.Write("Enter the role : ");
            role = Console.ReadLine();
            System.Console.Write("Enter the work location (Madura or Eymard) : ");
            bool locationTemp = WorkLocation.TryParse(Console.ReadLine(),true,out employeeWorkLocation);
            while(!locationTemp){
                System.Console.Write("Wrong input!\nEnter again : ");
                locationTemp = WorkLocation.TryParse(Console.ReadLine(),true,out employeeWorkLocation);
            }
            System.Console.Write("Enter the team name : ");
            teamName = Console.ReadLine();
            System.Console.Write("Enter the Date of joining : ");
            dateOfJoining = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter the month and year of working(MM/yyyy) :");
            workingMonthAndYear = DateTime.ParseExact(Console.ReadLine(),"MM/yyyy",null);
            workingDays = DateTime.DaysInMonth(workingMonthAndYear.Year,workingMonthAndYear.Month);
            System.Console.Write("Enter the number of leaves taken : ");
            leaveTaken = double.Parse(Console.ReadLine());
            System.Console.Write("Enter the gender (Male,Female,Transgender) : ");
            bool genderTemp = Gender.TryParse(Console.ReadLine(),true,out employeeGender);
            while(!genderTemp){
                System.Console.Write("Wrong input!\nEnter again : ");
                genderTemp = Gender.TryParse(Console.ReadLine(),true,out employeeGender);
            }
            System.Console.WriteLine("Employee Enrolled");
            EmployeePayment employee = new EmployeePayment(employeeName,role,employeeWorkLocation,teamName,dateOfJoining,workingDays,leaveTaken,employeeGender);

            employeeList.Add(employee);
            System.Console.WriteLine("Do you want to enroll an employee ?");
            choice = Console.ReadLine();

        }while(choice == "yes");

        foreach(EmployeePayment employee in employeeList){
            System.Console.WriteLine($"Employee ID\t\t: {employee.EmployeeID}");
            System.Console.WriteLine($"Employee Name\t\t: {employee.EmployeeName}");
            System.Console.WriteLine($"Role\t\t\t: {employee.Role}");
            System.Console.WriteLine($"Work Location\t\t: {employee.EmployeeWorkLocation}");
            System.Console.WriteLine($"Team Name\t\t: {employee.TeamName}");
            System.Console.WriteLine($"Date of Joining\t\t: {employee.DateOfJoining}");
            System.Console.WriteLine($"Gender\t\t\t: {employee.EmployeeGender}");
            System.Console.WriteLine($"Number of days worked \t: {employee.WorkingDays - employee.LeaveTaken}");
            employee.CalculateSalary();
        }

    }
}