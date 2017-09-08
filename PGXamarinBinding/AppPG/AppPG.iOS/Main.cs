using System;
using System.Collections.Generic;
using System.Linq;
using PGBind;
using Foundation;
using UIKit;

namespace AppPG.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            //    if you want to use a different Application Delegate class from "AppDelegate"
            //     you can specify it here.
            FPGWRequest Requestinfo = new FPGWRequest();
            Requestinfo.TendType = "CREDIT";
            Requestinfo.TranType = "SALE";
            Requestinfo.Amount = "7.00";
            Requestinfo.TipAmount = "0.00";
            Requestinfo.InvcNo = "10101";
            Requestinfo.User = "paulpgtest";
            Requestinfo.Pwd = "57!sE@3Fm";
            Requestinfo.MerchCode = "682000";
            Requestinfo.MerchAcctCode = "682001";
            Requestinfo.RefNo = "";
            Requestinfo.CashBackAmt = "0.00";
            Requestinfo.DeviceType = "rbabt";
            Requestinfo.TestMode = "TRUE";
            Requestinfo.ClerkID = "gwazoo";
            Requestinfo.RegisterID = "REG-01";
            FPGWResponse ResponseInfo = new FPGWResponse();
            FPGWrapper FW = new FPGWrapper();
            bool Ok = FW.ProcessRequest(Requestinfo, ResponseInfo);
            if (Ok == true)
            {

            }
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
