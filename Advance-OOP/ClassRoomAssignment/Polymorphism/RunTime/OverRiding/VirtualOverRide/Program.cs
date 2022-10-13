namespace SealedMethods;
public class MyClass
{
    public static void Main(string[] args)
    {
        Animal animal1 = new Animal();
        animal1.MakeSound();
        Dog dog1 = new Dog();
        dog1.MakeSound();
    }
}