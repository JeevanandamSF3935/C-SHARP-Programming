

namespace Exercise1
{
    public class TheoryExam : PersonalInfo
    {
        public int[] Sem1 { get; set; }

        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }

        public int[] Sem4 { get; set; }

        public TheoryExam(int[] sem1, int[] sem2, int[] sem3, int[] sem4, string reg, string fname, string name, long phone, DateTime dob, Gender sex) : base (reg, fname, name, phone, dob, sex)
        {
            Sem1 = sem1;
            Sem2 = sem2;
            Sem3 = sem3;
            Sem4 =  sem4;
        }
    }
}