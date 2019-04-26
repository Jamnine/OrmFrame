// ===================================================================   
// Model  
// ===================================================================   
// File: TjItemResultTmp.cs  
//   
// Copyright   
// History:  
// 2015/12/18 17:08:14: Chen Envision   Original Version  
//   
// ===================================================================  
  
using System;  
  
namespace Orm.Model  
{
    /// <summary>  
    /// 体检项目结果模板  数据库不存在此表
    /// </summary>  
    [Serializable]  
    public partial class TjItemResultTmp : BaseModel  
    {  
        private string _tjItemCode = String.Empty;  
        private string _referResult = String.Empty;  
        private string _diagnosis = String.Empty;  
        private string _suggestion = String.Empty;  
        private bool _isAbNormal;  
        private int _orderBy;  
  
        public TjItemResultTmp()  
        {  
        }  
  
  
        /// <summary>  
        ///  体检项目编码 
        /// </summary>  
        public string TjItemCode  
        {  
            get { return this._tjItemCode; }  
            set { this._tjItemCode = value; }  
        }  
  
        /// <summary>  
        /// 参考结果  
        /// </summary>  
        public string ReferResult  
        {  
            get { return this._referResult; }  
            set { this._referResult = value; }  
        }  
  
        /// <summary>  
        /// 诊断  
        /// </summary>  
        public string Diagnosis  
        {  
            get { return this._diagnosis; }  
            set { this._diagnosis = value; }  
        }  
  
        /// <summary>  
        /// 建议  
        /// </summary>  
        public string Suggestion  
        {  
            get { return this._suggestion; }  
            set { this._suggestion = value; }  
        }  
  
        /// <summary>  
        /// 是否异常  
        /// </summary>  
        public bool IsAbNormal  
        {  
            get { return this._isAbNormal; }  
            set { this._isAbNormal = value; }  
        }  
  
        /// <summary>  
        ///   排序
        /// </summary>  
        public int OrderBy  
        {  
            get { return this._orderBy; }  
            set { this._orderBy = value; }  
        }  
  
    }  
}  

