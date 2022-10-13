
namespace Exercise3
{
    public class SalaryInfo:Attendance
    {
        public double Salary { get; set; }

        public int Month { get; set; }

        public SalaryInfo()
        {

        }
        public SalaryInfo(double salary, int month, DateTime date, int worked):base(date, worked)
        {
            Salary = salary;
            Month = month;
        }

        public void CalculateSalary()
        {
            Salary = WorkedHours * 1000;
        }

        public void DisplaySalary()
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Salary: {Salary}");
        }
    }
}