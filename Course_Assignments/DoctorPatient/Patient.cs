namespace DoctorPatient;
public class Patient
{
    public enum Gender
    {
        Default,Male,Female
    }
    private static int s_patientID = 0;
    public int PatientID { get; }
    public string Password { get; set; }
    public string PatientName { get; set; }
    public int PatientAge { get; set; }
    public Gender PatientGender { get; set; }
    public Patient(){

    }
    public Patient(string password, string patientName, int patientAge, Gender gender){
        PatientID = ++s_patientID;
        Password = password;
        PatientName = patientName;
        PatientAge = patientAge;
        PatientGender = gender;
    }
}