

namespace Execise3
{
    public class EmployeeInfo : SalaryInfo
    {
        public string EmployeeID { get; set; }

        public string Branch { get; set; }

        public int Floor { get; set; }

        public EmployeeInfo()
        {

        }

        public EmployeeInfo(string employeeid, string branch, int floor, double monthlysalary, int month, string name, string fathername, Gender sex, long mobile, DateTime dob) : base (monthlysalary, month, name, fathername, sex, mobile, dob)
        {
            EmployeeID = employeeid;
            Branch = branch;
            Floor = floor;
        }

        public void UpdateDetails()
        {

        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"{EmployeeID}");
            System.Console.WriteLine($"{Branch}");
            System.Console.WriteLine($"{Floor}");
            System.Console.WriteLine($"{MonthlySalary}");
            System.Console.WriteLine($"{Month}");
            System.Console.WriteLine($"{Name}");
            System.Console.WriteLine($"{FatherName}");
            System.Console.WriteLine($"{Sex}");
            System.Console.WriteLine($"{Mobile}");
            System.Console.WriteLine($"{DOB}");
        }
    }
}