using System;
namespace Employee;
public class TemporaryEmployee:SalaryInfo
{
    private static int s_employeeID;
    public string EmployeeID { get; set; }
    public EmployeeType TypeOfEmployee { get; set; }
    public double TotalSalary { get; set; }

    public TemporaryEmployee(){

    }
    public TemporaryEmployee(EmployeeType typeOfEmployee,double basicSalary):base(basicSalary){
        s_employeeID = PermanentEmployee.s_employeeID++;
        EmployeeID = "EID" + s_employeeID;
        TypeOfEmployee = typeOfEmployee;
        TotalSalary = 0;
        CalculateSalary();
    }

    public void CalculateSalary(){
        TotalSalary = BasicSalary+(BasicSalary*0.15/100)+(BasicSalary*0.13/100)-(BasicSalary*0.1/100);
    }
    public void ShowInfo(){
        System.Console.WriteLine($"EmployeeID : {EmployeeID}");
        System.Console.WriteLine($"Employee Type : {TypeOfEmployee}");
        System.Console.WriteLine($"Basic Salary : {BasicSalary}");
        System.Console.WriteLine($"Total Salary of the month {Month} is Rs.{TotalSalary}");
    }
}