namespace VaccinationDrive;
public enum VaccineName
{
    Default,Covaccine,Covishield
}
public class Vaccine
{
    public static List<Vaccine> vaccinesList = new List<Vaccine>();
    public static int s_vaccineID = 100;
    public string VaccineID { get; }
    public VaccineName VaccineTaken { get; set; }
    public int DoseAvailable { get; set; }
    public Vaccine(){

    }
    public Vaccine(VaccineName vaccineName, int doseAvailable){
        s_vaccineID++;
        VaccineID = "CID" + s_vaccineID;
        VaccineTaken = vaccineName;
        DoseAvailable = doseAvailable;
    }

    public static void ShowVaccine(){
        System.Console.WriteLine("Vaccine ID\tVaccineTaken\tNo of Dose Availabe");
        foreach(Vaccine vaccine in vaccinesList){
            System.Console.WriteLine($"{vaccine.VaccineID}\t\t{vaccine.VaccineTaken}\t{vaccine.DoseAvailable}");
        }
    }
}