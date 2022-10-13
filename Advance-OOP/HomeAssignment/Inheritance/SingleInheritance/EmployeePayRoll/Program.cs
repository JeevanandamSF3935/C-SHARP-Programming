using System;

namespace Exercise3;

class Program 
{
    public static void Main(string[] args)
    {
        DefaultValue();
    }

    static void DefaultValue()
    {
        SalaryInfo obj = new SalaryInfo(10000, 10, new DateTime(2022, 10, 10), 100);
        obj.CalculateSalary();
        obj.DisplaySalary();

        SalaryInfo obj1 = new SalaryInfo(10110, 11, new DateTime(2021, 10, 20), 190);
        obj1.CalculateSalary();
        obj1.DisplaySalary();



    }
}