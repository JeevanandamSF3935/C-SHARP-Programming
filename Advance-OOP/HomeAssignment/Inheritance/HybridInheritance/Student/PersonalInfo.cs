
namespace Exercise1
{   
    public enum Gender { Default, Male, Female , Transgender }
   
    public class PersonalInfo
    {
        public string  RegistrationNumber { get; set; }

        public string FatherName { get; set; }

        public string Name { get; set; }

        public long Phone { get; set; }

        public DateTime DOB { get; set; }

        public Gender Sex { get; set; }

        public PersonalInfo(string reg, string fname, string name, long phone, DateTime dob, Gender sex)
        {
            RegistrationNumber = reg;
            FatherName = fname;
            Name = name;
            Phone = phone;
            DOB = dob;
            Sex = sex;
        }


    }
}