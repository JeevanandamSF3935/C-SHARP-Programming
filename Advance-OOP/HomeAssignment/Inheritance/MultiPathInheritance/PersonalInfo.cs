
namespace Multipath
{   
    public enum Gender { Default, Male, Female, Transgender }
    public interface IPersonalInfo
    {
         string AadharNumber { get; set; }

         string Name { get; set; }

         string FatherName { get; set; }

         long Phone { get; set; }

        
    }


}