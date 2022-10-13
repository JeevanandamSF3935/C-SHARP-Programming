namespace AdmissionLibrary;
public enum Gender{
    Default, Male, Female, Transgender
}
public class StudentsDetails
{
    private static int s_registerNumber = 0;
    public long RegisterNumber { get;}
    //private string _name;
    //public string Name { get {return _name;} set{_name = value;} }
    public string Name { get; set; } //AutoProperty
    public string FatherName { get; set; }
    public DateTime Dob{ get; set; }
    public Gender StudentGender { get; set; }
    public long  PhoneNumber { get; set; }
    public string MailID { get; set; }
    public int Chemistry { get; set; }
    public int Physics { get; set; }
    public int Maths { get; set; }

    //parameterized constructor
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

    public bool EligibilityCheck(double cutOff){
        double average = (double)(Chemistry + Physics + Maths) / 3;
        if(cutOff <= average){
            return true;
        }
        else{
            return false;
        }
    }

    //destructor
    /*~StudentsDetails(){

    }*/

}
