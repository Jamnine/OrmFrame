using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace Orm.Client.Common
{
    public class ClientValidationHelper
    {
        /// <summary>
        /// 客人判断
        /// </summary>
        /// <param name="currentPatient">当前客人</param>
        /// <param name="isShowRemind">是否弹窗（/可填/可不填）</param>
        /// <param name="message">需要弹窗的内容（/可填/可不填）</param>
        /// <returns></returns>
        public static bool ValidationPatientIsNULL(Model.Custom.uspHisOuPatientQry currentPatient, bool isShowRemind = true, string message = "请选择客人！")
        {
            if (currentPatient == null)
            {
                if (isShowRemind)
                    //Orm.Client.Base.FrmMessageRemind.Show(message);
                return false;
            }
            return true;
        }
    }
}
