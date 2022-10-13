using System;
using System.Collections.Generic;
namespace CollegeAdmission;
public class RegisterClass
{
    public static List<StudentDetails> studentsList = new List<StudentDetails>();
    public static void Register(){
        Gender gender;
        DateTime date;
        System.Console.WriteLine("******REGISTRATION FORM******");
        System.Console.Write("Enter the HSC Marksheet number : ");
        System.Console.WriteLine("*Note : Once registered marksheet number can't be changed.");
        string hscMarkSheet = Console.ReadLine().ToUpper();
        foreach(StudentDetails students in studentsList){
            if(students.HSCMarkSheet == hscMarkSheet){
                //System.Console.WriteLine(students.HSCMarkSheet);
                System.Console.WriteLine("Student already registered!\n");
                break;
            }
            else{
                System.Console.Write("Enter the Name : ");
                string name = Console.ReadLine();
                System.Console.Write("Enter the father name : ");
                string fatherName = Console.ReadLine();
                System.Console.Write("Enter the date of birth (dd/mm/yyyy) : ");
                date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                System.Console.Write("Enter the gender (Male or Female or Transgender) : ");
                bool temp = Gender.TryParse(Console.ReadLine(),true,out gender);
                while(!temp){
                    System.Console.Write("Invalid input\nEnter again : ");
                    temp = Gender.TryParse(Console.ReadLine(),true,out gender);
                }
                System.Console.Write("Enter the chemistry mark : ");
                int chemistryMark = int.Parse(Console.ReadLine());
                System.Console.Write("Enter the physics mark : ");
                int physicsMark = int.Parse(Console.ReadLine());
                System.Console.Write("Enter the maths mark : ");
                int mathsMark = int.Parse(Console.ReadLine());
                StudentDetails student = new StudentDetails(name,fatherName,date,gender,physicsMark,chemistryMark,mathsMark,hscMarkSheet);
                studentsList.Add(student);
                System.Console.WriteLine($"Registered successfully!\nStudentID is {student.StudentID}\n");
                break;
            }
        }
    }

    public static void Update(StudentDetails student){
        DateTime date;
        Gender gender;
        student.ShowDetails();
        System.Console.WriteLine("****** UPDATATION FORM*******");
        System.Console.WriteLine("******Enter the details******");
        System.Console.Write("Enter the Name : ");
        string name = Console.ReadLine();
        System.Console.Write("Enter the father name : ");
        string fatherName = Console.ReadLine();
        System.Console.Write("Enter the date of birth (dd/mm/yyyy) : ");
        bool dateTemp = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date);
        while(!dateTemp){
            System.Console.WriteLine("Invalid date formate\nTry again");
            dateTemp = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out date);
        }
        System.Console.Write("Enter the gender (Male or Female or Transgender) : ");
        bool temp = Gender.TryParse(Console.ReadLine(),true,out gender);
        while(!temp){
            System.Console.Write("Invalid input\nEnter again : ");
            temp = Gender.TryParse(Console.ReadLine(),true,out gender);
        }
        System.Console.Write("Enter the chemistry mark : ");
        int chemistryMark = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the physics mark : ");
        int physicsMark = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the maths mark : ");
        int mathsMark = int.Parse(Console.ReadLine());
        student.UpdateDetails(student.StudentID,name,fatherName,date,gender,chemistryMark,physicsMark,mathsMark);
    }

}
