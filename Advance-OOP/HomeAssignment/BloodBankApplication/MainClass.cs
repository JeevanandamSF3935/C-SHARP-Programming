namespace BloodBankApplication;
public class MainClass
{
    public static void Main(string[] args)
    {
        //Process.DefaultValues();
        //Files.CreateFile();
        Files.ReadFile();
        MenuClass.MainMenu();
        Files.WriteFile();
    }
}