
namespace Exercise2
{
    public class PersonalInfo
    {   
        public enum Gender { Default, Male, Female, Transgender }
        public string Name { get; set; }
        
        public string FatherName { get; set; }

        public long Phone { get; set; }

        public Gender genderInfo { get; set; }

        public string Mail { get; set; }

        public DateTime DOB { get; set; }

        public PersonalInfo()
        {

        }

        public PersonalInfo(string name, string fatherName, long phoneNumber, Gender sex)
        {
            Name = name;
            FatherName  =fatherName;
            Phone = phoneNumber;
            genderInfo = sex;
        }

       
    }
}