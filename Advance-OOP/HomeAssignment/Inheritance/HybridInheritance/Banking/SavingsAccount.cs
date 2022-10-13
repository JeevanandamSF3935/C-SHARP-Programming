using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class SavingsAccount : IDinfo, Icalculate, BannkInfo
    {
        public string AccountNumber { get; set; }

        public string AccountType { get; set; }

        public void Deposit()
        {

        }

        public void WithDraw()
        {

        }

        public void BalanceCheck()
        {

        }

        public SavingsAccount(string accountno, string accounttype, string bankname, string ifsc, string branch, string voterid, string aadhar, string pan, string name, Gender sex, long phone, long mobile, DateTime dob) : base(voterid, aadhar,  pan, name, sex, phone, mobile,  dob)
        {

        }
    }
}