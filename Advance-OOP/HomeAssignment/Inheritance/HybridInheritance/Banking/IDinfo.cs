using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise2
{
    public class IDinfo : PersonalInfo
    {
        public string VoterID { get; set; }

        public string AadharNumber { get; set; }

        public string PAN { get; set; }

        public IDinfo(string voterid, string aadhar, string pan, string name, Gender sex, long phone, long mobile, DateTime dob) : base (name, sex, phone, mobile, dob)
        {
            VoterID = voterid;
            AadharNumber = aadhar;
            PAN = pan;
        }


    }
}