using System;

namespace StudentDetails;

class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("STUDENT REGISTRATION");
        Console.WriteLine("Enter your name : ");
        String studentName = Console.ReadLine();
        Console.WriteLine("Enter your Father's name : ");
        String fatherName = Console.ReadLine();
        Console.WriteLine("Enter your age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your mobile number : ");
        String mobileNumber = Console.ReadLine();
        Console.WriteLine("Enter your Mail-Id :");
        String mailId = Console.ReadLine();
        Console.WriteLine("Gender - enter 'M' for Male and 'F' for Female :");
        String gender = Console.ReadLine();
        Console.WriteLine("Enter your Chemistry mark out of 200");
        int chemistryMark = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Physics mark out of 200");
        int physicsMark = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your Maths mark out of 200");
        int mathsMark = Convert.ToInt32(Console.ReadLine());
        double average = (double)(chemistryMark+physicsMark+mathsMark)/3;
        average = Math.Round(average,2);
        double percentage = (double)(chemistryMark+physicsMark+mathsMark)/600*100;
        percentage = Math.Round(percentage,2);
        if(gender == "M"){
            gender = "Male";
        }
        else if(gender == "F"){
            gender = "Female";
        }
        Console.WriteLine($"Name \t\t: {studentName} \nFather name \t: {fatherName} \nAge \t\t: {age} \nMobile Number \t: {mobileNumber} \nMail-ID \t: {mailId} \nGender \t\t: {gender} \nChemistry Mark \t: {chemistryMark} \nPhysics Mark \t: {physicsMark} \nMaths Mark \t: {mathsMark} \nAverage \t: {average} \nPercentage \t: {percentage}%");
    }
}