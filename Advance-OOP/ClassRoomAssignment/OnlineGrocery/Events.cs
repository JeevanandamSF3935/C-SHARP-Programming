using System;

namespace OnlineGrocery;
public delegate void Function();
public class Events
{
    public static event Function eventLink = null;
    public static void EventHandler(){
        eventLink();
    }
}