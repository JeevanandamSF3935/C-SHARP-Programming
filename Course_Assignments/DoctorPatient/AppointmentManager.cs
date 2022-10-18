using System;
using System.Collections.Generic;

namespace DoctorPatient;
public class AppointmentManager
{
    public static Patient currentLoggedInPatient;
    public static List<Doctor> doctorsList = new List<Doctor>();
    public static List<Patient> patientsList = new List<Patient>();
    public static List<Appointment> appointmentsList = new List<Appointment>();

    public static void MainMenu(){
        string continueChoice = "yes";
        do
        {
            System.Console.WriteLine("Enter the choice :\n1.Login\n2.Register\n3.Exit");
            int choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    Login();
                    break;
                }
                case 2:{
                    Register();
                    break;
                }
                case 3:{
                    continueChoice = "no";
                    break;
                }
            }
        } while (continueChoice == "yes");
    }

    public static void Register(){
        System.Console.WriteLine("Registration Page");
        System.Console.Write("Enter the Password : ");
        string password = Console.ReadLine();
        System.Console.Write("Enter the name : ");
        string name = Console.ReadLine();
        System.Console.Write("Enter the age : ");
        int age = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the gender : ");
        Patient.Gender gender = Enum.Parse<Patient.Gender>(Console.ReadLine(),true);
        Patient patient = new Patient(password,name,age,gender);
        patientsList.Add(patient);
        System.Console.WriteLine($"Registered Successfull\nPatient ID : {patient.PatientID}");
    }

    public static void Login(){
        bool loginCheck = true;
        System.Console.Write("Enter your PatientID : ");
        int patientID = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the Password : ");
        string password = Console.ReadLine();
        foreach(Patient patient in patientsList){
            if(patientID == patient.PatientID && password == patient.Password){
                System.Console.WriteLine("Login Successfull");
                loginCheck = true;
                currentLoggedInPatient = patient;
                SubMenu();
                break;
            }
            else{
                loginCheck = false;
            }
        }
        if(!loginCheck){System.Console.WriteLine("Invalid patientId or Password\nTry Again");}
    }

    public static void SubMenu(){
        int choice = 0;
        do
        {
            System.Console.WriteLine("Enter the Choice :\n1.Book Appointment\n2.View Appointment Details\n3.Edit My Profile\n4.Log Out");
            choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:{
                    BookAppointment();
                    break;
                }
                case 2:{
                    ViewAppointment();
                    break;
                }
                case 3:{
                    EditInfo();
                    break;
                }
                case 4:{
                    break;
                }
                default:{
                    System.Console.WriteLine("Invalid choice");
                    break;
                }
            }
        } while (choice != 4);
    }

    public static void BookAppointment(){
        System.Console.WriteLine("1. Anaesthesiology\n2. Cardiology\n3. Diabetology\n4. Neonatology\n5. Nephrology");
        System.Console.WriteLine("Select the Department");
        int departmentChoice = int.Parse(Console.ReadLine());
        string selectedDepartment = "";
        int doctorId = 0, appointmentCount = 0;
        switch(departmentChoice){
            case 1:{
                selectedDepartment = "Anaesthesiology";
                break;
            }
            case 2:{
                selectedDepartment = "Cardiology";
                break;
            }
            case 3:{
                selectedDepartment = "Diabetology";
                break;
            }
            case 4:{
                selectedDepartment = "Neonatology";
                break;
            }
            case 5:{
                selectedDepartment = "Nephrology";
                break;
            }
            default:{
                System.Console.WriteLine("Invalid Choice");
                break;
            }
        }
        foreach(Doctor doctor in doctorsList){
            if(doctor.Department == selectedDepartment){
                doctorId = doctor.DoctorID;
                break;
            }
        }
        foreach(Appointment appointment in appointmentsList){
            if(appointment.DoctorID == doctorId && appointment.Date.Date == DateTime.Now.Date){
                appointmentCount++;
            }
        }
        if(appointmentCount < 2){
            System.Console.Write("Enter your problem : ");
            string problem = Console.ReadLine();
            System.Console.WriteLine($"Appointment is confirmed for the date -{DateTime.Now.ToString("dd/MM/yyyy")}. To book press Y, To cancel press N");
            char appointmentChoice = char.Parse(Console.ReadLine().ToUpper());
            if(appointmentChoice == 'Y'){
                Appointment appointment = new Appointment(currentLoggedInPatient.PatientID,doctorId,DateTime.Now,problem);
                appointmentsList.Add(appointment);
                System.Console.WriteLine("Appointment Confirmed");
            }
        }
        else{
            System.Console.WriteLine("No appointment for today");
        }
    }

    public static void ViewAppointment(){
        int count = 0;
        System.Console.WriteLine("AppoinmentID\tPatientID\tDoctorID\tDate\t\tProblem");
        System.Console.WriteLine("--------------------------------------------------------------------------");
        foreach(Appointment appointment in appointmentsList){
            if(appointment.PatientID == currentLoggedInPatient.PatientID){
                System.Console.WriteLine($"{appointment.AppointmentID}\t\t{appointment.PatientID}\t\t{appointment.DoctorID}\t\t{appointment.Date.ToString("dd/MM/yyyy")}\t{appointment.Problem}");
                count++;
            }
        }
        if(count == 0){
            System.Console.WriteLine("\t\t\t\tNO APPOINTMENT BOOKED YET");
        }
    }

    public static void EditInfo(){
        foreach(Patient patient in patientsList){
            if(patient.PatientID == currentLoggedInPatient.PatientID){
                System.Console.Write("Enter your updating name : ");
                string name = Console.ReadLine();
                System.Console.Write("Enter your updating password : ");
                string password = Console.ReadLine();
                System.Console.Write("Enter your updating age : ");
                int age = int.Parse(Console.ReadLine());
                System.Console.Write("Enter your updating gender : ");
                Patient.Gender gender = Enum.Parse<Patient.Gender>(Console.ReadLine(),true);
                patient.Password = password;
                patient.PatientName = name;
                patient.PatientAge = age;
                patient.PatientGender = gender;
                System.Console.WriteLine("Updated Successfully");
                break;
            }
        }
    }

    public static void DefaultValues(){
        //Doctor Details
        Doctor doctor1 = new Doctor("Nancy","Anaesthesiology");
        Doctor doctor2 = new Doctor("Andrew","Cardiology");
        Doctor doctor3 = new Doctor("Janet","Diabetology");
        Doctor doctor4 = new Doctor("Margaret","Neonatology");
        Doctor doctor5 = new Doctor("Steven","Nephrology");
        doctorsList.Add(doctor1);
        doctorsList.Add(doctor2);
        doctorsList.Add(doctor3);
        doctorsList.Add(doctor4);
        doctorsList.Add(doctor5);

        //Patient Details
        Patient patient1 = new Patient("welcome","Robert",40,Patient.Gender.Male);
        Patient patient2 = new Patient("welcome","Laura",36,Patient.Gender.Female);
        Patient patient3 = new Patient("welcome","Anne",42,Patient.Gender.Female);
        patientsList.Add(patient1);
        patientsList.Add(patient2);
        patientsList.Add(patient3);

        //Appointment Details
        Appointment appointment1 = new Appointment(1,2,new DateTime(2012,03,28),"Heart problem");
        Appointment appointment2 = new Appointment(1,5,new DateTime(2012,03,08),"Spinal cord injury");
        Appointment appointment3 = new Appointment(2,2,new DateTime(2012,03,08),"Heart attack");
        appointmentsList.Add(appointment1);
        appointmentsList.Add(appointment2);
        appointmentsList.Add(appointment3);
    }
}