// ===================================================================   
// Model  
// ===================================================================   
// File: TjDisease.cs  
//   
// Copyright   
// History:  
// 2015/12/21 15:06:36: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    /// 体检疾病情况  数据库不存在此表
    /// </summary>
    [Serializable]
    public partial class TjDisease : BaseModel
    {
        private string _mzRegId;
        private string _sID;
        private string _tjLocationID;
        private string _flag;

        public TjDisease()
        {
        }

        /// <summary>  
        /// 就诊ID  
        /// </summary>  
        public string MzRegId
        {
            get { return this._mzRegId; }
            set { this._mzRegId = value; }
        }

        /// <summary>  
        /// 诊断建议ID  
        /// </summary>  
        public string SID
        {
            get { return this._sID; }
            set { this._sID = value; }
        }

        /// <summary>  
        /// 体检科室ID  
        /// </summary>  
        public string TjLocationID
        {
            get { return this._tjLocationID; }
            set { this._tjLocationID = value; }
        }

        /// <summary>  
        /// 是否疾病：1 疾病 2异常 3提示 9其他  
        /// </summary>  
        public string Flag
        {
            get { return this._flag; }
            set { this._flag = value; }
        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID { get; set; }
    }
}

