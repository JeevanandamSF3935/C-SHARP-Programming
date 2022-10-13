using System;
namespace StudentManagement;
public enum Branch
{
    Default,CSE,ECE,EEE,CIV,MECH
}
public class StudentInfo:PersonalInfo
{
    public static long s_registerNumber = 613518104000;
    public long RegisterNumber { get; set; }
    public int Standard { get; set; }
    public Branch Department { get; set; }
    public DateTime AcademicYear { get; set; }

    public StudentInfo(){

    }
    public StudentInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender,int standard,Branch branch,DateTime academicYear):base(name,fatherName,phoneNumber,mailID,dob,gender){
        s_registerNumber++;
        RegisterNumber = s_registerNumber;
        Standard = standard;
        Department = branch;
        AcademicYear = academicYear;
    }

    public void UpdateInfo(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender,int standard,Branch branch,DateTime academicYear){
        Name = name;
        FatherName = fatherName;
        PhoneNumber = phoneNumber;
        MailID = mailID;
        DOB = dob;
        PersonGender = gender;
        Standard = standard;
        Department = branch;
        AcademicYear = academicYear;
    }

    public void ShowInfo(){
        System.Console.WriteLine($"Register Number : {RegisterNumber}");
        System.Console.WriteLine($"Name : {Name}");
        System.Console.WriteLine($"Father Name : {FatherName}");
        System.Console.WriteLine($"Phone Number : {PhoneNumber}");
        System.Console.WriteLine($"Mail ID : {MailID}");
        System.Console.WriteLine($"Date of Birth : {DOB.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Gender : {PersonGender}");
        System.Console.WriteLine($"Semester : 0{Standard}");
        System.Console.WriteLine($"Department : {Department}");
        System.Console.WriteLine($"Academic Year : {AcademicYear.ToString("yyyy")}");
    }
}