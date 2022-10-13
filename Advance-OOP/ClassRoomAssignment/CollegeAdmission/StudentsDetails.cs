using System;
///<summary>
///Used to specify the given gender list Male, Female, Transgender
///</summary>
public enum Gender{
    Default, Male, Female, Transgender
}
///<summary>
///Used to create a namespace for college admission
///</summary>
namespace CollegeAdmission{
    ///<summary>
    ///StudentsDetails is a class used to register the student details for admission with several number of fields and methods.
    ///</summary>
    public class StudentsDetails
    {
        ///<summary>
        ///s_registerNumber is used to auto generate the register number for the registered students.
        ///</summary>
        private static int s_registerNumber = 0;
        ///<summary>
        ///RegisterNumber is a property used to get the register number of the registered students.
        ///</summary>
        public long RegisterNumber { get;}
        //private string _name;
        //public string Name { get {return _name;} set{_name = value;} }
        
        ///<summary>
        ///Name is a property used to set and get the name of the registered students.
        ///</summary>
        public string Name { get; set; } //AutoProperty

        ///<summary>
        ///FatherName is a property used to set and get the father name of the registered students.
        ///</summary>
        public string FatherName { get; set; }

        ///<summary>
        ///Dob is a property used to set and get the date of birth of the registered students.
        ///</summary>
        public DateTime Dob{ get; set; }
        ///<summary>
        ///StudentGender is a property used to set and get the gender of the registered students.
        ///</summary>
        public Gender StudentGender { get; set; }

        ///<summary>
        ///PhoneNumber is a property used to set and get the phone number of the registered students.
        ///</summary>
        public long  PhoneNumber { get; set; }
        ///<summary>
        ///MailID is a property used to set and get the mail ID of the registered students.
        ///</summary>
        public string MailID { get; set; }
        ///<summary>
        ///Chemistry is a property used to set and get the Chemistry mark of the registered students.
        ///</summary>
        public int Chemistry { get; set; }
        ///<summary>
        ///Physics is a property used to set and get the Physics mark of the registered students.
        ///</summary>
        public int Physics { get; set; }
        ///<summary>
        ///Maths is a property used to set and get the Maths mark of the registered students.
        ///</summary>
        public int Maths { get; set; }


        ///<summary>
        ///It is a default constructor, to create the object of the class StudentDetails.
        ///</summary>
        public StudentsDetails(){
            
        }
        //parameterized constructor
        ///<summary>
        ///It is a parameterized constructor of class <see cref = "StudentsDetails"/>, to register the student details.
        ///</summary>
        ///<param name = "name"> Used to provide name of the student</param>
        ///<param name = "fatherName"> Used to provide father name of the student</param>
        ///<param name = "dob"> Used to provide Date of birth of the student</param>
        ///<param name = "gender"> Used to provide gender of the student</param>
        ///<param name = "phoneNumber"> Used to provide phone number of the student</param>
        ///<param name = "mailID"> Used to provide mail ID of the student</param>
        ///<param name = "chemistry"> Used to provide chemistry mark of the student</param>
        ///<param name = "physics"> Used to provide physics mark of the student</param>
        ///<param name = "maths"> Used to provide maths mark of the student</param>
        public StudentsDetails(string name, string fatherName, DateTime dob,Gender gender,long phoneNumber,string mailID,int chemistry,int physics,int maths){
            s_registerNumber++;
            RegisterNumber = 613522104000 + s_registerNumber;
            Name = name;
            FatherName = fatherName;
            Dob = dob;
            StudentGender = gender;
            PhoneNumber = phoneNumber;
            MailID = mailID;
            Chemistry = chemistry;
            Physics = physics;
            Maths = maths;
        }

        ///<summary>
        ///EligibilityCheck is a constructor of<see cref = "StudentsDetails" /> class, Used to check the eligibility of the student to get admission.
        ///</summary>
        ///<param name="cutOff"> It is used to pass the eligibilty cutoff to check the student is eligible or not</param>
        ///<returns>It returns the boolean value (whether true or false) as eligible or not.</returns>
        public bool EligibilityCheck(double cutOff){
            double average = (double)(Chemistry + Physics + Maths) / 3;
            if(cutOff <= average){
                return true;
            }
            else{
                return false;
            }
        }

        ///<summary>
        ///ShowDetails is a constructor of class <see cref = "StudentsDetails"/>, Used to show the details of the student.
        ///</summary>
        public void ShowDetails(){
                System.Console.WriteLine($"RegisterNumber\t: {RegisterNumber}");
                System.Console.WriteLine($"Name \t\t: {Name}");
                System.Console.WriteLine($"Father's Name \t: {FatherName}");
                System.Console.WriteLine($"Date of Birth \t: {Dob.ToString("dd/MM/yyyy")}");
                System.Console.WriteLine($"Gender \t\t: {StudentGender}");
                System.Console.WriteLine($"Phone number \t: {PhoneNumber}");
                System.Console.WriteLine($"MailId \t\t: {MailID}");
                System.Console.WriteLine($"Chemistry Mark \t: {Chemistry}");
                System.Console.WriteLine($"Physics Mark \t: {Physics}");
                System.Console.WriteLine($"Maths mark \t: {Maths}");
            }

        //destructor
        /*~StudentsDetails(){

        }*/

    }
}