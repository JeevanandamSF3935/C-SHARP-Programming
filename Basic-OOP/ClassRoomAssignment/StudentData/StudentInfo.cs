namespace StudentData;

public static class StudentInfo{
    public static string Name{ get; set; }
    public static int s_registerNumber;
    static StudentInfo(){
        Name = Console.ReadLine();
        s_registerNumber = int.Parse(Console.ReadLine());
    }
    public static void ShowDetails(){
        System.Console.WriteLine($"Name \t\t: {Name}");
        System.Console.WriteLine($"Register Number : {s_registerNumber}");
    }
}