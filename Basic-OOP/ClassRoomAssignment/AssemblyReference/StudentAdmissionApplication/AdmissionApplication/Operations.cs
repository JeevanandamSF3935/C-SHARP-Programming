using AdmissionLibrary;
namespace AdmissionApplication;
public class Operations
{
    public static void MainMenu()
    {
        string name = "",fatherName = "",mailID = "";
        long phoneNumber = 0;
        int physics = 0,chemistry= 0 , maths = 0;
        Gender gender;

        List<StudentsDetails> studentList = new List<StudentsDetails>(); //List creation
        String choice = "";
        System.Console.WriteLine("Are you willing to join ?");
        choice = Console.ReadLine().ToLower();
        DateTime dob = new DateTime();

        do{
            
            System.Console.WriteLine("Student-1 details :");
            
            System.Console.Write("Enter the name : ");
            name = Console.ReadLine();

            System.Console.Write("Enter the father's name : ");
            fatherName = Console.ReadLine();

            System.Console.Write("Enter the date of birth in formate (dd/MM/yyy) : ");
            dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            
            System.Console.Write("Enter the gender (Male/Female/Transgender) :");
            bool temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            while(!temp){
                System.Console.WriteLine("Not entered correctly.\nEnter again:");
                temp = Enum.TryParse<Gender>(Console.ReadLine(),true,out gender);
            }
            
            System.Console.Write("Enter the mobile number : ");
            phoneNumber = long.Parse(Console.ReadLine());
            
            System.Console.Write("Enter the MailID : ");
            mailID = Console.ReadLine();
            
            System.Console.Write("Enter the chemistry mark : ");
            chemistry = int.Parse(Console.ReadLine());
            
            System.Console.Write("Enter the physics mark : ");
            physics = int.Parse(Console.ReadLine());
            
            System.Console.Write("Enter the maths mark : ");
            maths = int.Parse(Console.ReadLine());

            StudentsDetails student = new StudentsDetails(name,fatherName,dob,gender,phoneNumber,mailID,chemistry,physics,maths); //Student1 object creation
            studentList.Add(student); //Add object to the list
            System.Console.WriteLine("Student Admitted!");
            System.Console.WriteLine($"Your register number is : {student.RegisterNumber}");

            System.Console.WriteLine("Are you willing to join ?");
            choice = Console.ReadLine().ToLower();
        }while(choice == "yes");

        //showing students details
        System.Console.WriteLine("Students Details :");
        foreach(StudentsDetails students in studentList){
            System.Console.WriteLine($"RegisterNumber\t: {students.RegisterNumber}");
            System.Console.WriteLine($"Name \t\t: {students.Name}");
            System.Console.WriteLine($"Father's Name \t: {students.FatherName}");
            System.Console.WriteLine($"Date of Birth \t: {students.Dob.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Gender \t\t: {students.StudentGender}");
            System.Console.WriteLine($"Phone number \t: {students.PhoneNumber}");
            System.Console.WriteLine($"MailId \t\t: {students.MailID}");
            System.Console.WriteLine($"Chemistry Mark \t: {students.Chemistry}");
            System.Console.WriteLine($"Physics Mark \t: {students.Physics}");
            System.Console.WriteLine($"Maths mark \t: {students.Maths}");
            bool eligible = students.EligibilityCheck(75.0);
            if(eligible){
                System.Console.WriteLine("Eligible for admission");
            }
            else{
                System.Console.WriteLine("Not Eligible for admission");
            }
            System.Console.WriteLine();
        }
    }
}