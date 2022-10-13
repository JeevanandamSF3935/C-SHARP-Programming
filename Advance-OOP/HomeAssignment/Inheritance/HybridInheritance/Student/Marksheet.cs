

namespace Exercise1
{
    public class Marksheet : TheoryExam, Icalculate
    {
        public int MarksheetNumber { get; set; }

        public DateTime DateOFIssue { get; set; }

        public int Total { get; set; }

        public double Percentage { get; set; }

        public int ProjectMark { get; set; }

        public Marksheet(int marksheet, DateTime issueDate, int total, double percent, int[] sem1, int[] sem2, int[] sem3, int[] sem4, string reg, string fname, string name, long phone, DateTime dob, Gender sex) : base(sem1, sem2, sem3, sem4, reg, fname, name, phone, dob, sex)
        {
            MarksheetNumber = marksheet;
            DateOFIssue = issueDate;
            Total = total;
            Percentage = percent;
        }

        public void CaluclateUG()
        {

        }
        public void ShowUGMarkSheet()
        {
            System.Console.WriteLine($"{MarksheetNumber}");
            System.Console.WriteLine($"{DateOFIssue}");
            System.Console.WriteLine($"{Total}");
            System.Console.WriteLine($"{Percentage}");
            System.Console.WriteLine($"{Sem1}");
            System.Console.WriteLine($"{Sem2}");
            System.Console.WriteLine($"{Sem3}");
            System.Console.WriteLine($"{Sem4}");
            System.Console.WriteLine($"{RegistrationNumber}");
            System.Console.WriteLine($"{FatherName}");
            System.Console.WriteLine($"{Name}");
            System.Console.WriteLine($"{Phone}");
            System.Console.WriteLine($"{DOB}");
            System.Console.WriteLine($"{Sex}");

        }
    }
}