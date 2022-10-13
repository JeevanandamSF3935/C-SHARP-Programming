namespace ECommerce;
class MainClass
{
    public static void Main(string[] args)
    {
        Files.ReadFile();
        MenuClass.MainMenu();
        Files.WriteFile();
    }
}