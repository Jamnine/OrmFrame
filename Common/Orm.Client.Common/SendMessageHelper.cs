using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace Orm.Client.Common
{
    /// <summary>
    /// 发送短信
    /// 调用CCPRestSDK.dll
    /// </summary>
    public class SendMessageHelper
    {
        /// <summary>
        /// 容联云，accountSID
        /// </summary>
        public static string RLY_AccountSID = "8aaf07085610bc7f015611eee3a60291";

        /// <summary>
        /// 容联云，AuthToken
        /// </summary>
        public static string RLY_AuthToken = "73bba0e15618417fa00d6f406127b892";

        /// <summary>
        /// 容联云，奥姆莱特Appid
        /// </summary>
        public static string RLY_AomulaiteAppId = "8a216da856bbaa9e0156c10abab10667";

        public static string SendMessage(string phoneNum)
        {
            CCPRestSDK.CCPRestSDK api = new CCPRestSDK.CCPRestSDK();
            //ip格式如下，不带https://
            bool isInit = api.init("sandboxapp.cloopen.com", "8883");
            api.setAccount(RLY_AccountSID, RLY_AuthToken);
            api.setAppId(RLY_AomulaiteAppId);
            if (!isInit)
            {
                throw new Exception("短信初始化失败");
            }
            Random ran = new Random();
            var verifyCode = ran.Next(100000, 999999);
            Dictionary<string, object> retData = api.SendTemplateSMS(phoneNum, "115658", new string[] { verifyCode.ToString(), "2" });
            if (retData["statusMsg"].ToString() == "成功")
            {
                return verifyCode.ToString();
            }
            else
            {
                throw new Exception(retData["statusMsg"].ToString());
            }
            //string ret = getDictionaryData(retData);


        }
    }
}
