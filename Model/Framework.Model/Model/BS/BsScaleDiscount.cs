// ===================================================================   
// Model  
// ===================================================================   
// File: BsScaleDiscount.cs  
//   
// Copyright   
// History:  
// 2015/1/26 9:32:45: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    ///  优惠折扣表
    /// </summary> 
    [Serializable]  
     
    public partial class BsScaleDiscount : BaseModel  
    {  
        private string _code = String.Empty;  
        private string _name = String.Empty;
        private double _scaleType;  
        private string _pyCode = String.Empty;  
        private string _wbCode = String.Empty;  
        private int _orderBy;  
        private bool _isActive;  
  
        public BsScaleDiscount()  
        {  
        }  
  
  
        /// <summary>  
        /// 编码  
        /// </summary>  
        [Collumn(HeaderName = "编码", RelatedTableType = null, Length = 6)]
        public string Code  
        {  
            get { return this._code; }  
            set { this._code = value; }  
        }  
  
        /// <summary>  
        /// 名称  
        /// </summary>  
        [Collumn(HeaderName = "名称", RelatedTableType = null, Length = 50)]
        public string Name  
        {  
            get { return this._name; }  
            set { this._name = value; }  
        }

        /// <summary>  
        /// 比例  
        /// </summary>
        [Collumn(HeaderName="比例")]
        public double ScaleType 
        {
            get { return this._scaleType; }
            set { this._scaleType = value; }  
        }  
  
        /// <summary>  
        /// 拼音码  
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
        /// 排序  
        /// </summary>  
        public int OrderBy  
        {  
            get { return this._orderBy; }  
            set { this._orderBy = value; }  
        }  
  
        /// <summary>  
        /// 是否启用  
        /// </summary>  
        public bool IsActive  
        {  
            get { return this._isActive; }  
            set { this._isActive = value; }  
        }  
  
    }  
}  

