namespace OnlineTheatreBookingApplication;
class Program
{
    public static void Main(string[] args)
    {
        Events.eventlink += new Function(Files.CreateFile);
        Events.eventlink += new Function(Files.ReadFile);
        Events.eventlink += new Function(Operations.MainMenu);
        Events.eventlink += new Function(Files.WriteFile);
        Events.HandleEvent();
    }
}