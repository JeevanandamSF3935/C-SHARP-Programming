namespace VaccinationDrive;
public class Registration
{
    public static void  BenficiaryRegister(){
        Gender gender;
        System.Console.Write("Enter the name : ");
        string name = Console.ReadLine();
        System.Console.Write("Enter the age : ");
        int age = int.Parse(Console.ReadLine());
        System.Console.Write("Enter the gender (Male or Female or Transgender) : ");
        bool temp = Gender.TryParse(Console.ReadLine(),true,out gender);
        while(!temp){
            System.Console.Write("Invalid data\nEnter again : ");
            temp = Gender.TryParse(Console.ReadLine(),true,out gender);
        }
        System.Console.Write("Enter the mobile number : ");
        long phoneNumber = long.Parse(Console.ReadLine());
        System.Console.Write("Enter the city : ");
        string city = Console.ReadLine();
        Benficiary benificiary = new Benficiary(name,gender,phoneNumber,city,age);
        Benficiary.benficiariesList.Add(benificiary);
        System.Console.WriteLine($"Registered successfully!\nYour Registration Number : {benificiary.RegisterNumber}");
    }
}