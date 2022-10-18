
namespace OOPConcepts;
public interface IEMI
{
    double Interest { get; set; }
    int NoOfMonths { get; set; }
    double CalculateEMI(double price);
}