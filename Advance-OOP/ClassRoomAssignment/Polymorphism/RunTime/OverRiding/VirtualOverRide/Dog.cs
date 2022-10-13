namespace SealedMethods;
public class Dog:Animal
{
    public override void MakeSound(){
        System.Console.WriteLine("Dog Sound");
    }

    /*sealed method
    public new void MakeSound(){
        System.Console.WriteLine("Dog Sound");
    }   
    */
}