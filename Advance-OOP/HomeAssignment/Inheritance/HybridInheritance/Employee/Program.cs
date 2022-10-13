namespace Exercise3;

class program 
{
    public static void Main(string[] args)
    {
        RegisterApplication obj = new RegisterApplication("REG098", 9, "Computer", "M9393", "BE", "CSE", "VK", Gender.Male, new DateTime(2021, 11, 10), 098098, 80798798, "VK", "UR", "Pbibib");
        obj.ShowDetails();
    }
}