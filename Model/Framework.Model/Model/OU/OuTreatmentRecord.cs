using NLite.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orm.Model
{
    //数据库不存在此表
    [Serializable]
    public partial class OuTreatmentRecord : BaseModel
    {
        private string _operId;
        private DateTime _operTime;
        private string _patID;
        private string _mzRegId;
        private int _hospitalId;
        private string _diagnosis = String.Empty;
        private string _treatment = String.Empty;
        private int _docLevType=0;

        public OuTreatmentRecord()
        {

        }

        /// <summary>  
        ///   
        /// </summary>  
        public string Diagnosis
        {
            get { return this._diagnosis; }
            set { this._diagnosis=value; }
        }

        /// <summary>  
        /// 治疗建议  
        /// </summary>  
        public string Treatment
        {
            get { return this._treatment; }
            set { this._treatment = value; }
        }

        /// <summary>  
        ///   操作人ID
        /// </summary>  
        public string OperId
        {
            get { return this._operId; }
            set { this._operId = value; }
        }

        /// <summary>  
        /// 操作时间
        /// </summary>  
        public DateTime OperTime
        {
            get { return this._operTime; }
            set { this._operTime = value; }
        }

        /// <summary>  
        ///患者ID
        /// </summary>  
        public string PatID
        {
            get { return this._patID; }
            set { this._patID = value; }
        }

        /// <summary>  
        ///   门诊Id 
        /// </summary>  
        public string MzRegId
        {
            get { return this._mzRegId; }
            set { this._mzRegId = value; }
        }
        /// <summary>
        /// 角色类型（1：营养师，2：运动师，3：中医师 4：心理医生，5：其他医师）
        /// </summary>
        public int DocLevType
        {
            get { return this._docLevType; }
            set { this._docLevType = value; }
        }
    }
}
