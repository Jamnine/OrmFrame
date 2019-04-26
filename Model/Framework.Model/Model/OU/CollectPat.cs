// ===================================================================   
// Model  
// ===================================================================   
// File: CollectPat.cs  
//   
// Copyright   
// History:  
// 2014/12/15 15:32:41: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  收藏病人   数据库不存在此表
    /// </summary>  
    [Serializable]  
   
    public partial class CollectPat : BaseModel  
    {  
        private string _cardNo = String.Empty;  
        private string _name = String.Empty;  
        private string _sex = String.Empty;  
        private string _ageString;  
        private string _patType = String.Empty;
        private string _doctorID;
        private string _patID;
        private DateTime _lastSeeTime;  
        private string _mark = String.Empty;  
        private string _operation = String.Empty;  
        private DateTime _lastUpdateTime;  
  
        public CollectPat()  
        {  
        }  
  
  
        /// <summary>  
        ///   卡号
        /// </summary>  
        public string CardNo  
        {  
            get { return this._cardNo; }  
            set { this._cardNo = value; }  
        }  
  
        /// <summary>  
        ///   名字
        /// </summary>  
        public string Name  
        {  
            get { return this._name; }  
            set { this._name = value; }  
        }  
  
        /// <summary>  
        ///  性别
        /// </summary>  
        public string Sex  
        {  
            get { return this._sex; }  
            set { this._sex = value; }  
        }  
  
        /// <summary>  
        ///  年龄 字符串
        /// </summary>  
        public string Age
        {
            get { return this._ageString; }
            set { this._ageString = value; }  
        }  
  
        /// <summary>  
        ///  病人类别
        /// </summary>  
        public string PatType  
        {  
            get { return this._patType; }  
            set { this._patType = value; }  
        }

        /// <summary>
        /// 医生id
        /// </summary>
        public string DoctorID
        {
            get { return this._doctorID; }
            set { this._doctorID = value; }
        }

        /// <summary>
        /// 病人ID
        /// </summary>
        public string PatID
        {
            get { return this._patID; }
            set { this._patID = value; }
        }  
  
  
        /// <summary>  
        ///   上一次接诊时间
        /// </summary>  
        public DateTime LastSeeTime  
        {  
            get { return this._lastSeeTime; }  
            set { this._lastSeeTime = value; }  
        }  
  
        /// <summary>  
        ///   备注
        /// </summary>  
        public string Mark  
        {  
            get { return this._mark; }  
            set { this._mark = value; }  
        }  
  
        /// <summary>  
        ///   相关操作
        /// </summary>  
        public string Operation  
        {  
            get { return this._operation; }  
            set { this._operation = value; }  
        }  
  
        /// <summary>  
        ///   最后更新时间
        /// </summary>  
        public DateTime LastUpdateTime  
        {  
            get { return this._lastUpdateTime; }  
            set { this._lastUpdateTime = value; }  
        }  
  
    }  
}  

