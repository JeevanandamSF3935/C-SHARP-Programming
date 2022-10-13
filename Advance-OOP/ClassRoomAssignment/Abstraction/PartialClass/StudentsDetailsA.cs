namespace PartialClass;

///<summary>
///Used to specify the given gender list Male, Female, Transgender
///</summary>
public enum Gender{
    Default, Male, Female, Transgender
}
public partial class StudentsDetails
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

}