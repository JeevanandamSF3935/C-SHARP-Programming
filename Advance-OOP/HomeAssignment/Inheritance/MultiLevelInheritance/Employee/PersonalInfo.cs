

namespace Execise3
{   
    public enum Gender { Default, Male, Female, Transgender }
    public class PersonalInfo
    {
        public string Name { get; set; }

        public string FatherName { get; set; }

        public Gender Sex { get; set; }

        public long Mobile { get; set; }

        public DateTime DOB { get; set; }

        public PersonalInfo()
        {

        }

        public PersonalInfo(string name, string fathername, Gender sex, long mobile, DateTime dob)
        {
            Name = name;
            FatherName = fathername;
            Sex = sex;
            Mobile = mobile;
            DOB = dob;
        }
    }
}