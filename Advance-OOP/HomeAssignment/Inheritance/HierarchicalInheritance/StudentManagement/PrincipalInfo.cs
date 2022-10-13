using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement;
public class PrincipalInfo:PersonalInfo
{
    private static int s_principalID = 1000;
    public string PrincipalID { get; }
    public string Qualification { get; set; }
    public int YearOfExperience { get; set; }
    public DateTime DateOfJoining { get; set; }
    public PrincipalInfo(){

    }
    public PrincipalInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender, string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,phoneNumber,mailID,dob,gender){
        s_principalID++;
        PrincipalID = "PID" + s_principalID;
        Qualification = qualification;
        YearOfExperience = yearOfExperience;
        DateOfJoining = dateOfJoining;
    }

    public void ShowInfo(){
        System.Console.WriteLine($"Principal ID : {PrincipalID}");
        System.Console.WriteLine($"Name : {Name}");
        System.Console.WriteLine($"Father Name : {FatherName}");
        System.Console.WriteLine($"Phone Number : {PhoneNumber}");
        System.Console.WriteLine($"Mail ID : {MailID}");
        System.Console.WriteLine($"Date of Birth : {DOB.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Gender : {PersonGender}");
        System.Console.WriteLine($"Qualification : {Qualification}");
        System.Console.WriteLine($"Year of Experience : {YearOfExperience}");
        System.Console.WriteLine($"Date of Joining : {DateOfJoining.ToString("dd/MM/yyyy")}");
    }
}