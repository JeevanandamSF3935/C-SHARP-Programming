namespace BloodBankApplication;
public class Process
{
    public static List<Registration> donorsList = new List<Registration>();
    public static List<Donation> donationsList = new List<Donation>();

    public static void DefaultValues(){
        //registration default values
        Registration donor1 = new Registration("Jeeva",8526764646,BloodGroupEnum.B_Positive,22,new DateTime(2022,06,15));
        Registration donor2 = new Registration("Priya",9677854019,BloodGroupEnum.B_Positive,21,new DateTime(2022,10,01));
        donorsList.Add(donor1);
        donorsList.Add(donor2);
    }
    public static void UserRegister(){
        BloodGroupEnum bloodGroup;
        System.Console.Write("Enter your name : ");
        string donorName = Console.ReadLine();
        System.Console.Write("Enter your age : ");
        int age = int.Parse(Console.ReadLine());
        System.Console.Write("Enter mobile number : ");
        long mobileNumber = long.Parse(Console.ReadLine());
        System.Console.Write("Enter your blood group : ");
        bool temp = BloodGroupEnum.TryParse(Console.ReadLine(),true,out bloodGroup);
        while(!temp){
            System.Console.WriteLine("Invalid entry!!!\nEnter again");
            temp = BloodGroupEnum.TryParse(Console.ReadLine(),true,out bloodGroup);
        }
        System.Console.Write("Enter the date of last donation : ");
        DateTime dateOfLastDonation = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Registration donor = new Registration(donorName,mobileNumber,bloodGroup,age,dateOfLastDonation);
        donorsList.Add(donor);
        System.Console.WriteLine($"Registered successfully!\nYour DonorID is {donor.DonorID}");
    }

    public static void Login(){
        bool loginCheck = true;
        System.Console.Write("Enter your DonorID : ");
        string donorID = Console.ReadLine().ToUpper();
        foreach(Registration donor in donorsList){
            loginCheck = true;
            if(donor.DonorID == donorID){
                System.Console.WriteLine("Login Successfull");
                MenuClass.SubMenu(donor);
                break;
            }
            else{
                loginCheck = false;
            }
        }
        if(!loginCheck){
            System.Console.WriteLine("Login Unsuccessfull");
        }
    }

    public static void ShowDonors(){
        int donorCount = 0;
        BloodGroupEnum bloodGroup;
        System.Console.Write("Enter the blood group needed (Formate : O_Positive) : ");
        bool temp = BloodGroupEnum.TryParse(Console.ReadLine(),true,out bloodGroup);
        while(!temp){
            System.Console.WriteLine("Invalid formate!\nEnter again!");
            temp = BloodGroupEnum.TryParse(Console.ReadLine(),true,out bloodGroup);
        }
        System.Console.WriteLine("Donor_Name\tMoblie Number");
        foreach(Registration donor in donorsList){
            if(donor.BloodGroup == bloodGroup){
                System.Console.WriteLine($"{donor.DonorName}\t\t{donor.MobileNumber}");
                donorCount++;
            }
        }
        if(donorCount == 0){
            System.Console.WriteLine($"Donor not found for the blood group {bloodGroup}");
        }
    }

    public static void DonateBlood(Registration donor){
        System.Console.Write("Enter your weight : ");
        double weight = double.Parse(Console.ReadLine());
        System.Console.Write("Enter your blood pressure : ");
        double bloodPressure = double.Parse(Console.ReadLine());
        System.Console.Write("Enter the hemoglobin count : ");
        double hemoglobinCount = double.Parse(Console.ReadLine());
        if(weight > 50 && bloodPressure < 130 && hemoglobinCount > 13.5){
            if(donor.LastDonation.AddDays(60) < DateTime.Now){
                Donation donation = new Donation(donor.DonorID,DateTime.Now,weight,bloodPressure,hemoglobinCount);
                donationsList.Add(donation);
            }
            else{
                System.Console.WriteLine($"You recently donated blood\nYour next date is {donor.LastDonation.AddDays(60).ToString("dd/MM/yyyy")}");
            }
        }
        else{
            System.Console.WriteLine("You are not eligible for donation");
        }
    }

    public static void DonationHistory(Registration donor){
        System.Console.WriteLine("DonationID\tDonorID\t\tDonation Date\tWeight\tBlood Pressure\tHemoglobin Count");
        foreach(Donation donation in donationsList){
            if(donation.DonorID == donor.DonorID){
                System.Console.WriteLine($"{donation.DonationID}\t\t{donation.DonorID}\t{donation.DonationDate.ToString("dd/MM/yyyy")}\t{donation.Weight}\t{donation.BloodPressure}\t\t{donation.HemoglobinCount}");
            }
        }
    }

    public static void NextDueDate(Registration donor){
        DateTime dueDate = donor.LastDonation.AddDays(60);
        if(dueDate < DateTime.Now){
            System.Console.WriteLine($"Your next due is {DateTime.Now.ToString("dd/MM/yyyy")}");
        }
        else{
            System.Console.WriteLine($"Your next due is {dueDate.ToString("dd/MM/yyyy")}");
        }
    }

}