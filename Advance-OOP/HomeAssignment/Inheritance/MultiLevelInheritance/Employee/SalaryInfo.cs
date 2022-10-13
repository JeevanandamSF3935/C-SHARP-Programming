
namespace Execise3
{
    public class SalaryInfo : PersonalInfo
    {
        public double MonthlySalary { get; set; }

        public int Month { get; set; }

        public SalaryInfo()
        {

        }

        public SalaryInfo(double monthlysalary, int month, string name, string fathername, Gender sex, long mobile, DateTime dob) : base(name, fathername, sex, mobile, dob)
        {
            MonthlySalary = monthlysalary;
            Month = month;
        }


        public void CalculateSalary()
        {
            MonthlySalary = 1000 * 30;
        }

        public void DisplaySalary()
        {
            System.Console.WriteLine($"{MonthlySalary}");
        }






    }
}