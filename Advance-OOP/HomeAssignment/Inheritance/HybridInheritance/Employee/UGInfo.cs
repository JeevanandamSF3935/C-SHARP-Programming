
namespace Exercise3
{
    public class UGInfo : PersonalInfo
    {
        public  string Marksheet { get; set; }

        public string Degree { get; set; }

        public string Branch { get; set; }

        public int[] Sem1 { get; set; }

        public int[] Sem2 { get; set; }

        public int[] Sem3 { get; set; }

        public int[] Sem4 { get; set; }

        public UGInfo(string marksheet, string degree, string branch,  string name, Gender sex, DateTime dob, long mobile, long phone, string fname, string mname, string Permanentadd) : base(name, sex, dob, mobile, phone, fname, mname, Permanentadd)
        {
            Marksheet = marksheet;
            Degree = degree;
            Branch = branch;
            // Sem1 = sem1;
            // Sem2 = sem2;
            // Sem3 = sem3;
            // Sem4 = sem4;
        }

        public void CheckEligiblity()
        {

        }
    }
}