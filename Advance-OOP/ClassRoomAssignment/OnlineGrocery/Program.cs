using System;
namespace OnlineGrocery;
class Program
{
    public static void Main(string[] args)
    {
        Events.eventLink += new Function(Files.CreateFile);
        Events.eventLink += new Function(Files.ReadFile);
        Events.eventLink += new Function(Operations.MainMenu);
        Events.eventLink += new Function(Files.WriteFile);
        Events.EventHandler();
    }

}