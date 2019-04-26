// ===================================================================   
// Model  
// ===================================================================   
// File: BsVersion.cs  
//   
// Copyright   
// History:  
// 2015/1/28 10:42:28: Chen Envision   Original Version  
//   
// ===================================================================  

using System;

namespace Orm.Model
{
    /// <summary>  
    ///  版本信息
    /// </summary> 
    [Serializable]
 
    public partial class BsVersion : BaseModel
    {
        private string _name = String.Empty;
        private string _memo = String.Empty;
        private int _annualFee;

        public BsVersion()
        {
        }

        public  int ID { get; set; }
        /// <summary>  
        ///   版本名
        /// </summary>  
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>  
        /// 备注
        /// </summary>  
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }

        /// <summary>  
        /// 版本年费  
        /// </summary>  
        public int AnnualFee
        {
            get { return this._annualFee; }
            set { this._annualFee = value; }
        }

        /// <summary>
        /// 当前最新版本号
        /// </summary>
        public int CurrentVersionNum { get; set; }

    }
}
