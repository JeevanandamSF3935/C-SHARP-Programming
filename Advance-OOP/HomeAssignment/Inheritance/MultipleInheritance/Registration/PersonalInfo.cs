namespace MultipleInheritance;
public enum Gender
{
    Default,Male,Female,Transgender
}
public enum Marital
{
    Default,Married,Single
}
public class PersonalInfo:ShowData
{
    public string Name { get; set; }
    public Gender PersonGender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public long PhoneNumber { get; set; }
    public Marital MaritalStatus { get; set; }

    public PersonalInfo(){

    }
    public PersonalInfo(string name,Gender gender,DateTime dob,long phoneNumber,Marital maritalStatus){
        Name = name;
        PersonGender = gender;
        DateOfBirth = dob;
        PhoneNumber = phoneNumber;
        MaritalStatus = maritalStatus;
    }

    public void ShowInfo(){
        System.Console.WriteLine($"Name\t\t: {Name}");
        System.Console.WriteLine($"Gender\t\t: {PersonGender}");
        System.Console.WriteLine($"Date of Birth\t: {DateOfBirth.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Phone Number\t: {PhoneNumber}");
        System.Console.WriteLine($"Marital Status\t: {MaritalStatus}");
    }
}