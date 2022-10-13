namespace BloodBankApplication;
public class Donation
{
    public static int s_donationId = 1000;
    public string DonationID { get; }
    public string DonorID { get; set; }
    public DateTime DonationDate { get; set; }
    public double Weight { get; set; }
    public double BloodPressure { get; set; }
    public double HemoglobinCount { get; set; }
    
    public Donation(){

    }
    
    public Donation(string donorID,DateTime donationDate,double weight,double bloodPressure,double hemoglobinCount){
        s_donationId++;
        DonationID = "DID" + s_donationId;
        DonorID = donorID;
        DonationDate = donationDate;
        Weight = weight;
        BloodPressure = bloodPressure;
        HemoglobinCount = hemoglobinCount;
    }

    public Donation(string donor){
        string[] values = donor.Split(',');
        s_donationId = int.Parse(values[0].Remove(0,3));
        DonationID = values[0];
        DonorID = values[1];
        DonationDate = DateTime.ParseExact(values[2],"dd/MM/yyyy",null);
        Weight = double.Parse(values[3]);
        BloodPressure = double.Parse(values[4]);
        HemoglobinCount = double.Parse(values[5]);
    }

}