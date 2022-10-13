
namespace Multipath
{
    public interface IHSCInfo : IPersonalInfo
    {
        int HSCMarksheetNumber { get; set; }

        int Physics { get; set; }

        int Chemistry { get; set; }

        int Maths { get; set; }

        double HSCTotal { get; set; }

        double PercentageMarks { get; set; }

        void ShowHSCMarkSheet();

        void CalculateHSC();



    }
}