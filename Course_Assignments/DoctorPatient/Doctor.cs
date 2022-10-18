namespace DoctorPatient;
public class Doctor
{
    private static int s_doctorID = 0;
    public int DoctorID { get; }
    public string DoctorName { get; set; }
    public string Department { get; set; }
    public Doctor(){

    }
    public Doctor(string doctorName,string department){
        DoctorID = ++s_doctorID;
        DoctorName = doctorName;
        Department = department;
    }
}