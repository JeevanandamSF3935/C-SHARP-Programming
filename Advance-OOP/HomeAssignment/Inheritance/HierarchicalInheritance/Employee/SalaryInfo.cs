using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee;
public class SalaryInfo
{
    public int Month { get; set; }
    public double BasicSalary { get; set; }
    public SalaryInfo(){

    }
    public SalaryInfo(double basicSalary){
        Month = DateTime.Now.Month;
        BasicSalary = basicSalary;
    }
}