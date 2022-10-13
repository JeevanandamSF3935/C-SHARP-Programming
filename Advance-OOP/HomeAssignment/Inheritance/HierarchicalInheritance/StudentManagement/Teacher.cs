using System;
namespace StudentManagement;
public class Teacher:PersonalInfo
{
    private static int s_teacherID = 1000;
    public string TeacherID { get; }
    public Branch Department { get; set; }
    public string SubjectTeaching{ get; set; }
    public string Qualification { get; set; }
    public int YearOfExperience { get; set; }
    public DateTime DateOfJoining { get; set; }
    public Teacher(){

    }
    public Teacher(string name,string fatherName,long phoneNumber,string mailID,DateTime dob,Gender gender, Branch department, string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,phoneNumber,mailID,dob,gender){
        s_teacherID++;
        TeacherID = "TID" + s_teacherID;
        Department = department;
        SubjectTeaching = subjectTeaching;
        Qualification = qualification;
        YearOfExperience = yearOfExperience;
        DateOfJoining = dateOfJoining;
    }

    public void ShowInfo(){
        System.Console.WriteLine($"Teacher ID : {TeacherID}");
        System.Console.WriteLine($"Name : {Name}");
        System.Console.WriteLine($"Father Name : {FatherName}");
        System.Console.WriteLine($"Phone Number : {PhoneNumber}");
        System.Console.WriteLine($"Mail ID : {MailID}");
        System.Console.WriteLine($"Date of Birth : {DOB.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Gender : {PersonGender}");
        System.Console.WriteLine($"Department : {Department}");
        System.Console.WriteLine($"Subject Teaching : {SubjectTeaching}");
        System.Console.WriteLine($"Qualtification : {Qualification}");
        System.Console.WriteLine($"Year Of Experience : {YearOfExperience}");
        System.Console.WriteLine($"Date Of Joining : {DateOfJoining.ToString("dd/MM/yyyy")}");
    }

}