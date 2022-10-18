using System;
namespace DoctorPatient;
public class Appointment
{
    private static int s_appointmentID = 0;
    public int AppointmentID { get; }
    public int PatientID { get; set; }
    public int DoctorID { get; set; }
    public DateTime Date { get; set; }
    public string Problem { get; set; }
    public Appointment(){

    }
    public Appointment(int patientID,int doctorID,DateTime date,string problem){
        AppointmentID = ++s_appointmentID;
        PatientID = patientID;
        DoctorID = doctorID;
        Date = date;
        Problem = problem;
    }
}