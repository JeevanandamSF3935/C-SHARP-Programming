namespace MultipleInheritance;
public class RegisterPerson:PersonalInfo,ShowData,IFamilyInfo
{
    public static int s_registerNumber = 1000;
    public int RegisterNumber { get; set; }
    public string FatherName { get; set; }
    public string MotherName { get; set; }
    public string HouseAddress { get; set; }
    public int NoOfSiblings { get; set; }
    public DateTime RegistrationDate { get; set; }

    public RegisterPerson(){

    }
    public RegisterPerson(string name,Gender gender,DateTime dob,long phoneNumber,Marital maritalStatus,string fatherName,string motherName,string houseAddress,int noOfSiblings):base(name,gender,dob,phoneNumber,maritalStatus){
        s_registerNumber++;
        RegisterNumber = s_registerNumber;
        FatherName = fatherName;
        MotherName = motherName;
        HouseAddress = houseAddress;
        NoOfSiblings = noOfSiblings;
        RegistrationDate = DateTime.Now;
    }

    public void ShowInfo(){
        System.Console.WriteLine($"Register Number\t: {RegisterNumber}");
        System.Console.WriteLine($"Name\t\t: {Name}");
        System.Console.WriteLine($"Gender\t\t: {PersonGender}");
        System.Console.WriteLine($"Date of Birth\t: {DateOfBirth.ToString("dd/MM/yyyy")}");
        System.Console.WriteLine($"Phone Number\t: {PhoneNumber}");
        System.Console.WriteLine($"Marital Status\t: {MaritalStatus}");
        System.Console.WriteLine($"Father Name\t: {FatherName}");
        System.Console.WriteLine($"Mother Name\t: {MotherName}");
        System.Console.WriteLine($"Address\t\t: {HouseAddress}");
        System.Console.WriteLine($"No of Siblings\t: {NoOfSiblings}");
        System.Console.WriteLine($"Registered Date\t: {RegistrationDate.ToString("dd/MM/yyyy")}");
    }
}