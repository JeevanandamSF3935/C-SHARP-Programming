namespace VaccinationDrive;
public class Vaccination
{
    public static List<Vaccination> vaccinationsList = new List<Vaccination>();
    public static int s_vaccinationId = 1000;
    public string VaccinationID { get; }
    public string RegisterNumber { get; set; }
    public string VaccineID { get; set; }
    public int DoseNumber { get; set; }
    public DateTime VaccinatedDate { get; set; }
    public Vaccination(){

    }
    public Vaccination(string registerNumber, string vaccineID, DateTime vaccinatedDate, int doseNumber){
        s_vaccinationId++;
        VaccinationID = "VID" + s_vaccinationId;
        RegisterNumber = registerNumber;
        VaccineID = vaccineID;
        VaccinatedDate = vaccinatedDate;
        DoseNumber = doseNumber;
    }
}