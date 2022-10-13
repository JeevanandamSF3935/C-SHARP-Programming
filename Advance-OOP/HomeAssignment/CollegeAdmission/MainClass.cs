using System;
namespace CollegeAdmission;
public delegate void EventManager();
class MainClass{
    public static event EventManager eventlink = null;

    public static void Subscribe(){
        eventlink += new EventManager(Files.create);
        eventlink += new EventManager(Files.ReadFile);
        eventlink += new EventManager(MenuClass.Menu);
        eventlink += new EventManager(Files.WriteFile);
    }

    public static void StartEvent(){
        Subscribe();
        eventlink();
    }
    public static void Main(string[] args)
    {
        StartEvent();
    }
}