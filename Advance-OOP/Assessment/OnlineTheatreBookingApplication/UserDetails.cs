namespace OnlineTheatreBookingApplication;

///<summary>
///User Details is a class contains a user details properties and constructors and it is inherited form class <see cref = "PersonalDetails"/>
///and Interface<see cref="IWallet"/>
///</summary>
public class UserDetails:PersonalDetails,IWallet
{
    ///<summary>
    ///s_userID is a static private field which is used to auto increase for userId generation in class<see cref = "UserDetails"/>
    ///</summary>
    private static int s_userID = 1000;
    ///<summary>
    ///UserID is a property of class <see cref = "UserDetails"/> which get the userID of user
    ///</summary>
    public string UserID { get;}
    ///<summary>
    ///WalletBalance is a proerty of  class <see cref = "UserDetails"/> which get and set the wallet balance of the user
    ///</summary>
    public double WalletBalance { get; set; }
    ///<summary>
    ///UserDetails is a Default constructor of class <see cref = "UserDetails"/>
    ///</summary>
    public UserDetails(){

    }
    ///<summary>
    ///UserDetails is a Parameterized overloaded constructor of class <see cref = "UserDetails"/> with three parameters and transfer the user data to the parent class<see cref = "PersonalDetails"/>
    ///</summary>
    ///<param name = "name">It is a parameter which carries the name of the user to the constructor of class<see cref = "UserDetails"/>.</param>
    ///<param name = "age">It is a parameter which carries the age of the user to the constructor of class<see cref = "UserDetails"/>.</param>
    ///<param name = "phoneNumber">It is a parameter which carries the phone number of the user to the constructor of class<see cref = "UserDetails"/>.</param>
    public UserDetails(string name,int age,long phoneNumber):base(name,age,phoneNumber){
        s_userID++;
        UserID = "UID" + s_userID;
        WalletBalance = 0;
    }
    ///<summary>
    ///UserDetails is a parameterized overloaded constructor of class <see cref = "UserDetails"/> with one parameter
    ///</summary>
    ///<param name = "data">It is a parameter which carries the datas as string of the user to the constructor of class<see cref = "UserDetails"/>.</param>
    public UserDetails(string data){
        string[] values = data.Split(',');
        s_userID = int.Parse(values[0].Remove(0,3));
        UserID = values[0];
        Name = values[1];
        Age = int.Parse(values[2]);
        PhoneNumber = long.Parse(values[3]);
        WalletBalance = double.Parse(values[4]);
    }
    ///<summary>
    ///WalletRecharge is a method sets the wallet balance amount to the Wallet balance property of class<see cref = "UserDetails"/>
    ///</summary>
    ///<param name = "amount">It is a parameter which carries the given amount of the user for recharge, to the constructor of class<see cref = "UserDetails"/>.</param>
    public void WalletRecharge(double amount){
        WalletBalance += amount;
    } 
}