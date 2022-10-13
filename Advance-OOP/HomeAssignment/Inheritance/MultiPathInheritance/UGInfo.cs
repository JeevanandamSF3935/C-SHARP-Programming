
namespace Multipath
{
    public interface IUGInfo : IPersonalInfo
    {
         int UGMarksheetNumber { get; set; }

         int Sem1 { get; set; }

         int Sem2 { get; set; }

         int Sem3 { get; set; }

         int Sem4 { get; set; }

         double UGTotal { get; set; } 

         double Percentage { get; set; }

        void ShowUGMarkSheet();

        void CalculateUG();
    }
}