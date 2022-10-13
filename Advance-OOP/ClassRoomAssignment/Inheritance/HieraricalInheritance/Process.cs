namespace HieraricalInheritance;
public class Process
{
    public static List<PersonalDetails> personsList = new List<PersonalDetails>();
    
    public static void DefaultValues(){
        PersonalDetails person = new PersonalDetails("Jeeva","Perumal",Gender.Male,8526764646);
        personsList.Add(person);
        

        StudentDetails student = new StudentDetails("AID1001","Jeeva","Perumal",Gender.Male,8526764646,Department.CSE,"Final Year");
        student.ShowStudent();

        CustomerDetails customer = new CustomerDetails("Jeeva","Perumal",Gender.Male,852676464);
        customer.Recharge();
        customer.ShowCustomer();
    }
}