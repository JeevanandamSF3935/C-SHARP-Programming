using System;

namespace Exercise4;

class Program 
{
    public static void Main(string[] args)
    {
        DefaultValue();
    }

    static void DefaultValue()
    {
        BookInfo obj = new BookInfo("BID101", "Game of Thrones", "XYZ", 120, "CSE", "B.E");
        obj.ShowDetails();

        BookInfo obj1 = new BookInfo("BID102", "Poniyin Selvan", "Kalki", 1000, "CSE", "B.E");
        obj.ShowDetails();

    }
}