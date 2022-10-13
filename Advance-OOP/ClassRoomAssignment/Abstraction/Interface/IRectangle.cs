namespace Interface;
public interface IRectangle
{
    double Length { get; set; }
    double Breadth { get; set; }
    void CalculateArea();
    void GetData(double length,double breadth);
    void Show();
}