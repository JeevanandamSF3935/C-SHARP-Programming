namespace BloodBankApplication;
public enum BloodGroupEnum
{
    Default,A_Positive,B_Positive,O_Positive,AB_Positive
}
public class Registration
{
    public static int s_donorID = 1000;
    public string DonorID { get; }
    public string DonorName { get; set; }
    public long MobileNumber { get; set; }
    public BloodGroupEnum BloodGroup{ get; set; }
    public int Age { get; set; }
    public DateTime LastDonation { get; set; }
    public Registration(){

    }
    public Registration(string donorName,long mobileNumber,BloodGroupEnum bloodGroup,int age,DateTime lastDonation){
        s_donorID++;
        DonorID = "DOID" + s_donorID;
        DonorName = donorName;
        MobileNumber = mobileNumber;
        BloodGroup = bloodGroup;
        Age = age;
        LastDonation = lastDonation;
    }

    public Registration(string data){
        string[] values = data.Split(',');
        s_donorID = int.Parse(values[0].Remove(0,4));
        DonorID = values[0];
        DonorName = values[1];
        MobileNumber = long.Parse(values[2]);
        BloodGroup = Enum.Parse<BloodGroupEnum>(values[3]);
        Age = int.Parse(values[4]);
        LastDonation = DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
    }


}