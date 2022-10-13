namespace HieraricalInheritance;
public enum Gender
{
    Default,Male,Female,Transgender
}
public class PersonalDetails
{
    public static int s_aID = 1000;
    public string AID { get; }
    public string Name { get; set; }
    public string FatherName { get; set; }
    public Gender UserGender { get; set; }
    public long PhoneNumber { get; set; }
    public PersonalDetails(){

    }
    public PersonalDetails(string name,string fatherName,Gender gender,long phoneNumber){
        s_aID++;
        AID = "AID" + s_aID;
        Name = name;
        FatherName = fatherName;
        UserGender = gender;
        PhoneNumber = phoneNumber;
    }

    public PersonalDetails(string aid,string name,string fatherName,Gender gender,long phoneNumber){
        AID = aid;
        Name = name;
        FatherName = fatherName;
        UserGender = gender;
        PhoneNumber = phoneNumber;
    }

    public static void ShowDetails(){
        foreach(PersonalDetails person in Process.personsList){
            System.Console.WriteLine($"A-ID \t\t: {person.AID}");
            System.Console.WriteLine($"Name \t\t: {person.Name}");
            System.Console.WriteLine($"Father Name \t: {person.FatherName}");
            System.Console.WriteLine($"Gender \t\t: {person.UserGender}");
            System.Console.WriteLine($"Phone number \t: {person.PhoneNumber}");
        }
    }
}