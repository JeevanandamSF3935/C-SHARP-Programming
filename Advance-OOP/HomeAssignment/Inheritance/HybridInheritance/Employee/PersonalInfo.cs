

namespace Exercise3
{   
    public enum Gender { Default, Male, Female, Transgender }
    public class PersonalInfo : FamilyInfo
    {
        public string Name { get; set; }

        public Gender Sex { get; set; }

        public DateTime DOB { get; set; }

        public long Mobile { get; set; }

        public long Phone { get; set; }

        public string FatherName { get; set; }  

        public string MotherName { get; set; }

        public string PermanentAdd { get; set; }

        public PersonalInfo(string name, Gender sex, DateTime dob, long mobile, long phone, string fname, string mname, string Permanentadd)
        {
            Name = name;
            Sex = sex;
            DOB = dob;
            Mobile = mobile;
            Phone = phone;
            FatherName = fname;
            MotherName = mname;
            PermanentAdd = Permanentadd;
        }


    }
}