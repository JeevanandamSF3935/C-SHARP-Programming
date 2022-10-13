namespace OperatorOverloading;
public class Box
{
    private double length;
    private double breadth;
    private double height;
    public Box(){

    }
    public Box(double length1,double breadth1, double height1){
        length = length1;
        breadth = breadth1;
        height = height1;
    }
    public double Volume(){
        double volume = length * breadth * height;
        return volume;
    }

    public static Box operator +(Box b,Box c){
        Box box = new Box();
        box.length = b.length + c.length;
        box.breadth = b.breadth + c.breadth;
        box.height = b.height + c.height;
        return box;
    }

    public static Box operator *(Box b,Box c){
        Box box = new Box();
        box.length = b.length * c.length;
        box.breadth = b.breadth * c.breadth;
        box.height = b.height * c.height;
        return box;
    }
}