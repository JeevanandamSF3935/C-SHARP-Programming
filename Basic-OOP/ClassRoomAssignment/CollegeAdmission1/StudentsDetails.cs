using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission1;
public class StudentsDetails
{
    //private string _name;
    //public string Name { get {return _name;} set{_name = value;} }
    public string Name { get; set; } //AutoProperty
    public string FatherName { get; set; }
    public DateTime Dob{ get; set; }
    public string  Gender { get; set; }
    public long  PhoneNumber { get; set; }
    public string MailID { get; set; }
    public int Chemistry { get; set; }
    public int Physics { get; set; }
    public int Maths { get; set; }

    //default constructor
    public StudentsDetails(){
        Name = "Your Name";
        FatherName = "Your Father Name";
    }

    //parameterized constructor
    public StudentsDetails(string name, string fatherName, DateTime dob,string gender,long phoneNumber,string mailID,int chemistry,int physics,int maths){
        Name = name;
        FatherName = fatherName;
        Dob = dob;
        Gender = gender;
        PhoneNumber = phoneNumber;
        MailID = mailID;
        Chemistry = chemistry;
        Physics = physics;
        Maths = maths;
    }
}
