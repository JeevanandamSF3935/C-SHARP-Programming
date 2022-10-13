using System;
namespace OnlineFoodOrder;
public interface IBalance
{
    double WalletBalance { get; set; }
    void WalletRecharge();  
}