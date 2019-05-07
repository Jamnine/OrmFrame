using System;
using System.Configuration;

namespace Orm.Framework.Common
{
    public static class ShortMessage
    {
        #region 第三方注册信息
        
        //static string SN = "7SDK-LHW-0588-MKZSS";
        //static string PWD = "631964";
        //static string EName = "广州市行心信息科技有限公司";
        //static string UName = "陈世华";
        //static string Tel = "010-58750646";
        //static string Mobile = "13424077768";
        //static string Email = "babyzj@live.cn";
        //static string Fax = "010-58750500";
        //static string Address = "广州市萝岗区 科学大道33号,视联科技园 B栋501-505";
        //static string Postcode = "102208";

        static string SN = ConfigurationManager.AppSettings["SN"];
        static string PWD = ConfigurationManager.AppSettings["PWD"];
        static string EName = ConfigurationManager.AppSettings["EName"];
        static string UName = ConfigurationManager.AppSettings["UName"];
        static string Tel = ConfigurationManager.AppSettings["Tel"];
        static string Mobile = ConfigurationManager.AppSettings["Mobile"];
        static string Email = ConfigurationManager.AppSettings["Email"];
        static string Fax = ConfigurationManager.AppSettings["Fax"];
        static string Address = ConfigurationManager.AppSettings["Address"];
        static string Postcode = ConfigurationManager.AppSettings["Postcode"];
        #endregion

        private static MessageSDKService.SDKClientClient _SDKClient;
        public static bool GetSDKService()
        {
            int registEx = -1;
            int registDetailInfo = -1;
            _SDKClient = new MessageSDKService.SDKClientClient(); 
            registEx = _SDKClient.registEx(SN, PWD, PWD);
            registDetailInfo = _SDKClient.registDetailInfo(SN, PWD, EName, UName, Tel, Mobile, Email, Fax, Address, Postcode);
            if (registEx == 0 && registDetailInfo == 0)
            {
                return true;
            }
            return false;
        }

        public static bool SendMessage(string phone, string content)
        {
            try 
	        {
                if (!GetSDKService())
                    return false;
                var result = _SDKClient.sendSMS(SN, PWD, string.Empty, new string[] { phone }, content, string.Empty, "GBK", 3, Convert.ToInt64(DateTime.Now.ToString("yyyyMMddHHmmssfff")));
                if (result != 0)
                    return false;
                else
                    return true;
	        }
	        catch  
	        {
                return false;
	        }
            
        }

        public static string GetBalance()
        {
            try 
	        {
                if (!GetSDKService())
                { 
                    return string.Empty;
                }
                var ban = _SDKClient.getBalance(SN, PWD);
                return ban.ToString();
            }
            catch  
            {
                return string.Empty;
            }
        }
    }
}
