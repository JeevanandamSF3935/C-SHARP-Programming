
namespace Multipath
{   
    public enum FeeStatus { Default, Paid, Unpaid }
    public class PGCounselling : IHSCInfo, IUGInfo
    {   

        public string AadharNumber { get; set; }

         public string Name { get; set; }

         public string FatherName { get; set; }

         public long Phone { get; set; }

         public int MyProperty { get; set; }

        private static int s_applicationID = 1000;
        public string ApplicationID { get; set; }

        public DateTime DateOfApplication { get; set; }

        public FeeStatus FStatus { get; set; }

        public int HSCMarksheetNumber { get; set; }

        public int Physics { get; set; }

        public int Chemistry { get; set; }

        public int Maths { get; set; }

        public double HSCTotal { get; set; }

         public double UGTotal { get; set; }

        public double PercentageMarks { get; set; }

         public int UGMarksheetNumber { get; set; }

        public int Sem1 { get; set; }

        public int Sem2 { get; set; }

        public int Sem3 { get; set; }

        public int Sem4 { get; set; }

        public double Percentage { get; set; }


        public PGCounselling(DateTime doa, FeeStatus status, string AID, string name, string fatherName, long phone, int hscmarksheet, int physics, int chemistry, int maths, int total, double hsctotal, double perMarks, int ugMarksheetNumber, int sem1, int sem2, int sem3, int sem4, double ugtotal, double perct )
        {
            DateOfApplication = doa;
            FStatus = status;

            AadharNumber = AID;
            Name = name;
            FatherName = fatherName;
            Phone = phone;

            HSCMarksheetNumber = hscmarksheet;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
            HSCTotal = hsctotal;
            PercentageMarks = perMarks;

            UGMarksheetNumber = ugMarksheetNumber;
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 = sem4;
            UGTotal = ugtotal;
            Percentage = perct;
        }

        public void UpdateInfo()
        {

        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"Aadhar Name: {AadharNumber}");
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"FatherName: {FatherName}");
            System.Console.WriteLine($"Phone: {Phone}");
            System.Console.WriteLine($"HSCMarksheetNumber: {HSCMarksheetNumber}");
            System.Console.WriteLine($"HSCTotal: {HSCTotal}");
            System.Console.WriteLine($"PercentageMarks: {PercentageMarks}");

            System.Console.WriteLine($"UGMarksheetNumber: {UGMarksheetNumber}");
            System.Console.WriteLine($"UGTotal: {UGTotal}");
            System.Console.WriteLine($"UG Percentage: {Percentage}");


        }

        public void PayFees(double fees)
        {
            System.Console.WriteLine("Fees Paid");
            FStatus = FeeStatus.Paid;
        }

        
        public void ShowHSCMarkSheet()
        {

        }

        public void CalculateHSC()
        {

        }

        public void ShowUGMarkSheet()
        {

        }

        public void CalculateUG()
        {

        }

    }
}