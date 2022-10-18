using System;
using System.Linq;
using System.Collections.Generic;
namespace Assignment2;
class Program
{
    public static List<Places> placesList = new List<Places>();
    public static void Main(string[] args)
    {
        GetPlaces();
        IEnumerable<string> data = from item in placesList
                    orderby item.Place.Length ascending
                    select item.Place.ToString();
        

        for(int iterator = 0; iterator < data.Count();iterator++){
            System.Console.WriteLine(data.ElementAt(iterator));
        }
        
    }

    public static List<Places> GetPlaces(){
        
        Places place1 = new Places("ABU DHABI");
        Places place2 = new Places("AMSTERDAM");
        Places place3 = new Places("ROME");
        Places place4 = new Places("PARIS");
        Places place5 = new Places("CALIFORNIA");
        Places place6 = new Places("LONDON");
        Places place7 = new Places("NEW DELHI");
        Places place8 = new Places("ZURICH");
        Places place9 = new Places("NAIROBI");
        placesList.Add(place1);
        placesList.Add(place2);
        placesList.Add(place3);
        placesList.Add(place4);
        placesList.Add(place5);
        placesList.Add(place6);
        placesList.Add(place7);
        placesList.Add(place8);
        placesList.Add(place9);

        return placesList;
    }

}










