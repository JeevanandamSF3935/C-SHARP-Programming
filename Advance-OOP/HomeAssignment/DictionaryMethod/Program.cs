namespace DictionaryMethod;
public class Program
{
    public static void Main(string[] args)
    {
        string data = "";
        Dictionary<int,string> dict = new Dictionary<int, string>();
        dict.Add(1,"Jeeva");
        dict.Add(1,"Bharath");
        dict.Add(2,"Vikram");
        bool temp = dict.ContainsKey(2);
        System.Console.WriteLine(temp);
        bool temp1 = dict.ContainsValue("Vikram");
        System.Console.WriteLine(temp1);
        bool temp2 = dict.TryGetValue(2,out data);
        System.Console.WriteLine(temp2+" "+data);
        System.Console.WriteLine(dict[1] = "Dinesh");
        foreach(KeyValue<int,string> dict1 in dict){
            System.Console.WriteLine("Key : "+ dict1.Key+", Value : "+dict1.Value);
        }
    }
}