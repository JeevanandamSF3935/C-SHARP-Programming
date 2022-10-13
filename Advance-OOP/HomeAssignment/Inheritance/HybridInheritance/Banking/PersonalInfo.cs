

namespace Exercise2
{   
    public enum Gender { Default, Male, Female, Transgender }
    public class PersonalInfo
    {
        public string Name { get; set; }

        public Gender Sex { get; set; }

        public long Phone { get; set; }

        public long Mobile { get; set; }

        public DateTime DOB { get; set; }

        public PersonalInfo(string name, Gender sex, long phone, long mobile, DateTime dob)
        {
            Name = name;
            Sex = sex;
            Phone = phone;
            Mobile = mobile;
            DOB = dob;
        }


    }
}