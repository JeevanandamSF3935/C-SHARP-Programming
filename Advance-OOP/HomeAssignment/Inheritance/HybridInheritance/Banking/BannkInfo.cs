using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class BannkInfo
    {
        public string BankName { get; set; }

        public string IFSC { get; set; }

        public string Branch { get; set; }

        public BannkInfo(string bankname, string ifsc, string branch)
        {
            BankName = bankname;
            IFSC = ifsc;
            Branch = branch;
        }
    }
}