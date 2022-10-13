namespace MultipleInheritance;
public interface IFamilyInfo:ShowData
{
    string FatherName { get; set; }
    string MotherName { get; set; }
    string HouseAddress { get; set; }
    int NoOfSiblings { get; set; }
}
