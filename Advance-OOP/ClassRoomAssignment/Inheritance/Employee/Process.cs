
namespace Employee;
public class Process
{
    public static List<PersonalDetails> personsList = new List<PersonalDetails>();
    
    public static void DefaultValues(){
        PersonalDetails person = new PersonalDetails("Jeeva","Perumal",Gender.Male,8526764646);
        personsList.Add(person);
    }
}