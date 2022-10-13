
namespace BloodBankApplication;
public class Files
{
    public static void CreateFile(){
        if(!Directory.Exists("BloodBank")){
            System.Console.WriteLine("Creating Folder...");
            Directory.CreateDirectory("BloodBank");
        }
        else{
            System.Console.WriteLine("Folder Already Exists!!!");
        }

        if(!File.Exists("BloodBank\\DonarsDetails.csv")){
            System.Console.WriteLine("Creating file...");
            File.Create("BloodBank\\DonarsDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }

        if(!File.Exists("BloodBank\\DonationDetails.csv")){
            System.Console.WriteLine("Creating File...");
            File.Create("BloodBank\\DonationDetails.csv");
        }
        else{
            System.Console.WriteLine("File Already Exists!!!");
        }
    }

    public static void ReadFile(){

        string[] donars = File.ReadAllLines("BloodBank\\DonarsDetails.csv");
        foreach(string donar in donars){
            Registration donor1 = new Registration(donar);
            Process.donorsList.Add(donor1);
        }

        string[] donations = File.ReadAllLines("BloodBank\\DonationDetails.csv");
        foreach(string donation in donations){
            Donation donation1 = new Donation(donation);
            Process.donationsList.Add(donation1);
        }
    }

    public static void WriteFile(){
        string[] donations = new string[Process.donationsList.Count];
        for(int i = 0;i < Process.donationsList.Count;i++){
            donations[i] = Process.donationsList[i].DonationID+","+Process.donationsList[i].DonorID+","+Process.donationsList[i].DonationDate.ToString("dd/MM/yyyy")+","+Process.donationsList[i].Weight+","+Process.donationsList[i].BloodPressure+","+Process.donationsList[i].HemoglobinCount;
        }
        File.WriteAllLines("BloodBank\\DonationDetails.csv",donations);

        string[] donors = new string[Process.donorsList.Count];
        for(int i = 0;i < Process.donorsList.Count;i++){
            donors[i] = Process.donorsList[i].DonorID+","+Process.donorsList[i].DonorName+","+Process.donorsList[i].MobileNumber+","+Process.donorsList[i].BloodGroup+","+Process.donorsList[i].Age+","+Process.donorsList[i].LastDonation.ToString("dd/MM/yyyy");
        }
        File.WriteAllLines("BloodBank\\DonarsDetails.csv",donors);
    }
}