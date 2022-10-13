namespace OnlineTheatreBookingApplication;
public interface IWallet
{
    double WalletBalance{ get; set; }
    void WalletRecharge(double data);
}