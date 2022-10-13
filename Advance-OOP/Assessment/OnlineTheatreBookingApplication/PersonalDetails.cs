namespace OnlineTheatreBookingApplication;

///<summary>
///Personal Details is a class contains a personal details of the user, properties and constructors
///</summary>
public class PersonalDetails
{
    ///<summary>
    ///Name is a property of class<see cref= "PersonalDetails"/> which get and set the name of the user.
    ///</summary>
    public string Name { get; set; }
    ///<summary>
    ///Age is a property of class<see cref= "PersonalDetails"/> which get and set the age of the user.
    ///</summary>
    public int Age { get; set; }
    ///<summary>
    ///PhoneNumber is a property of class<see cref= "PersonalDetails"/> which get and set the Phone Number of the user.
    ///</summary>
    public long PhoneNumber { get; set; }
    ///<summary>
    ///PersonalDetails is a default Counstructor of class<see cref= "PersonalDetails"/>.
    ///</summary>
    public PersonalDetails(){

    }
    ///<summary>
    ///PersonalDetails is a Parameterized Counstructor of class<see cref= "PersonalDetails"/>
    ///</summary>
    ///<param name = "name"> It is a parameter which carries the name of the user to the constructor of class<see cref = "PersonalDetails"/>.</param>
    ///<param name = "age"> It is a parameter which carries the age of the user to the constructor of class<see cref = "PersonalDetails"/>.</param>
    ///<param name = "phoneNumber"> It is a parameter which carries the phone number of the user to the constructor of class<see cref = "PersonalDetails"/>.</param>
    public PersonalDetails(string name,int age,long phoneNumber){
        Name = name;
        Age = age;
        PhoneNumber = phoneNumber;
    }
}