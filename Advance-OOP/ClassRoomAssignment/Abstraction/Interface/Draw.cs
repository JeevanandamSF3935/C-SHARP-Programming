namespace Interface;
public class Draw:IRectangle
{
    public double Area { get; set; }
    public double Length{ get; set; }
    public double Breadth{ get; set; }

    public Draw(){

    }

    /*public Draw(double length,double breadth){
        Length = length;
        Breadth = breadth;
    }*/
    public void CalculateArea(){
        Area = Length * Breadth;
    }

    public void GetData(double length,double breadth){
        Length = length;
        Breadth = breadth;
    }
    public void Show(){
        System.Console.WriteLine($"Area : {Area}");
    }
}