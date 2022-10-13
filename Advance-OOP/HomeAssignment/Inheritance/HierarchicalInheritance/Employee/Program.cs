using System;
namespace Employee;
class Program
{
    public static void Main(string[] args)
    {
        PermanentEmployee employee1 = new PermanentEmployee(EmployeeType.Permanent,20000);
        employee1.ShowInfo();
        System.Console.WriteLine("\n\n");
        TemporaryEmployee employee2 = new TemporaryEmployee(EmployeeType.Temporary,20000);
        employee2.ShowInfo();
    }
}