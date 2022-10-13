namespace MultipleInheritance;
public class MainClass
{
    public static void Main(string[] args)
    {
        RegisterPerson person = new RegisterPerson("Jeeva",Gender.Male,new DateTime(2001,01,24),8526764646,Marital.Single,"Perumal","Kalai Selvi","63, Silicon city, Hosur",1);
        person.ShowInfo();
    }
}