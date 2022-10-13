
namespace Exercise3
{   
    public enum Gender { Default, Male, Female , Transgender }
    public class PersonalInfo
    {
        public string Name { get; set; }

        public Gender Sex { get; set; }

        public DateTime DOB { get; set; }

        public long Phone { get; set; }

        public long  Mobile { get; set; }

        public string PAN { get; set; }

        public PersonalInfo(string name, Gender sex , DateTime dob, long phoneNumber, long mobile, string pan)
        {
            Name = name;
            Sex = sex;
            DOB = dob;
            Phone = phoneNumber;
            Mobile = mobile;
            PAN = pan;
        }
    }
}