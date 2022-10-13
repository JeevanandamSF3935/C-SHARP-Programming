namespace MultiLevelInheritance;
public interface IMarkDetails
{

    //No field, constructor and object
    double Physics { get; set; }
    double Chemistry { get; set; }
    double Maths { get; set; }
    double Total { get; set; }
    double Average { get; set; }
    double Percentage{ get; set; }

    void Calculate();
    void GetMark(double physics,double chemistry, double maths);
    void Show();

}