using System;

namespace Employee;
public enum EmployeeType
{
    Default,Permanent,Temporary
}
public class PermanentEmployee:SalaryInfo
{
    public static int s_employeeID = 1000;
    public string EmployeeID { get; set; }
    public EmployeeType TypeOfEmployee { get; set; }
    public double TotalSalary { get; set; }

    public PermanentEmployee(){

    }
    public PermanentEmployee(EmployeeType typeOfEmployee,double basicSalary):base(basicSalary){
        s_employeeID++;
        EmployeeID = "EID" + s_employeeID;
        TypeOfEmployee = typeOfEmployee;
        TotalSalary = 0;
        CalculateSalary();
    }

    public void CalculateSalary(){
        TotalSalary = BasicSalary+(BasicSalary*0.2/100)+(BasicSalary*0.18/100)-(BasicSalary*0.1/100);
    }
    public void ShowInfo(){
        System.Console.WriteLine($"EmployeeID : {EmployeeID}");
        System.Console.WriteLine($"Employee Type : {TypeOfEmployee}");
        System.Console.WriteLine($"Basic Salary : {BasicSalary}");
        System.Console.WriteLine($"Total Salary of the month {Month} is Rs.{TotalSalary}");
    }
}