using System;
namespace CollegeAdmission
{
    public static class Register
    {
        
        static StudentsDetails student = new StudentsDetails();
        public static Dictionary<long,StudentsDetails> studentDictionary = new Dictionary<long, StudentsDetails>(); 
        
        public static void RegisterStudent(){
            Gender gender;
            System.Console.Write("Enter the name : ");
            string name = Console.ReadLine();

            System.Console.Write("Enter the father's name : ");
            string fatherName = Console.ReadLine();

            System.Console.Write("Enter the date of birth in formate (dd/MM/yyy) : ");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            
            System.Console.Write("Enter the gender (Male/Female/Transgender) :");
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!temp){
                System.Console.WriteLine("Not entered correctly.\nEnter again:");
                temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            
            System.Console.Write("Enter the mobile number : ");
            long phoneNumber = long.Parse(Console.ReadLine());
            
            System.Console.Write("Enter the MailID : ");
            string mailID = Console.ReadLine();
            
            System.Console.Write("Enter the chemistry mark : ");
            int chemistry = int.Parse(Console.ReadLine());
            
            System.Console.Write("Enter the physics mark : ");
            int physics = int.Parse(Console.ReadLine());
            
            System.Console.Write("Enter the maths mark : ");
            int maths = int.Parse(Console.ReadLine());

            StudentsDetails student = new StudentsDetails(name,fatherName,dob,gender,phoneNumber,mailID,chemistry,physics,maths); //Student1 object creation
            studentDictionary.Add(student.RegisterNumber,student); //Add object to the list
            System.Console.WriteLine("Student Admitted!");
            System.Console.WriteLine($"Your register number is : {student.RegisterNumber}");
            System.Console.WriteLine();
        }
    }
}