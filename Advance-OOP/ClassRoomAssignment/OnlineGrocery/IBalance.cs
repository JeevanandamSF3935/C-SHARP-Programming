using System;
namespace OnlineGrocery;
public interface IBalance
{
    double WalletBalance{get;set;}
    void WalletRecharge();
}