// ===================================================================   
// Model  
// ===================================================================   
// File: BsTjItemType.cs  
//   
// Copyright   
// History:  
// 2015/12/18 17:03:19: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  体检项目类型
    /// </summary>  
    [Serializable]
    public partial class BsTjItemType : BaseModel  
    {  
        private string _name = String.Empty;  
        private string _pyCode = String.Empty;  
        private string _wbCode = String.Empty;  
        private DateTime _modiTime;  
        private string _modiOperId;  
        private int _orderBy;  
        private bool _isActive;

        /// <summary>  
        ///  体检项目类别
        /// </summary>  
        public BsTjItemType()  
        {  
        }  
  
  
        /// <summary>  
        ///   类型名称
        /// </summary>  
        public string Name  
        {  
            get { return this._name; }  
            set { this._name = value; }  
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
        ///   最后修改时间
        /// </summary>  
        public DateTime ModiTime  
        {  
            get { return this._modiTime; }  
            set { this._modiTime = value; }  
        }  
  
        /// <summary>  
        ///   最后修改人ID
        /// </summary>  
        public string ModiOperId  
        {  
            get { return this._modiOperId; }  
            set { this._modiOperId = value; }  
        }  
  
        /// <summary>  
        ///   顺序
        /// </summary>  
        public int OrderBy  
        {  
            get { return this._orderBy; }  
            set { this._orderBy = value; }  
        }

        /// <summary>  
        ///   是否启用
        /// </summary>  
        public bool IsActive  
        {  
            get { return this._isActive; }  
            set { this._isActive = value; }  
        }  
  
    }  
}  

