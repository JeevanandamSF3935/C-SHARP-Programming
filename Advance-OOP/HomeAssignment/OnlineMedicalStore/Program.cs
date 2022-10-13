using System;
namespace OnlineMedicalStore;
class Program
{
    public static void Main(string[] args)
    {
        Files.CreateFile();
        Files.ReadFile();
        MenuClass.MainMenu();
        Files.WriteFile();
    }
}