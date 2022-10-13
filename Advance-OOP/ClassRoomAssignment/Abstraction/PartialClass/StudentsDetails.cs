///<summary>
///Used to create a namespace for college admission
///</summary>
namespace PartialClass;
///<summary>
///StudentsDetails is a class used to register the student details for admission with several number of fields and methods.
///</summary>
public partial class StudentsDetails
{

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
}