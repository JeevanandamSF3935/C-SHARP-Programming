using System;

namespace OnlineGrocery;
public enum Gender
{
    Default,Male,Female,Transgender
}
public class PersonalDetails
{
    public string Name { get; set; }
    public string FatherName { get; set; }
    public Gender UserGender { get; set; }
    public long MobileNumber { get; set; }
    public DateTime DateOfBirth{get;set;}
    public string MailID { get; set; }
    public PersonalDetails(){

    }

    public PersonalDetails(string name,string fatherName,Gender gender, long mobileNumber,DateTime dateOfBirth,string mailId){
        Name = name;
        FatherName = fatherName;
        UserGender = gender;
        MobileNumber = mobileNumber;
        DateOfBirth = dateOfBirth;
        MailID = mailId;
    }
}