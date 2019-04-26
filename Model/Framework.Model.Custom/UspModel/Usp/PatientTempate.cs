using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model.Custom.UspModel
{
    /// <summary>
    /// 病人信息模板
    /// </summary>
    [Serializable]
    public class PatientTempate
    {
        public PatientTempate()
        {
            PatientQry = new uspPatientQry();
        }
        public bool IsSelectSend { get; set; }
        public bool IsRightPhone
        {
            get
            {
                if (PatientQry.Mobile == string.Empty || PatientQry.Mobile == null)
                {
                    return false;
                }
                else
                {
                    return PatientQry.Mobile.Length == 11 && PatientQry.Mobile.Trim().Substring(0, 1) == "1";
                }
            } 
        }
        public uspPatientQry PatientQry { get; set; }
    }
}
