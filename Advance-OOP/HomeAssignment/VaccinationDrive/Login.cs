namespace VaccinationDrive;
public class Login
{
    public static void BenficiaryLogin(){
        bool flag = true;
        System.Console.Write("Enter your register number : ");
        string registerNumber = Console.ReadLine();
        foreach(Benficiary benficiary in Benficiary.benficiariesList){
            if(benficiary.RegisterNumber == registerNumber){
                System.Console.WriteLine("Login Successfull");
                MenuClass.SubMenu(benficiary);
            }
            else{
                flag = false;
            }
        }
        if(!flag){
            System.Console.WriteLine("Login unsuccessfull");
        }
    }

    public static void TakeVaccine(Benficiary benficiary){
        Vaccine.ShowVaccine();
        DateTime vacinatedDate = new DateTime();
        bool vaccineCheck = false;
        int doseNumber = 0;
        int count = Benficiary.DoseCount(benficiary);
        System.Console.Write("Enter the vacination ID : ");
        string vaccineID = Console.ReadLine();
        foreach(Vaccine vaccine in Vaccine.vaccinesList){
            vaccineCheck = true;
            if(count == 3){
                System.Console.WriteLine("All the three Vaccination course are completed you cannot be vaccinated now");
            }
            else if(count > 0 || count < 3){
                foreach(Vaccination vaccine1 in Vaccination.vaccinationsList){
                    if(vaccine1.RegisterNumber == benficiary.RegisterNumber){
                        vacinatedDate = vaccine1.VaccinatedDate;
                    }
                }
                if(count == 1){
                    if(vaccineID == vaccine.VaccineID){
                        if(vacinatedDate.AddDays(30) <= DateTime.Now){
                            vaccineCheck = true;
                            doseNumber = 0;
                            System.Console.WriteLine("You are elgible for vaccination");
                            vaccine.DoseAvailable--;
                            doseNumber = 2;
                            Vaccination vaccine1 = new Vaccination(benficiary.RegisterNumber,vaccineID,DateTime.Now,doseNumber);
                            Vaccination.vaccinationsList.Add(vaccine1);
                            System.Console.WriteLine($"You vaccinated successfully.");
                            break;
                        }
                        else{
                            System.Console.WriteLine($"Your due date is {vacinatedDate.AddDays(30).ToString("dd/MM/yyyy")}");
                            break;
                        }
                    }
                    else{
                        vaccineCheck = false;
                        System.Console.WriteLine($"You have selected different vaccine.\nYou can vaccine with {vaccine.VaccineTaken}");
                    }
                }
                else if(count == 2){
                    if(vaccineID == vaccine.VaccineID){
                        if(vacinatedDate.AddDays(30) <= DateTime.Now){
                            vaccineCheck = true;
                            doseNumber = 0;
                            System.Console.WriteLine("You are elgible for vaccination");
                            vaccine.DoseAvailable--;
                            doseNumber = 3;
                            Vaccination vaccine1 = new Vaccination(benficiary.RegisterNumber,vaccineID,DateTime.Now,doseNumber);
                            Vaccination.vaccinationsList.Add(vaccine1);
                            System.Console.WriteLine($"You vaccinated successfully.");
                            break;
                        }
                        else{
                            System.Console.WriteLine($"Your due date is {vacinatedDate.AddDays(30).ToString("dd/MM/yyyy")}");
                            break;
                        }
                    }
                    else{
                        vaccineCheck = false;
                        System.Console.WriteLine($"You have selected different vaccine.\nYou can vaccine with {vaccine.VaccineTaken}");
                    }
                }
            }
            else{
                if(vaccineID == vaccine.VaccineID){
                    if(vacinatedDate.AddDays(30) <= DateTime.Now){
                        vaccineCheck = true;
                        doseNumber = 0;
                        System.Console.WriteLine("You are elgible for vaccination");
                        vaccine.DoseAvailable--;
                        doseNumber = 1;
                        Vaccination vaccine1 = new Vaccination(benficiary.RegisterNumber,vaccineID,DateTime.Now,doseNumber);
                        Vaccination.vaccinationsList.Add(vaccine1);
                        System.Console.WriteLine($"You vaccinated successfully.");
                    }
                    else{
                        System.Console.WriteLine($"Your due date is {vacinatedDate.AddDays(30).ToString("dd/MM/yyyy")}");
                    }
                }
                else{
                    vaccineCheck = false;
                    System.Console.WriteLine($"You have selected different vaccine.\nYou can vaccine with {vaccine.VaccineTaken}");
                }
            }
        }
        if(!vaccineCheck){
            System.Console.WriteLine("Vaccine ID not valid");
        }
    }

    public static void NextDue(Benficiary benficiary){
        DateTime vaccinatedDate = new DateTime();
        int dose = 0;
        foreach(Vaccination vaccine in Vaccination.vaccinationsList){
            if(vaccine.RegisterNumber == benficiary.RegisterNumber){
                vaccinatedDate = vaccine.VaccinatedDate;
                dose = vaccine.DoseNumber;
            }
        }
        if(dose == 0){
            System.Console.WriteLine($"Your Due is {DateTime.Now.ToString("dd/MM/yyyy")}");
        }
        else if(dose < 3 ){
            System.Console.WriteLine($"Your Due date is {vaccinatedDate.AddDays(30).ToString("dd/MM/yyyy")}");
        }
        else{
            System.Console.WriteLine("You have completed the vaccination dosage");
        }
    }
    
}