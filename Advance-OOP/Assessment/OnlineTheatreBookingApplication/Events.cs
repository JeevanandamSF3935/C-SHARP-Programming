namespace OnlineTheatreBookingApplication;
public delegate void Function();
public class Events
{
    public static event Function eventlink = null;

    public static void HandleEvent(){
        eventlink();
    }
}