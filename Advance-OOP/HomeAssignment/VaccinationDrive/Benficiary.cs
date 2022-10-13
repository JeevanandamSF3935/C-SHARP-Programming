namespace VaccinationDrive;
public enum Gender
{
    Default,Male,Female,Transgender
}
public class Benficiary
{
    public static List<Benficiary> benficiariesList = new List<Benficiary>();
    public static int s_registerNumber = 1000;
    public string RegisterNumber { get; }
    public string Name { get; set; }
    public Gender BenficiaryGender { get; set; }
    public long PhoneNumber { get; set; }
    public string City { get; set; }
    public int Age { get; set; }
    
    public Benficiary(){

    }
    public Benficiary(string name, Gender gender, long phoneNumber,string city, int age){
        s_registerNumber++;
        RegisterNumber = "BID"+s_registerNumber;
        Name = name;
        BenficiaryGender = gender;
        PhoneNumber = phoneNumber;
        City = city;
        Age = age;
    }

    public static void ShowDetails(Benficiary benificiary){
        System.Console.WriteLine("Register Number\tBenificiary Name\tGender\tPhone Number\tCity\tAge");
        System.Console.WriteLine($"{benificiary.RegisterNumber}\t\t{benificiary.Name}\t\t{benificiary.BenficiaryGender}\t{benificiary.PhoneNumber}\t{benificiary.City}\t{benificiary.Age}\n");
    }

    public static int DoseCount(Benficiary benficiary){
        int count = 0;
        foreach(Vaccination vaccine in Vaccination.vaccinationsList){
            if(vaccine.RegisterNumber == benficiary.RegisterNumber){
                count++;
            }
        }
        foreach(Vaccination vaccine1 in Vaccination.vaccinationsList){
        }
        return count;
    }

    public static void ShowHistory(Benficiary benficiary){
        System.Console.WriteLine("Vaccine ID\tRegister Number\tVaccineID\tNo of Dose Availabe\tVaccinated Date");
        foreach(Vaccination vaccine1 in Vaccination.vaccinationsList){
            if(vaccine1.RegisterNumber == benficiary.RegisterNumber){
                System.Console.WriteLine($"{vaccine1.VaccinationID}\t\t{vaccine1.RegisterNumber}\t\t{vaccine1.VaccineID}\t\t\t{vaccine1.DoseNumber}\t\t{vaccine1.VaccinatedDate.ToString("dd/MM/yyyy")}\t");
            }
        }
    }

}