namespace PartialClass;
class Program
{
    public static void Main(string[] args)
    {
        StudentsDetails student = new StudentsDetails("Jeeva","Perumal",new DateTime(2001,01,24),Gender.Male,8526764646, "jeeva@gmail.com", 85, 75,89);
        System.Console.WriteLine($"Eligibility \t: {student.EligibilityCheck(75.0)}");
        student.ShowDetails();
    }
}