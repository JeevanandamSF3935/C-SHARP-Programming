using System;
namespace StudentManagement;
class MainClass
{
    public static void Main(string[] args)
    {

        StudentInfo student = new StudentInfo("Jeeva","Perumal",8526764646,"jeeva@gmail.com",new DateTime(2001,01,24),Gender.Male,6,Branch.CSE,new DateTime(2022,01,01));
        Teacher teacher = new Teacher("Prakash","Kalimuthu",8976765434,"prakash@gmail.com",new DateTime(1989,05,31),Gender.Male,Branch.CSE,"Data Structures","M.E.",6,new DateTime(2016,06,21));
        PrincipalInfo prinipal = new PrincipalInfo("Sumathi","Suresh",874523435,"sumathi@gmail.com",new DateTime(1976,02,23),Gender.Female,"M.E.,Ph.D",16,new DateTime(2006,03,16));

        System.Console.WriteLine("\n****Student Details****");
        student.ShowInfo();
        System.Console.WriteLine("\n\n");
        System.Console.WriteLine("****Teacher Details****");
        teacher.ShowInfo();
        System.Console.WriteLine("\n\n");
        System.Console.WriteLine("****Principal Details****");
        prinipal.ShowInfo();
                
    }
}
