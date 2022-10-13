using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBLibrary
{
    public class BillCalculation
    {
        public static int s_meterID = 1000;
        public string MeterID { get; }
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }
        public string MailID { get; set; }
        public int UnitsUsed { get; set; }

        public BillCalculation(string userName, long phoneNumber, string mailID, int unitsUsed){
            s_meterID++;
            MeterID = "EB" + s_meterID;
            UserName = userName;
            PhoneNumber = phoneNumber;
            MailID = mailID;
            UnitsUsed = unitsUsed;
        }

        public void CalculateBill(){
            int billAmount = 0;
            if(UnitsUsed > 100 && UnitsUsed <= 200){
                billAmount = (UnitsUsed - 100) * 3;
            }
            else if(UnitsUsed > 200 && UnitsUsed <= 400){
                billAmount = 300 + (UnitsUsed - 200) * 5;
            }
            else if(UnitsUsed > 400){
                billAmount = 300 + 1000 + (UnitsUsed - 400) * 6;
            }
            System.Console.WriteLine($"Bill Amount for {UnitsUsed} units is Rs.{billAmount}");
        }
    }
}