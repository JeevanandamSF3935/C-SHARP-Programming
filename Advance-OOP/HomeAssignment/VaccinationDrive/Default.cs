namespace VaccinationDrive;
public class Default
{
    public static void DefaultValues(){
        
        //benficiary default
        Benficiary benficiary1 = new Benficiary("Ravichandran", Gender.Male,8484484844,"Chennai",21);
        Benficiary benficiary2 = new Benficiary("Baskaran", Gender.Male,8484747477,"Chennai",22);
        Benficiary.benficiariesList.Add(benficiary1);
        Benficiary.benficiariesList.Add(benficiary2);

        //vaccine default
        Vaccine vaccine1 = new Vaccine(VaccineName.Covishield,50);
        Vaccine vaccine2 = new Vaccine(VaccineName.Covaccine,50);
        Vaccine.vaccinesList.Add(vaccine1);
        Vaccine.vaccinesList.Add(vaccine2);

        //vaccination default
        Vaccination vaccination1 = new Vaccination("BID1001","CID101",new DateTime(2021,11,11),1);
        Vaccination vaccination2 = new Vaccination("BID1001","CID101",new DateTime(2022,03,11),2);
        Vaccination vaccination3 = new Vaccination("BID1002","CID102",new DateTime(2022,04,04),1);
        Vaccination.vaccinationsList.Add(vaccination1);
        Vaccination.vaccinationsList.Add(vaccination2);
        Vaccination.vaccinationsList.Add(vaccination3);
    }
}