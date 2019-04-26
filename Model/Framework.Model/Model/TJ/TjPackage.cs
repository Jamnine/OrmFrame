// ===================================================================   
// Model  
// ===================================================================   
// File: TjPackage.cs  
//   
// Copyright   
// History:  
// 2015/12/18 17:10:08: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{  
    [Serializable]
    /// <summary>  
    ///  体检套餐 数据库不存在此表
    /// </summary>  
    public partial class TjPackage : BaseModel  
    {  
        private string _code = String.Empty;  
        private string _zdyCode = String.Empty;  
        private string _name = String.Empty;  
        private double _packagePrice;  
        private string _sex = String.Empty;  
        private int _useRangeId;  
        private string _comments = String.Empty;  
        private string _pyCode = String.Empty;  
        private string _wbCode = String.Empty;  
        private DateTime _modiTime;  
        private string _modiOperId;  
        private int _orderBy;  
        private bool _isActive;
        private string _modiOperName;
        private double _vipAmount;  
        public TjPackage()  
        {  
        }  
  
  
        /// <summary>  
        ///  套餐编号 
        /// </summary>  
        public string Code  
        {  
            get { return this._code; }  
            set { this._code = value; }  
        }  
  
        /// <summary>  
        ///  自定义码 
        /// </summary>  
        public string ZdyCode  
        {  
            get { return this._zdyCode; }  
            set { this._zdyCode = value; }  
        }  
  
        /// <summary>  
        ///  套餐名 
        /// </summary>  
        public string Name  
        {  
            get { return this._name; }  
            set { this._name = value; }  
        }  
  
        /// <summary>  
        /// 套餐价格  
        /// </summary>  
        public double PackagePrice  
        {  
            get { return this._packagePrice; }  
            set { this._packagePrice = value; }  
        }  
  
        /// <summary>  
        ///  性别限制 M男 F女 A通用 
        /// </summary>  
        public string Sex  
        {  
            get { return this._sex; }  
            set { this._sex = value; }  
        }  
  
        /// <summary>  
        ///  适用范围 1 个人 2单位 3通用 
        /// </summary>  
        public int UseRangeId 
        {  
            get { return this._useRangeId; }  
            set { this._useRangeId = value; }  
        }  
  
        /// <summary>  
        ///  备注 
        /// </summary>  
        public string Comments  
        {  
            get { return this._comments; }  
            set { this._comments = value; }  
        }  
  
        /// <summary>  
        ///   拼音码
        /// </summary>  
        public string PyCode  
        {  
            get { return this._pyCode; }  
            set { this._pyCode = value; }  
        }  
  
        /// <summary>  
        ///   五笔码
        /// </summary>  
        public string WbCode  
        {  
            get { return this._wbCode; }  
            set { this._wbCode = value; }  
        }  
  
        /// <summary>  
        ///   修改时间
        /// </summary>  
        public DateTime ModiTime  
        {  
            get { return this._modiTime; }  
            set { this._modiTime = value; }  
        }

        /// <summary>  
        ///    修改人ID
        /// </summary>  
        public string ModiOperId  
        {  
            get { return this._modiOperId; }  
            set { this._modiOperId = value; }  
        }

        /// <summary>  
        ///   序号
        /// </summary>  
        public int OrderBy  
        {  
            get { return this._orderBy; }  
            set { this._orderBy = value; }  
        }  
  
        /// <summary>  
        ///   是否活动
        /// </summary>  
        public bool IsActive  
        {  
            get { return this._isActive; }  
            set { this._isActive = value; }  
        }

        /// <summary>
        /// 修改操作员名称
        /// </summary>
        public string ModiOperName
        {
            get { return this._modiOperName; }
            set { this._modiOperName = value; }
        }
        /// <summary>
        /// 会员金额
        /// </summary>
        public double VIPAmount
        {
            get { return this._vipAmount; }
            set { this._vipAmount = value; }
        }
    }  
}  

