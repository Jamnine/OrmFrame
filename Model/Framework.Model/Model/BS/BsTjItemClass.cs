// ===================================================================   
// Model  
// ===================================================================   
// File: BsTjItemClass.cs  
//   
// Copyright   
// History:  
// 2015/12/18 16:59:59: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  体检项目类别
    /// </summary> 
    [Serializable]
    public partial class BsTjItemClass : BaseModel  
    {  
        private string _code = String.Empty;  
        private string _zdyCode = String.Empty;  
        private string _name = String.Empty;  
        private string _typeId;  
        private string _pyCode = String.Empty;  
        private string _wbCode = String.Empty;  
        private DateTime _modiTime;  
        private string _modiOperId;  
        private int _orderBy;  
        private bool _isActive;  
  
        public BsTjItemClass()  
        {  
        }  
  
  
        /// <summary>  
        ///  类别编码
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
        ///  类别名称 
        /// </summary>  
        public string Name  
        {  
            get { return this._name; }  
            set { this._name = value; }  
        }  
  
        /// <summary>  
        ///  项目类型ID(BsTjItemType的ID) 
        /// </summary>  
        public string TypeId  
        {  
            get { return this._typeId; }  
            set { this._typeId = value; }  
        }  
  
        /// <summary>  
        ///拼音码
        /// </summary>  
        public string PyCode  
        {  
            get { return this._pyCode; }  
            set { this._pyCode = value; }  
        }  
  
        /// <summary>  
        /// 五笔码
        /// </summary>  
        public string WbCode  
        {  
            get { return this._wbCode; }  
            set { this._wbCode = value; }  
        }  
  
        /// <summary>  
        ///修改时间
        /// </summary>  
        public DateTime ModiTime  
        {  
            get { return this._modiTime; }  
            set { this._modiTime = value; }  
        }  
  
        /// <summary>  
        ///修改操作人id
        /// </summary>  
        public string ModiOperId  
        {  
            get { return this._modiOperId; }  
            set { this._modiOperId = value; }  
        }  
  
        /// <summary>  
        ///   排序
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

