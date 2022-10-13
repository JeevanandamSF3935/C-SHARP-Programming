namespace LibraryManagement;
public enum Gender
{
    Default,Male,Female,Transgender
}
public enum Department
{
    Default,ECE,CSE,EEE
}
public class UserDetails
{
    public static int s_registerID = 3000;
    public string RegisterID { get; }
    public string UserName { get; set; }
    public Gender UserGender { get; set; }
    public Department UserDepartment { get; set; }
    public long PhoneNumber { get; set; }
    public string MailID { get; set; }
    public int WalletBalance { get; set; }
    public UserDetails(){

    }
    public UserDetails(string userName,Gender userGender,Department userDepartment,long phoneNumber,string mailID){
        s_registerID++;
        RegisterID = "SF" + s_registerID;
        UserName = userName;
        UserGender = userGender;
        UserDepartment = userDepartment;
        PhoneNumber = phoneNumber;
        MailID = mailID;
        WalletBalance = 0;
    }
}