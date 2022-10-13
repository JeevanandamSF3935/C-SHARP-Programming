namespace MultiLevelInheritance;
public class Process
{
    
    public static void DefaultValues(){
        /*PersonalDetails person = new PersonalDetails("Jeeva","Perumal",Gender.Male,8526764646);
        System.Console.WriteLine("******PERSONAL DETAILS******");
        person.ShowDetails();*/
        

        /*StudentDetails student = new StudentDetails("AID1001","Jeeva","Perumal",Gender.Male,8526764646,Department.CSE,"Final Year");
        student.ShowStudent();
        student.GetMark(98,96,90);
        student.Calculate();*/

        EmployeeDetails employee = new EmployeeDetails("SID1001","AID1001","Jeeva","Perumal",Gender.Male,8526764646,Department.CSE);
        employee.ShowEmployee();
        /*CustomerDetails customer = new CustomerDetails("Jeeva","Perumal",Gender.Male,852676464);
        customer.Recharge();
        customer.ShowCustomer();*/

    }
}