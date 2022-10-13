namespace StudentManagement;
public enum Gender
{
    Default,Male,Female,Transgender
}
public class PersonalInfo
{
    public string Name { get; set; }
    public string FatherName { get; set; }
    public long PhoneNumber { get; set; }
    public string MailID { get; set; }
    public DateTime DOB { get; set; }
    public Gender PersonGender { get; set; }
    public PersonalInfo(){

    }
    public PersonalInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender){
        Name = name;
        FatherName = fatherName;
        PhoneNumber = phoneNumber;
        MailID = mailID;
        DOB = dob;
        PersonGender = gender;
    }
}
