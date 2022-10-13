namespace PartialClass;

public partial class StudentsDetails
{
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

    //destructor
    /*~StudentsDetails(){

    }*/
}