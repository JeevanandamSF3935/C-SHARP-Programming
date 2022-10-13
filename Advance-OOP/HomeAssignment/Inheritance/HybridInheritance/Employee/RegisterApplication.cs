
namespace Exercise3
{
    public class RegisterApplication : UGInfo
    {
        public string RegisterNumber { get; set; }

        public int ExpMonth { get; set; }

        public string FieldOfInterest { get; set; }

        public RegisterApplication(string reg, int exp, string fieldInterest, string marksheet, string degree, string branch,  string name, Gender sex, DateTime dob, long mobile, long phone, string fname, string mname, string Permanentadd) : base (marksheet, degree, branch,  name, sex, dob, mobile, phone, fname, mname, Permanentadd)
        {
            RegisterNumber = reg;
            ExpMonth = exp;
            FieldOfInterest = fieldInterest;
        }

        public void UpdateDetails()
        {

        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"{RegisterNumber}");
            System.Console.WriteLine($"{Name}");
            System.Console.WriteLine($"{Sex}");
            System.Console.WriteLine($"{DOB}");
            System.Console.WriteLine($"{Mobile}");
            System.Console.WriteLine($"{Phone}");
            System.Console.WriteLine($"{FatherName}");
            System.Console.WriteLine($"{MotherName}");
            System.Console.WriteLine($"{PermanentAdd}");
            System.Console.WriteLine($"{ExpMonth}");
            System.Console.WriteLine($"{FieldOfInterest}");
            System.Console.WriteLine($"{Marksheet}");
            System.Console.WriteLine($"{Degree}");
            System.Console.WriteLine($"{Branch}");

        }
    }
}