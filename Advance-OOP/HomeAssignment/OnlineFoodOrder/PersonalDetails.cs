using System;
namespace OnlineFoodOrder;
public enum Gender
{
    Default,Male,Female,Transgender
}
public class PersonalDetails
{
    public string Name { get; set; }
    public string FatherName { get; set; }
    public Gender UserGender{ get; set; }
    public long MobileNumber { get; set; }
    public DateTime DOB { get; set; }
    public string MailId { get; set; }
    public string Location { get; set; }

    public PersonalDetails(){

    }

    public PersonalDetails(string name,string fatherName,Gender gender,long mobileNumber,DateTime dob,string mailId,string location){
        Name = name;
        FatherName = fatherName;
        UserGender = gender;
        MobileNumber = mobileNumber;
        DOB = dob;
        MailId = mailId;
        Location = location;
    }
}