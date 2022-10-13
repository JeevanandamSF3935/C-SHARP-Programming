using Outside;
namespace Inside;
public class Program:Third
{
    public static void Main(string[] args)
    {
        First number = new First();
        Second number1 = new Second();
        Third number3 = new Third();
        System.Console.WriteLine(number.PublicNumber);
        //System.Console.WriteLine(number.PrivateNumber);
        System.Console.WriteLine(number.PrivateMethod());
        System.Console.WriteLine(number.InternalNumber);
        //System.Console.WriteLine(number.ProtectedMethod());
        System.Console.WriteLine(number1.ProtectedProperty);
        //System.Console.WriteLine(number3.ProtectedInternalNumber);
        
    }
    public int Method(){
            return ProtectedInternalNumber;
        }
    
}